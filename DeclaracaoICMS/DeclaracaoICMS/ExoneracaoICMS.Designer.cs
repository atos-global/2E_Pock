namespace DeclaracaoICMS
{
    partial class ExoneracaoICMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtDI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTomarCiencia = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UF";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(33, 15);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(53, 20);
            this.txtUF.TabIndex = 1;
            this.txtUF.Text = "AM";
            // 
            // txtDI
            // 
            this.txtDI.Location = new System.Drawing.Point(116, 15);
            this.txtDI.Name = "txtDI";
            this.txtDI.Size = new System.Drawing.Size(82, 20);
            this.txtDI.TabIndex = 3;
            this.txtDI.Text = "19/0288362-6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DI";
            // 
            // btnTomarCiencia
            // 
            this.btnTomarCiencia.Location = new System.Drawing.Point(213, 15);
            this.btnTomarCiencia.Name = "btnTomarCiencia";
            this.btnTomarCiencia.Size = new System.Drawing.Size(103, 23);
            this.btnTomarCiencia.TabIndex = 4;
            this.btnTomarCiencia.Text = "Tomar Ciencia";
            this.btnTomarCiencia.UseVisualStyleBackColor = true;
            this.btnTomarCiencia.Click += new System.EventHandler(this.btnTomarCiencia_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // ExoneracaoICMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 72);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTomarCiencia);
            this.Controls.Add(this.txtDI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label1);
            this.Name = "ExoneracaoICMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExoneracaoICMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtDI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTomarCiencia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}