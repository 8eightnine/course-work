using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaia.Forms
{
    public partial class TestForm : Form
    {
        public TestForm(Test test, Patient patient)
        {
            InitializeComponent();
            // Присваеваем элементам управления информацию о пациенте и анализе
            FIOLabel.Text = patient.PersonalInfo.Surname + " " + patient.PersonalInfo.Name + " " + patient.PersonalInfo.Fathername;
            var age = DateTime.Today.Year - patient.PersonalInfo.Birthday.Year;
            if (patient.PersonalInfo.Birthday.Date > DateTime.Today.AddYears(-age)) age--;
            GenderLabel.Text = patient.PersonalInfo.Gender;
            AgeLabel.Text = age.ToString();
            TestDateLabel.Text = test.Date.ToString("dd.MM.yyyy");
            PrintDateLabel.Text = DateTime.Today.ToString("dd.MM.yyyy");
            TestNameLabel.Text = test.Info;
            TestInfoTextBox.Text = test.Results;

            TestPictureBox.Controls.Add(FIOLabel);
            TestPictureBox.Controls.Add(GenderLabel);
            TestPictureBox.Controls.Add(AgeLabel);
            TestPictureBox.Controls.Add(TestDateLabel);
            TestPictureBox.Controls.Add(PrintDateLabel);
            TestPictureBox.Controls.Add(TestNameLabel);
            TestPictureBox.Controls.Add(TestInfoTextBox);
        }

        // Сохранить в файл
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(TestPictureBox.Width, TestPictureBox.Height);
            TestPictureBox.DrawToBitmap(bm, new Rectangle(0, 0, TestPictureBox.Width, TestPictureBox.Height));
            bm.Save($"{FIOLabel.Text.Trim()} - Анализ за {TestDateLabel.Text}.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bm.Dispose();
        }
    }
}
