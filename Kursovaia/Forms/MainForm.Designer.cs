namespace Kursovaia
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseTab = new System.Windows.Forms.TabControl();
            this.patientsTab = new System.Windows.Forms.TabPage();
            this.PatientsView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMedicalDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            this.patientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.DataBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.Controls.Add(this.patientsTab);
            this.DatabaseTab.Location = new System.Drawing.Point(13, 27);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.SelectedIndex = 0;
            this.DatabaseTab.Size = new System.Drawing.Size(776, 411);
            this.DatabaseTab.TabIndex = 1;
            // 
            // patientsTab
            // 
            this.patientsTab.Controls.Add(this.PatientsView);
            this.patientsTab.Location = new System.Drawing.Point(4, 22);
            this.patientsTab.Name = "patientsTab";
            this.patientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTab.Size = new System.Drawing.Size(768, 385);
            this.patientsTab.TabIndex = 1;
            this.patientsTab.Text = "Пациенты";
            this.patientsTab.UseVisualStyleBackColor = true;
            // 
            // PatientsView
            // 
            this.PatientsView.AllowUserToAddRows = false;
            this.PatientsView.AllowUserToDeleteRows = false;
            this.PatientsView.AllowUserToResizeColumns = false;
            this.PatientsView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientsView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PatientsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsView.ContextMenuStrip = this.contextMenuStrip1;
            this.PatientsView.Location = new System.Drawing.Point(0, 0);
            this.PatientsView.Name = "PatientsView";
            this.PatientsView.ReadOnly = true;
            this.PatientsView.Size = new System.Drawing.Size(768, 385);
            this.PatientsView.TabIndex = 1;
            this.PatientsView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientsView_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPatientToolStripMenuItem,
            this.CreateMedicalDocumentToolStripMenuItem,
            this.DeletePatientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // AddPatientToolStripMenuItem
            // 
            this.AddPatientToolStripMenuItem.Name = "AddPatientToolStripMenuItem";
            this.AddPatientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddPatientToolStripMenuItem.Text = "Добавить пациента";
            this.AddPatientToolStripMenuItem.Click += new System.EventHandler(this.AddPatientToolStripMenuItem_Click);
            // 
            // CreateMedicalDocumentToolStripMenuItem
            // 
            this.CreateMedicalDocumentToolStripMenuItem.Name = "CreateMedicalDocumentToolStripMenuItem";
            this.CreateMedicalDocumentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateMedicalDocumentToolStripMenuItem.Text = "Создать справку";
            this.CreateMedicalDocumentToolStripMenuItem.Click += new System.EventHandler(this.CreateMedicalDocumentToolStripMenuItem_Click);
            // 
            // DeletePatientToolStripMenuItem
            // 
            this.DeletePatientToolStripMenuItem.Name = "DeletePatientToolStripMenuItem";
            this.DeletePatientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeletePatientToolStripMenuItem.Text = "Удалить пациента";
            this.DeletePatientToolStripMenuItem.Click += new System.EventHandler(this.DeletePatientToolStripMenuItem_Click);
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewDBToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.DataBaseToolStripMenuItem.Text = "База данных";
            // 
            // CreateNewDBToolStripMenuItem
            // 
            this.CreateNewDBToolStripMenuItem.Name = "CreateNewDBToolStripMenuItem";
            this.CreateNewDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateNewDBToolStripMenuItem.Text = "Создать новую";
            this.CreateNewDBToolStripMenuItem.Click += new System.EventHandler(this.CreateNewDBToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatabaseTab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АРМ врача поликлиники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveOnClose);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DatabaseTab.ResumeLayout(false);
            this.patientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.TabControl DatabaseTab;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.DataGridView PatientsView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateMedicalDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewDBToolStripMenuItem;
    }
}

