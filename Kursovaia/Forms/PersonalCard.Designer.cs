namespace Kursovaia
{
    partial class PersonalCard
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
            this.components = new System.ComponentModel.Container();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FathernameTextBox = new System.Windows.Forms.TextBox();
            this.FathernameLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.AllowEditing = new System.Windows.Forms.CheckBox();
            this.MedicalHistoryView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MedicalHistoryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.GenderMale = new System.Windows.Forms.RadioButton();
            this.GenderFemale = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.StatusCompleted = new System.Windows.Forms.RadioButton();
            this.StatusUncompleted = new System.Windows.Forms.RadioButton();
            this.WarningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalHistoryView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 9);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Фамилия";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.White;
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Location = new System.Drawing.Point(74, 6);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(127, 20);
            this.SurnameTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(74, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(127, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FathernameTextBox
            // 
            this.FathernameTextBox.BackColor = System.Drawing.Color.White;
            this.FathernameTextBox.Enabled = false;
            this.FathernameTextBox.Location = new System.Drawing.Point(74, 58);
            this.FathernameTextBox.Name = "FathernameTextBox";
            this.FathernameTextBox.Size = new System.Drawing.Size(127, 20);
            this.FathernameTextBox.TabIndex = 5;
            // 
            // FathernameLabel
            // 
            this.FathernameLabel.AutoSize = true;
            this.FathernameLabel.Location = new System.Drawing.Point(14, 61);
            this.FathernameLabel.Name = "FathernameLabel";
            this.FathernameLabel.Size = new System.Drawing.Size(54, 13);
            this.FathernameLabel.TabIndex = 4;
            this.FathernameLabel.Text = "Отчество";
            this.FathernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 89);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(27, 13);
            this.GenderLabel.TabIndex = 6;
            this.GenderLabel.Text = "Пол";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(12, 113);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthdayLabel.TabIndex = 8;
            this.BirthdayLabel.Text = "Дата рождения";
            // 
            // AllowEditing
            // 
            this.AllowEditing.AutoSize = true;
            this.AllowEditing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllowEditing.Location = new System.Drawing.Point(12, 136);
            this.AllowEditing.Name = "AllowEditing";
            this.AllowEditing.Size = new System.Drawing.Size(141, 17);
            this.AllowEditing.TabIndex = 10;
            this.AllowEditing.Text = "Разрешить изменение";
            this.AllowEditing.UseVisualStyleBackColor = true;
            this.AllowEditing.CheckStateChanged += new System.EventHandler(this.AllowEditing_CheckStateChanged);
            // 
            // MedicalHistoryView
            // 
            this.MedicalHistoryView.AllowUserToAddRows = false;
            this.MedicalHistoryView.AllowUserToDeleteRows = false;
            this.MedicalHistoryView.AllowUserToResizeColumns = false;
            this.MedicalHistoryView.AllowUserToResizeRows = false;
            this.MedicalHistoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicalHistoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MedicalHistoryView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MedicalHistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalHistoryView.ContextMenuStrip = this.contextMenuStrip1;
            this.MedicalHistoryView.Location = new System.Drawing.Point(207, 32);
            this.MedicalHistoryView.MultiSelect = false;
            this.MedicalHistoryView.Name = "MedicalHistoryView";
            this.MedicalHistoryView.ReadOnly = true;
            this.MedicalHistoryView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicalHistoryView.Size = new System.Drawing.Size(265, 187);
            this.MedicalHistoryView.TabIndex = 11;
            this.MedicalHistoryView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicalHistoryView_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteDataToolStripMenuItem,
            this.PrintTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 48);
            // 
            // DeleteDataToolStripMenuItem
            // 
            this.DeleteDataToolStripMenuItem.Name = "DeleteDataToolStripMenuItem";
            this.DeleteDataToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.DeleteDataToolStripMenuItem.Text = "Удалить запись";
            this.DeleteDataToolStripMenuItem.Click += new System.EventHandler(this.DeleteDataToolStripMenuItem_Click);
            // 
            // PrintTestToolStripMenuItem
            // 
            this.PrintTestToolStripMenuItem.Name = "PrintTestToolStripMenuItem";
            this.PrintTestToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.PrintTestToolStripMenuItem.Text = "Печать результатов анализа";
            this.PrintTestToolStripMenuItem.Click += new System.EventHandler(this.PrintTestToolStripMenuItem_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Location = new System.Drawing.Point(207, 225);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(130, 23);
            this.AddAppointmentButton.TabIndex = 12;
            this.AddAppointmentButton.Text = "Добавить запись";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTextBox.Location = new System.Drawing.Point(12, 254);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(460, 104);
            this.InfoTextBox.TabIndex = 13;
            this.InfoTextBox.Text = "";
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            this.InfoTextBox.Leave += new System.EventHandler(this.InfoTextBox_Leave);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.BirthdayDateTimePicker.Enabled = false;
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(104, 110);
            this.BirthdayDateTimePicker.MinDate = new System.DateTime(1909, 12, 25, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.BirthdayDateTimePicker.TabIndex = 14;
            // 
            // MedicalHistoryDateTimePicker
            // 
            this.MedicalHistoryDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.MedicalHistoryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MedicalHistoryDateTimePicker.Location = new System.Drawing.Point(377, 6);
            this.MedicalHistoryDateTimePicker.Name = "MedicalHistoryDateTimePicker";
            this.MedicalHistoryDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.MedicalHistoryDateTimePicker.TabIndex = 15;
            this.MedicalHistoryDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.MedicalHistoryDateTimePicker.Leave += new System.EventHandler(this.dateTimePicker2_Leave);
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(343, 225);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(130, 23);
            this.AddTestButton.TabIndex = 16;
            this.AddTestButton.Text = "Добавить анализы";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // GenderMale
            // 
            this.GenderMale.AutoSize = true;
            this.GenderMale.Enabled = false;
            this.GenderMale.Location = new System.Drawing.Point(74, 87);
            this.GenderMale.Name = "GenderMale";
            this.GenderMale.Size = new System.Drawing.Size(47, 17);
            this.GenderMale.TabIndex = 17;
            this.GenderMale.TabStop = true;
            this.GenderMale.Text = "Муж";
            this.GenderMale.UseVisualStyleBackColor = true;
            this.GenderMale.CheckedChanged += new System.EventHandler(this.GenderMale_CheckedChanged);
            // 
            // GenderFemale
            // 
            this.GenderFemale.AutoSize = true;
            this.GenderFemale.Enabled = false;
            this.GenderFemale.Location = new System.Drawing.Point(153, 87);
            this.GenderFemale.Name = "GenderFemale";
            this.GenderFemale.Size = new System.Drawing.Size(48, 17);
            this.GenderFemale.TabIndex = 18;
            this.GenderFemale.TabStop = true;
            this.GenderFemale.Text = "Жен";
            this.GenderFemale.UseVisualStyleBackColor = true;
            this.GenderFemale.CheckedChanged += new System.EventHandler(this.GenderFemale_CheckedChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 376);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(90, 13);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "Идентификатор:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(108, 373);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(193, 20);
            this.ResultTextBox.TabIndex = 20;
            this.ResultTextBox.TextChanged += new System.EventHandler(this.ResultTextBox_TextChanged);
            // 
            // StatusCompleted
            // 
            this.StatusCompleted.AutoSize = true;
            this.StatusCompleted.Location = new System.Drawing.Point(108, 374);
            this.StatusCompleted.Name = "StatusCompleted";
            this.StatusCompleted.Size = new System.Drawing.Size(85, 17);
            this.StatusCompleted.TabIndex = 21;
            this.StatusCompleted.TabStop = true;
            this.StatusCompleted.Text = "Состоялось";
            this.StatusCompleted.UseVisualStyleBackColor = true;
            this.StatusCompleted.Visible = false;
            this.StatusCompleted.CheckedChanged += new System.EventHandler(this.StatusCompleted_CheckedChanged);
            // 
            // StatusUncompleted
            // 
            this.StatusUncompleted.AutoSize = true;
            this.StatusUncompleted.Location = new System.Drawing.Point(200, 374);
            this.StatusUncompleted.Name = "StatusUncompleted";
            this.StatusUncompleted.Size = new System.Drawing.Size(101, 17);
            this.StatusUncompleted.TabIndex = 22;
            this.StatusUncompleted.TabStop = true;
            this.StatusUncompleted.Text = "Не состоялось";
            this.StatusUncompleted.UseVisualStyleBackColor = true;
            this.StatusUncompleted.Visible = false;
            this.StatusUncompleted.CheckedChanged += new System.EventHandler(this.StatusUncompleted_CheckedChanged);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Location = new System.Drawing.Point(12, 156);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(171, 26);
            this.WarningLabel.TabIndex = 23;
            this.WarningLabel.Text = "После изменения необходимой \r\nинформации уберите галочку";
            this.WarningLabel.Visible = false;
            // 
            // PersonalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 401);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.StatusUncompleted);
            this.Controls.Add(this.StatusCompleted);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.GenderFemale);
            this.Controls.Add(this.GenderMale);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.MedicalHistoryDateTimePicker);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.MedicalHistoryView);
            this.Controls.Add(this.AllowEditing);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.FathernameTextBox);
            this.Controls.Add(this.FathernameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonalCard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медицинская карточка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonalCard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MedicalHistoryView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox FathernameTextBox;
        private System.Windows.Forms.Label FathernameLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.CheckBox AllowEditing;
        private System.Windows.Forms.DataGridView MedicalHistoryView;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.DateTimePicker MedicalHistoryDateTimePicker;
        private System.Windows.Forms.Button AddTestButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintTestToolStripMenuItem;
        private System.Windows.Forms.RadioButton GenderMale;
        private System.Windows.Forms.RadioButton GenderFemale;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.RadioButton StatusCompleted;
        private System.Windows.Forms.RadioButton StatusUncompleted;
        private System.Windows.Forms.Label WarningLabel;
    }
}