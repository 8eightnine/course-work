using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class DocumentForm : Form
    {
        public DocumentForm(Patient p)
        {
            InitializeComponent();

            //Добавляем информацию о пациенте
            FIOLabel.Text = p.PersonalInfo.Surname + " " + p.PersonalInfo.Name + " " + p.PersonalInfo.Fathername;
            var age = DateTime.Today.Year - p.PersonalInfo.Birthday.Year;
            if (p.PersonalInfo.Birthday.Date > DateTime.Today.AddYears(-age)) age--;
            AgeLabel.Text = age.ToString();
            TodayDayLabel.Text = DateTime.Today.Day.ToString("");
            TodayMonthLabel.Text = DateTime.Today.Month.ToString();
            TodayYearLabel.Text = DateTime.Today.Year.ToString("");
            DocumentNumberLabel.Text = this.GetHashCode().ToString();

            DocumentPictureBox.Controls.Add(FIOLabel);
            DocumentPictureBox.Controls.Add(AgeLabel);
            DocumentPictureBox.Controls.Add(PlaceLabel);
            DocumentPictureBox.Controls.Add(TodayDayLabel);
            DocumentPictureBox.Controls.Add(TodayMonthLabel);
            DocumentPictureBox.Controls.Add(TodayYearLabel);
            DocumentPictureBox.Controls.Add(DocumentNumberLabel);
            DocumentPictureBox.Controls.Add(InfoTextBox);
        }

        // Сохранить в файл
        private void SaveButton_Click(object sender, EventArgs e) // Доделать
        {
            var bm = new Bitmap(DocumentPictureBox.Width, DocumentPictureBox.Height);
            DocumentPictureBox.DrawToBitmap(bm, new Rectangle(0, 0, DocumentPictureBox.Width, DocumentPictureBox.Height));
            bm.Save("Cправка #" + DocumentNumberLabel.Text + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bm.Dispose();
        }
    }
}
