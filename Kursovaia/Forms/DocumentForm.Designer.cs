namespace Kursovaia
{
    partial class DocumentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.DocumentPictureBox = new System.Windows.Forms.PictureBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.PlaceLabel = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.TodayDayLabel = new System.Windows.Forms.Label();
            this.TodayMonthLabel = new System.Windows.Forms.Label();
            this.TodayYearLabel = new System.Windows.Forms.Label();
            this.DocumentNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(489, 416);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 29);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DocumentPictureBox
            // 
            this.DocumentPictureBox.ErrorImage = global::Kursovaia.Properties.Resources.freeform;
            this.DocumentPictureBox.Image = global::Kursovaia.Properties.Resources.freeform;
            this.DocumentPictureBox.InitialImage = global::Kursovaia.Properties.Resources.freeform;
            this.DocumentPictureBox.Location = new System.Drawing.Point(12, 12);
            this.DocumentPictureBox.Name = "DocumentPictureBox";
            this.DocumentPictureBox.Size = new System.Drawing.Size(596, 398);
            this.DocumentPictureBox.TabIndex = 0;
            this.DocumentPictureBox.TabStop = false;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(100, 87);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(131, 13);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "Фамилия Имя Отчество";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(103, 118);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(19, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "19";
            // 
            // PlaceLabel
            // 
            this.PlaceLabel.AutoSize = true;
            this.PlaceLabel.Location = new System.Drawing.Point(286, 118);
            this.PlaceLabel.Name = "PlaceLabel";
            this.PlaceLabel.Size = new System.Drawing.Size(114, 13);
            this.PlaceLabel.TabIndex = 4;
            this.PlaceLabel.Text = "по месту требования";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextBox.Location = new System.Drawing.Point(42, 190);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InfoTextBox.Size = new System.Drawing.Size(525, 115);
            this.InfoTextBox.TabIndex = 5;
            this.InfoTextBox.Text = "";
            // 
            // TodayDayLabel
            // 
            this.TodayDayLabel.AutoSize = true;
            this.TodayDayLabel.Location = new System.Drawing.Point(101, 334);
            this.TodayDayLabel.Name = "TodayDayLabel";
            this.TodayDayLabel.Size = new System.Drawing.Size(19, 13);
            this.TodayDayLabel.TabIndex = 6;
            this.TodayDayLabel.Text = "19";
            // 
            // TodayMonthLabel
            // 
            this.TodayMonthLabel.AutoSize = true;
            this.TodayMonthLabel.Location = new System.Drawing.Point(154, 334);
            this.TodayMonthLabel.Name = "TodayMonthLabel";
            this.TodayMonthLabel.Size = new System.Drawing.Size(52, 13);
            this.TodayMonthLabel.TabIndex = 7;
            this.TodayMonthLabel.Text = "Декабря";
            // 
            // TodayYearLabel
            // 
            this.TodayYearLabel.AutoSize = true;
            this.TodayYearLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TodayYearLabel.Location = new System.Drawing.Point(237, 336);
            this.TodayYearLabel.Name = "TodayYearLabel";
            this.TodayYearLabel.Size = new System.Drawing.Size(31, 13);
            this.TodayYearLabel.TabIndex = 8;
            this.TodayYearLabel.Text = "2023";
            // 
            // DocumentNumberLabel
            // 
            this.DocumentNumberLabel.AutoSize = true;
            this.DocumentNumberLabel.Location = new System.Drawing.Point(351, 27);
            this.DocumentNumberLabel.Name = "DocumentNumberLabel";
            this.DocumentNumberLabel.Size = new System.Drawing.Size(61, 13);
            this.DocumentNumberLabel.TabIndex = 10;
            this.DocumentNumberLabel.Text = "123412152";
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 455);
            this.Controls.Add(this.DocumentNumberLabel);
            this.Controls.Add(this.TodayYearLabel);
            this.Controls.Add(this.TodayMonthLabel);
            this.Controls.Add(this.TodayDayLabel);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.PlaceLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DocumentPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DocumentPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label PlaceLabel;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Label TodayDayLabel;
        private System.Windows.Forms.Label TodayMonthLabel;
        private System.Windows.Forms.Label TodayYearLabel;
        private System.Windows.Forms.Label DocumentNumberLabel;
    }
}