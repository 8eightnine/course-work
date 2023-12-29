namespace Kursovaia.Forms
{
    partial class TestForm
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
            this.TestPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.TestDateLabel = new System.Windows.Forms.Label();
            this.PrintDateLabel = new System.Windows.Forms.Label();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestInfoTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TestPictureBox
            // 
            this.TestPictureBox.Image = global::Kursovaia.Properties.Resources.analiz;
            this.TestPictureBox.InitialImage = global::Kursovaia.Properties.Resources.analiz;
            this.TestPictureBox.Location = new System.Drawing.Point(12, 12);
            this.TestPictureBox.Name = "TestPictureBox";
            this.TestPictureBox.Size = new System.Drawing.Size(313, 440);
            this.TestPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TestPictureBox.TabIndex = 0;
            this.TestPictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(225, 459);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 40);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.BackColor = System.Drawing.Color.Transparent;
            this.FIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(43, 18);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(247, 25);
            this.FIOLabel.TabIndex = 2;
            this.FIOLabel.Text = "Фамилия Имя Отчество";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.GenderLabel.Location = new System.Drawing.Point(52, 58);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(32, 13);
            this.GenderLabel.TabIndex = 3;
            this.GenderLabel.Text = "М/Ж";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeLabel.Location = new System.Drawing.Point(86, 79);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(19, 13);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "31";
            // 
            // TestDateLabel
            // 
            this.TestDateLabel.AutoSize = true;
            this.TestDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestDateLabel.Location = new System.Drawing.Point(176, 99);
            this.TestDateLabel.Name = "TestDateLabel";
            this.TestDateLabel.Size = new System.Drawing.Size(61, 13);
            this.TestDateLabel.TabIndex = 5;
            this.TestDateLabel.Text = "31.01.2022";
            // 
            // PrintDateLabel
            // 
            this.PrintDateLabel.AutoSize = true;
            this.PrintDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrintDateLabel.Location = new System.Drawing.Point(197, 118);
            this.PrintDateLabel.Name = "PrintDateLabel";
            this.PrintDateLabel.Size = new System.Drawing.Size(61, 13);
            this.PrintDateLabel.TabIndex = 6;
            this.PrintDateLabel.Text = "31.01.2022";
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TestNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestNameLabel.Location = new System.Drawing.Point(30, 206);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(107, 163);
            this.TestNameLabel.TabIndex = 7;
            this.TestNameLabel.Text = "Blood Test";
            // 
            // TestInfoTextBox
            // 
            this.TestInfoTextBox.BackColor = System.Drawing.Color.White;
            this.TestInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestInfoTextBox.Location = new System.Drawing.Point(143, 190);
            this.TestInfoTextBox.Name = "TestInfoTextBox";
            this.TestInfoTextBox.ReadOnly = true;
            this.TestInfoTextBox.Size = new System.Drawing.Size(159, 235);
            this.TestInfoTextBox.TabIndex = 8;
            this.TestInfoTextBox.Text = "Все успешно";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 511);
            this.Controls.Add(this.TestInfoTextBox);
            this.Controls.Add(this.TestNameLabel);
            this.Controls.Add(this.PrintDateLabel);
            this.Controls.Add(this.TestDateLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TestPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.Text = "Печать результатов анализа";
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TestPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label TestDateLabel;
        private System.Windows.Forms.Label PrintDateLabel;
        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.RichTextBox TestInfoTextBox;
    }
}