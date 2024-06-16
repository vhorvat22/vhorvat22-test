namespace Evaluation_Manager
{
    partial class FrmSearch
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkSurname = new System.Windows.Forms.CheckBox();
            this.chkGrade = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Pretraga po:";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.txtGrade);
            this.gpbSearch.Controls.Add(this.txtSurname);
            this.gpbSearch.Controls.Add(this.txtName);
            this.gpbSearch.Controls.Add(this.chkGrade);
            this.gpbSearch.Controls.Add(this.chkSurname);
            this.gpbSearch.Controls.Add(this.chkName);
            this.gpbSearch.Location = new System.Drawing.Point(12, 28);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(268, 112);
            this.gpbSearch.TabIndex = 1;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "kriteriju";
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(7, 22);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(51, 20);
            this.chkName.TabIndex = 0;
            this.chkName.Text = "Ime";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // chkSurname
            // 
            this.chkSurname.AutoSize = true;
            this.chkSurname.Location = new System.Drawing.Point(7, 50);
            this.chkSurname.Name = "chkSurname";
            this.chkSurname.Size = new System.Drawing.Size(78, 20);
            this.chkSurname.TabIndex = 1;
            this.chkSurname.Text = "Prezime";
            this.chkSurname.UseVisualStyleBackColor = true;
            // 
            // chkGrade
            // 
            this.chkGrade.AutoSize = true;
            this.chkGrade.Location = new System.Drawing.Point(6, 78);
            this.chkGrade.Name = "chkGrade";
            this.chkGrade.Size = new System.Drawing.Size(72, 20);
            this.chkGrade.TabIndex = 2;
            this.chkGrade.Text = "Ocjena";
            this.chkGrade.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(108, 48);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(140, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(108, 76);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(140, 22);
            this.txtGrade.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 182);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gpbSearch);
            this.Controls.Add(this.lblSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži studente";
            this.TopMost = true;
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtGrade;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.CheckBox chkGrade;
        public System.Windows.Forms.CheckBox chkSurname;
        public System.Windows.Forms.CheckBox chkName;
    }
}