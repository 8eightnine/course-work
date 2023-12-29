using Kursovaia.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class PersonalCard : Form
    {
        private Patient _patient = null;
        private DataTable dataTable = new DataTable();
        private List<MedicalHistory> _medicalHistory = new List<MedicalHistory>();

        public PersonalCard(Patient patient)
        {
            this._patient = patient;

            InitializeComponent();
            StatusCompleted.Visible = false;
            StatusUncompleted.Visible = false;
            ResultTextBox.Visible = false;
            // Заполняем поля данными
            dataTable.Columns.Add("Дата");
            dataTable.Columns.Add("Тип");
            if (patient.Appointments != null)
                _medicalHistory.AddRange(patient.Appointments);
            else patient.Appointments = new List<Appointment>();
            if (patient.Tests != null)
                _medicalHistory.AddRange(patient.Tests);
            else patient.Tests = new List<Test>();
            if (_patient.PersonalInfo != null)
                UpdateInfo();
            else
            {
                _patient.PersonalInfo = new PersonalInfo();
            }
            BirthdayDateTimePicker.Value = DateTime.Now;
            BirthdayDateTimePicker.MaxDate = DateTime.Now;
        }

        private void MedicalHistoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Показать информацию
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                MedicalHistoryDateTimePicker.Value = _medicalHistory[e.RowIndex].Date;
                InfoTextBox.Text = _medicalHistory[e.RowIndex].Info;
                if (_medicalHistory[e.RowIndex].Type.Equals("Анализ"))
                {
                    StatusCompleted.Visible = false;
                    StatusUncompleted.Visible = false;
                    ResultTextBox.Visible = true;
                    Test temp = (Test)_medicalHistory[e.RowIndex];
                    ResultTextBox.Text = temp.Results;
                }

                if (_medicalHistory[e.RowIndex].Type.Equals("Запись"))
                {
                    ResultTextBox.Visible = false;
                    StatusCompleted.Visible = true;
                    StatusUncompleted.Visible = true;
                    Appointment temp = (Appointment)_medicalHistory[e.RowIndex];
                    if(temp.Status == true)
                        StatusCompleted.Checked = true;
                    else StatusUncompleted.Checked = true;
                }
            }
        }

        private void AllowEditing_CheckStateChanged(object sender, EventArgs e)
        {
            // Включить/выключить изменение данных
            SurnameTextBox.Enabled = AllowEditing.Checked;
            NameTextBox.Enabled = AllowEditing.Checked;
            FathernameTextBox.Enabled = AllowEditing.Checked;
            GenderFemale.Enabled = AllowEditing.Checked;
            GenderMale.Enabled = AllowEditing.Checked;
            BirthdayDateTimePicker.Enabled = AllowEditing.Checked;
            GenderFemale.Enabled = AllowEditing.Checked;
            GenderMale.Enabled = AllowEditing.Checked;
            WarningLabel.Visible = AllowEditing.Checked;

            if (!AllowEditing.Checked) // Обновление данных
            {
                UpdatePerson(_patient, SurnameTextBox.Text, 1);
                UpdatePerson(_patient, NameTextBox.Text, 2);
                UpdatePerson(_patient, FathernameTextBox.Text, 3);
                UpdatePerson(_patient, BirthdayDateTimePicker.Text, 4);
                if (GenderFemale.Checked || GenderMale.Checked)
                    _patient.PersonalInfo.Gender = (GenderMale.Checked) ? "М" : "Ж";
                else MessageBox.Show("Ошибка: Выберите пол пациента.");
                UpdateInfo();
            }
        }

        // Добавить посещение
        private void AddAppointmentButton_Click(object sender, EventArgs e)
        { 
            dataTable.Rows.Add(MedicalHistoryDateTimePicker.Value.ToString("dd.MM.yyyy"), "");
            MedicalHistory mh = new Appointment();
            mh.Date = MedicalHistoryDateTimePicker.Value;
            mh.Type = "Запись";
            _medicalHistory.Add(mh);
            UpdateInfo();
        }

        // Добавить анализ
        private void AddTestButton_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(MedicalHistoryDateTimePicker.Value.ToString("dd.MM.yyyy"), "");
            MedicalHistory mh = new Test();
            mh.Date = MedicalHistoryDateTimePicker.Value;
            mh.Type = "Анализ";
            _medicalHistory.Add(mh);
            UpdateInfo();
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MedicalHistoryView.SelectedCells.Count > 0 && MedicalHistoryView.CurrentCell.RowIndex != -1 && MedicalHistoryView.CurrentCell.ColumnIndex != -1)
            {
                string[] infoSeparators = new string[] { "\n\n" };
                _medicalHistory[MedicalHistoryView.CurrentCell.RowIndex].Info = InfoTextBox.Text.Split(infoSeparators, StringSplitOptions.None).First();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(MedicalHistoryView.SelectedCells.Count > 0 && MedicalHistoryView.CurrentCell.RowIndex != -1 && MedicalHistoryView.CurrentCell.ColumnIndex != -1)
            {
                _medicalHistory[MedicalHistoryView.CurrentCell.RowIndex].Date = MedicalHistoryDateTimePicker.Value;
            }
        }

        // Обновить интерфейс
        private void UpdateInfo()
        {
            // Персональная информация
            SurnameTextBox.Text = _patient.PersonalInfo.Surname;
            NameTextBox.Text = _patient.PersonalInfo.Name;
            FathernameTextBox.Text = _patient.PersonalInfo.Fathername;
            if (_patient.PersonalInfo.Gender != null && _patient.PersonalInfo.Gender.Equals("М"))
                GenderMale.Checked = true;
            else GenderFemale.Checked = true;
            if (_patient.PersonalInfo.Birthday >= BirthdayDateTimePicker.MinDate && _patient.PersonalInfo.Birthday <= BirthdayDateTimePicker.MaxDate)
                BirthdayDateTimePicker.Value = _patient.PersonalInfo.Birthday;

            // Записи
            dataTable.Clear();
            foreach (MedicalHistory history in _medicalHistory)
            {
                dataTable.Rows.Add(
                    history.Date.ToString("dd.MM.yyy"),
                    history.Type
                    );
            }
            MedicalHistoryView.DataSource = dataTable;
        }

        private void dateTimePicker2_Leave(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void InfoTextBox_Leave(object sender, EventArgs e)
        {

            UpdateInfo();
        }

        public static void CheckString(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Поле не может быть пустым");
            if (!Regex.IsMatch(value, @"^[А-Яа-я]*$"))
                throw new Exception("Поле содержит недопустимые символы");

        }

        public static void CheckDateTime(DateTime value)
        {
            if (value > DateTime.Now)
                throw new Exception("Дата не может быть больше текущей");
        }

        public static void UpdatePerson(Patient p, string info, int index)
        {
            switch (index)
            {
                case 1:
                    {
                        try { CheckString(info); }
                        catch (Exception e) { MessageBox.Show("Ошибка в поле 'Фамилия': " + e.Message); break; }
                        p.PersonalInfo.Surname = info;
                        break;
                    }
                case 2:
                    {
                        try { CheckString(info); }
                        catch (Exception e) { MessageBox.Show("Ошибка в поле 'Имя': " + e.Message); break; }
                        p.PersonalInfo.Name = info;
                        break;
                    }
                case 3:
                    {
                        try { CheckString(info); }
                        catch (Exception e) { MessageBox.Show("Ошибка в поле 'Отчество': " + e.Message); break; }
                        p.PersonalInfo.Fathername = info;
                        break;
                    }
                case 4:
                    {
                        try { CheckDateTime(DateTime.ParseExact(info, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture)); }
                        catch (Exception e) { MessageBox.Show("Ошибка в поле 'Дата рождения': " + e.Message); break; }
                        p.PersonalInfo.Birthday = DateTime.ParseExact(info, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        break;
                    }
                default: break;
            }
        }

        private void PersonalCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _patient.Appointments.Clear();
            _patient.Tests.Clear();

            _patient.Appointments = _medicalHistory
                .Where(history => history is Appointment)
                .Cast<Appointment>() 
                .ToList();

            _patient.Tests = _medicalHistory
                .Where(history => history is Test) 
                .Cast<Test>() 
                .ToList();

            if (_patient.PersonalInfo.Name == null || _patient.PersonalInfo.Surname == null || _patient.PersonalInfo.Fathername == null || _patient.PersonalInfo.Gender == null)
            {
                _patient.PersonalInfo = null;
                MessageBox.Show("Заполнены не все необходимые поля, изменения не сохранены.");
            }
            }

        // Удалить запись
        private void DeleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_medicalHistory.Count != 0)
            if (MedicalHistoryView.CurrentCell.RowIndex != -1 && MedicalHistoryView.CurrentCell.ColumnIndex != -1)
            {
                if (MessageBox.Show(
                    $"Удалить информацию: {_medicalHistory[MedicalHistoryView.CurrentCell.RowIndex].Date.ToString("dd.MM.yyyy")}: {_medicalHistory[MedicalHistoryView.CurrentCell.RowIndex].Type}",
                    "Сохранить изменения?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _medicalHistory.RemoveAt(MedicalHistoryView.CurrentCell.RowIndex);
                    UpdateInfo();
                }
            }
        }

        // Напечатать отчет об анализе
        private void PrintTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_medicalHistory.Count != 0)
            if(MedicalHistoryView.CurrentCell.RowIndex != -1 && MedicalHistoryView.CurrentCell.ColumnIndex != -1)
            {
                if (_medicalHistory.ElementAt(MedicalHistoryView.CurrentCell.RowIndex).Type.Equals("Анализ"))
                {
                    TestForm PrintTest = new TestForm((Test)_medicalHistory.ElementAt(MedicalHistoryView.CurrentCell.RowIndex), _patient);
                    PrintTest.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выбран неверный элемент: выберите строку с типом 'Анализ'");
                }
            }
        }

        private void GenderMale_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderMale.Checked)
            {
                GenderFemale.Checked = false;
                _patient.PersonalInfo.Gender = "М";
            }
        }

        private void GenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderFemale.Checked)
            {
                GenderMale.Checked = false;
                _patient.PersonalInfo.Gender = "Ж";
            }
        }

        private void StatusCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusCompleted.Checked )
            {
                Appointment temp = (Appointment)_medicalHistory[MedicalHistoryView.CurrentCell.RowIndex];
                temp.Status = true;
                _medicalHistory[MedicalHistoryView.CurrentCell.RowIndex] = temp;
            }
        }

        private void StatusUncompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusUncompleted.Checked)
            {
                Appointment temp = (Appointment)_medicalHistory[MedicalHistoryView.CurrentCell.RowIndex];
                temp.Status = false;
                _medicalHistory[MedicalHistoryView.CurrentCell.RowIndex] = temp;
            }
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {
            Test temp = (Test)_medicalHistory[MedicalHistoryView.CurrentCell.RowIndex];
            temp.Results = ResultTextBox.Text;
            _medicalHistory[MedicalHistoryView.CurrentCell.RowIndex] = temp;
        }
    }
}
