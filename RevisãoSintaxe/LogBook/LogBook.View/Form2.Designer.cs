namespace LogBook.View
{
    partial class LoginView
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
            this.BtnAutenticar = new System.Windows.Forms.Button();
            this.txtNumTurma = new System.Windows.Forms.TextBox();
            this.NumTurma = new System.Windows.Forms.Label();
            this.txtLoginAR = new System.Windows.Forms.TextBox();
            this.LoginAR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAutenticar
            // 
            this.BtnAutenticar.Location = new System.Drawing.Point(33, 116);
            this.BtnAutenticar.Name = "BtnAutenticar";
            this.BtnAutenticar.Size = new System.Drawing.Size(184, 36);
            this.BtnAutenticar.TabIndex = 17;
            this.BtnAutenticar.Text = "Entrar";
            this.BtnAutenticar.UseVisualStyleBackColor = true;
            // 
            // txtNumTurma
            // 
            this.txtNumTurma.Location = new System.Drawing.Point(34, 85);
            this.txtNumTurma.Name = "txtNumTurma";
            this.txtNumTurma.Size = new System.Drawing.Size(183, 20);
            this.txtNumTurma.TabIndex = 16;
            // 
            // NumTurma
            // 
            this.NumTurma.AutoSize = true;
            this.NumTurma.Location = new System.Drawing.Point(31, 69);
            this.NumTurma.Name = "NumTurma";
            this.NumTurma.Size = new System.Drawing.Size(125, 13);
            this.NumTurma.TabIndex = 15;
            this.NumTurma.Text = "Nº da Turma (sem ponto)";
            // 
            // txtLoginAR
            // 
            this.txtLoginAR.Location = new System.Drawing.Point(34, 39);
            this.txtLoginAR.Name = "txtLoginAR";
            this.txtLoginAR.Size = new System.Drawing.Size(183, 20);
            this.txtLoginAR.TabIndex = 14;
            // 
            // LoginAR
            // 
            this.LoginAR.AutoSize = true;
            this.LoginAR.Location = new System.Drawing.Point(31, 23);
            this.LoginAR.Name = "LoginAR";
            this.LoginAR.Size = new System.Drawing.Size(22, 13);
            this.LoginAR.TabIndex = 13;
            this.LoginAR.Text = "RA";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 184);
            this.Controls.Add(this.BtnAutenticar);
            this.Controls.Add(this.txtNumTurma);
            this.Controls.Add(this.NumTurma);
            this.Controls.Add(this.txtLoginAR);
            this.Controls.Add(this.LoginAR);
            this.Name = "LoginView";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAutenticar;
        private System.Windows.Forms.TextBox txtNumTurma;
        private System.Windows.Forms.Label NumTurma;
        private System.Windows.Forms.TextBox txtLoginAR;
        private System.Windows.Forms.Label LoginAR;
    }
}