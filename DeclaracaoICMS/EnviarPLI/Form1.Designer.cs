namespace EnviarPLI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnEnviarPLI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(412, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnEnviarPLI
            // 
            this.btnEnviarPLI.Location = new System.Drawing.Point(325, 6);
            this.btnEnviarPLI.Name = "btnEnviarPLI";
            this.btnEnviarPLI.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarPLI.TabIndex = 1;
            this.btnEnviarPLI.Text = "Enviar PLI";
            this.btnEnviarPLI.UseVisualStyleBackColor = true;
            this.btnEnviarPLI.Click += new System.EventHandler(this.btnEnviarPLI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(51, 8);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "08281892000158";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(205, 9);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "2edespachos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 65);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarPLI);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio PLI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnEnviarPLI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
    }
}

