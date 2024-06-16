namespace Evaluation_Manager
{
    partial class FrmStudentEvaluations
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
            this.dgvStudentEvaluations = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentEvaluations
            // 
            this.dgvStudentEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentEvaluations.Location = new System.Drawing.Point(12, 12);
            this.dgvStudentEvaluations.Name = "dgvStudentEvaluations";
            this.dgvStudentEvaluations.RowHeadersWidth = 51;
            this.dgvStudentEvaluations.RowTemplate.Height = 24;
            this.dgvStudentEvaluations.Size = new System.Drawing.Size(776, 363);
            this.dgvStudentEvaluations.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmStudentEvaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvStudentEvaluations);
            this.Name = "FrmStudentEvaluations";
            this.Text = "FrmStudentEvaluations";
            this.Load += new System.EventHandler(this.FrmStudentEvaluations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentEvaluations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentEvaluations;
        private System.Windows.Forms.Button btnClose;
    }
}