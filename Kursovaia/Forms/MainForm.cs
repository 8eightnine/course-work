using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class MainForm : Form
    {
        private Database db = new Database();
        private DataTable dt = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Имя");
            dt.Columns.Add("Отчество");
            dt.Columns.Add("Дата рождения");
            dt.Columns.Add("Пол");
            try
            {
                db = JsonConvert.DeserializeObject<Database>(File.ReadAllText("db.json"));
                if (db == null)
                {
                    db = new Database();
                    db.Patients = new List<Patient>();
                    DataBaseToolStripMenuItem.Enabled = false;
                }
                UpdateTable();
            }
            catch 
            {
                if (MessageBox.Show(
                    $"Программа не нашла файл базы данных пациентов. Создать новый файл?",
                    "Выберите действие",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Create("db.json");
                }
                else { DatabaseTab.Visible = false; }
            }
        }

        // О программе
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа по дисциплине 'Программирование', автор: Бузмаков Антон АП-227");
        }

        // Открыть медицинскую карту выбранного пациента
        private void PatientsView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Form card = new PersonalCard(db.Patients[e.RowIndex]);
                card.FormClosed += delegate
                {
                    UpdateTable();
                };
                card.ShowDialog();
            }
        }

        public void UpdateTable()
        {
            if (db != null)
            {
                dt.Clear();
                foreach (Patient patient in db.Patients)
                {
                    PersonalInfo personalInfo = patient.PersonalInfo;
                    dt.Rows.Add(
                        personalInfo.Surname,
                        personalInfo.Name,
                        personalInfo.Fathername,
                        personalInfo.Birthday.ToString("dd.MM.yyyy"),
                        personalInfo.Gender);
                }
                PatientsView.DataSource = dt;
            }
        }

        // Сохранение на выходе
        private void SaveOnClose(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Подтвердите изменение", "Сохранить изменения?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string json = JsonConvert.SerializeObject(db, Formatting.Indented);
                File.WriteAllText("db.json", json);
            }
        }

        // Удалить пациента
        private void DeletePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(db.Patients.Count != 0)
            if (PatientsView.CurrentCell.RowIndex != -1 && PatientsView.CurrentCell.ColumnIndex != -1)
            {
                if (MessageBox.Show(
                    $"Удалить пациента: {db.Patients[PatientsView.CurrentCell.RowIndex].PersonalInfo.Surname} {db.Patients[PatientsView.CurrentCell.RowIndex].PersonalInfo.Name}",
                    "Сохранить изменения?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Patients.RemoveAt(PatientsView.CurrentCell.RowIndex);
                    UpdateTable();
                }
            }
        }

        // Создать справку
        private void CreateMedicalDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (db.Patients.Count != 0)
            if (PatientsView.CurrentCell.RowIndex != -1 && PatientsView.CurrentCell.ColumnIndex != -1)
            {
                Form DocumentForm = new DocumentForm(db.Patients[PatientsView.CurrentCell.RowIndex]);
                DocumentForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Не выбран пациент");
            }
        }

        // Добавить пациента
        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            
            Form newCard = new PersonalCard(newPatient);
            newCard.FormClosed += delegate
            {
                if (newPatient.PersonalInfo != null)
                {
                    db.Patients.Add(newPatient);
                    UpdateTable();
                }
            };
            newCard.ShowDialog();
        }

        // Создать новую базу данных
        private void CreateNewDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(
                    $"Вы уверены что хотите создать новую базу данных пациентов? Все старые данные будут удалены без возможности восстановления.",
                    "Выберите действие",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists("db.json"))
                {
                    File.WriteAllText("db.json", "");
                    db.Patients.Clear();
                    UpdateTable();
                }
                else
                {
                    File.Create("db.json");
                    UpdateTable();
                }

            }
        }
    }
}
