namespace Evaluation_Manager
{
    partial class FrmStudents
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiNeocijenjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiStudenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktivnostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiSveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upišiNoviZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviNastavnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEvaluateStudent = new System.Windows.Forms.Button();
            this.btnStudentEvaluations = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 45);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1043, 497);
            this.dgvStudents.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.aktivnostToolStripMenuItem,
            this.upišiNoviZapisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiSveToolStripMenuItem,
            this.prikažiNeocijenjeneToolStripMenuItem,
            this.pretražiStudenteToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.studentiToolStripMenuItem.Text = "Studenti";
            // 
            // prikažiSveToolStripMenuItem
            // 
            this.prikažiSveToolStripMenuItem.Name = "prikažiSveToolStripMenuItem";
            this.prikažiSveToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.prikažiSveToolStripMenuItem.Text = "Prikaži sve";
            this.prikažiSveToolStripMenuItem.Click += new System.EventHandler(this.prikažiSveToolStripMenuItem_Click);
            // 
            // prikažiNeocijenjeneToolStripMenuItem
            // 
            this.prikažiNeocijenjeneToolStripMenuItem.Name = "prikažiNeocijenjeneToolStripMenuItem";
            this.prikažiNeocijenjeneToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.prikažiNeocijenjeneToolStripMenuItem.Text = "Prikaži neocijenjene";
            this.prikažiNeocijenjeneToolStripMenuItem.Click += new System.EventHandler(this.prikažiNeocijenjeneToolStripMenuItem_Click);
            // 
            // pretražiStudenteToolStripMenuItem
            // 
            this.pretražiStudenteToolStripMenuItem.Name = "pretražiStudenteToolStripMenuItem";
            this.pretražiStudenteToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.pretražiStudenteToolStripMenuItem.Text = "Pretraži studente";
            this.pretražiStudenteToolStripMenuItem.Click += new System.EventHandler(this.pretražiStudenteToolStripMenuItem_Click);
            // 
            // aktivnostToolStripMenuItem
            // 
            this.aktivnostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiSveToolStripMenuItem1});
            this.aktivnostToolStripMenuItem.Name = "aktivnostToolStripMenuItem";
            this.aktivnostToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aktivnostToolStripMenuItem.Text = "Aktivnost";
            // 
            // prikažiSveToolStripMenuItem1
            // 
            this.prikažiSveToolStripMenuItem1.Name = "prikažiSveToolStripMenuItem1";
            this.prikažiSveToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.prikažiSveToolStripMenuItem1.Text = "Prikaži sve";
            this.prikažiSveToolStripMenuItem1.Click += new System.EventHandler(this.prikažiSveToolStripMenuItem1_Click);
            // 
            // upišiNoviZapisToolStripMenuItem
            // 
            this.upišiNoviZapisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviNastavnikToolStripMenuItem,
            this.noviStudentToolStripMenuItem});
            this.upišiNoviZapisToolStripMenuItem.Name = "upišiNoviZapisToolStripMenuItem";
            this.upišiNoviZapisToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.upišiNoviZapisToolStripMenuItem.Text = "Upiši novi zapis";
            // 
            // noviNastavnikToolStripMenuItem
            // 
            this.noviNastavnikToolStripMenuItem.Name = "noviNastavnikToolStripMenuItem";
            this.noviNastavnikToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.noviNastavnikToolStripMenuItem.Text = "Novi nastavnik";
            this.noviNastavnikToolStripMenuItem.Click += new System.EventHandler(this.noviNastavnikToolStripMenuItem_Click);
            // 
            // noviStudentToolStripMenuItem
            // 
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.noviStudentToolStripMenuItem.Text = "Novi student";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // btnEvaluateStudent
            // 
            this.btnEvaluateStudent.Location = new System.Drawing.Point(870, 548);
            this.btnEvaluateStudent.Name = "btnEvaluateStudent";
            this.btnEvaluateStudent.Size = new System.Drawing.Size(185, 41);
            this.btnEvaluateStudent.TabIndex = 2;
            this.btnEvaluateStudent.Text = "Evaluiraj studenta";
            this.btnEvaluateStudent.UseVisualStyleBackColor = true;
            this.btnEvaluateStudent.Click += new System.EventHandler(this.btnEvaluateStudent_Click);
            // 
            // btnStudentEvaluations
            // 
            this.btnStudentEvaluations.Location = new System.Drawing.Point(679, 548);
            this.btnStudentEvaluations.Name = "btnStudentEvaluations";
            this.btnStudentEvaluations.Size = new System.Drawing.Size(185, 41);
            this.btnStudentEvaluations.TabIndex = 3;
            this.btnStudentEvaluations.Text = "Pregled evaluacija";
            this.btnStudentEvaluations.UseVisualStyleBackColor = true;
            this.btnStudentEvaluations.Click += new System.EventHandler(this.btnStudentEvaluations_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 548);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(185, 41);
            this.btnGenerateReport.TabIndex = 4;
            this.btnGenerateReport.Text = "Generiraj izvještaj";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 595);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnStudentEvaluations);
            this.Controls.Add(this.btnEvaluateStudent);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            this.Load += new System.EventHandler(this.FrmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiSveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiNeocijenjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiStudenteToolStripMenuItem;
        private System.Windows.Forms.Button btnEvaluateStudent;
        private System.Windows.Forms.ToolStripMenuItem aktivnostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiSveToolStripMenuItem1;
        private System.Windows.Forms.Button btnStudentEvaluations;
        private System.Windows.Forms.ToolStripMenuItem upišiNoviZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviNastavnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviStudentToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}