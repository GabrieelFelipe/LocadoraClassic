namespace LogBook.View
{
    partial class FrmAddStudent
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
            this.AR = new System.Windows.Forms.Label();
            this.ClassCode = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.MiniCurriculum = new System.Windows.Forms.Label();
            this.Hobby = new System.Windows.Forms.Label();
            this.txtAR = new System.Windows.Forms.TextBox();
            this.txtClassCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtMiniCurriculum = new System.Windows.Forms.TextBox();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AR
            // 
            this.AR.AutoSize = true;
            this.AR.Location = new System.Drawing.Point(9, 11);
            this.AR.Name = "AR";
            this.AR.Size = new System.Drawing.Size(22, 13);
            this.AR.TabIndex = 0;
            this.AR.Text = "RA";
            // 
            // ClassCode
            // 
            this.ClassCode.AutoSize = true;
            this.ClassCode.Location = new System.Drawing.Point(9, 57);
            this.ClassCode.Name = "ClassCode";
            this.ClassCode.Size = new System.Drawing.Size(88, 13);
            this.ClassCode.TabIndex = 1;
            this.ClassCode.Text = "Código da Turma";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(9, 105);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(35, 13);
            this.StudentName.TabIndex = 2;
            this.StudentName.Text = "Nome";
            this.StudentName.Click += new System.EventHandler(this.label3_Click);
            // 
            // MiniCurriculum
            // 
            this.MiniCurriculum.AutoSize = true;
            this.MiniCurriculum.Location = new System.Drawing.Point(9, 154);
            this.MiniCurriculum.Name = "MiniCurriculum";
            this.MiniCurriculum.Size = new System.Drawing.Size(69, 13);
            this.MiniCurriculum.TabIndex = 3;
            this.MiniCurriculum.Text = "MiniCurrículo";
            this.MiniCurriculum.Click += new System.EventHandler(this.label4_Click);
            // 
            // Hobby
            // 
            this.Hobby.AutoSize = true;
            this.Hobby.Location = new System.Drawing.Point(9, 289);
            this.Hobby.Name = "Hobby";
            this.Hobby.Size = new System.Drawing.Size(38, 13);
            this.Hobby.TabIndex = 4;
            this.Hobby.Text = "Hobby";
            this.Hobby.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAR
            // 
            this.txtAR.Location = new System.Drawing.Point(12, 27);
            this.txtAR.Name = "txtAR";
            this.txtAR.Size = new System.Drawing.Size(388, 20);
            this.txtAR.TabIndex = 5;
            this.txtAR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtClassCode
            // 
            this.txtClassCode.Location = new System.Drawing.Point(12, 73);
            this.txtClassCode.Name = "txtClassCode";
            this.txtClassCode.Size = new System.Drawing.Size(388, 20);
            this.txtClassCode.TabIndex = 6;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(12, 121);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(388, 20);
            this.txtStudentName.TabIndex = 7;
            // 
            // txtMiniCurriculum
            // 
            this.txtMiniCurriculum.Location = new System.Drawing.Point(12, 170);
            this.txtMiniCurriculum.Multiline = true;
            this.txtMiniCurriculum.Name = "txtMiniCurriculum";
            this.txtMiniCurriculum.Size = new System.Drawing.Size(388, 106);
            this.txtMiniCurriculum.TabIndex = 8;
            // 
            // txtHobby
            // 
            this.txtHobby.Location = new System.Drawing.Point(12, 305);
            this.txtHobby.Multiline = true;
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(388, 90);
            this.txtHobby.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 418);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(388, 29);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 463);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtHobby);
            this.Controls.Add(this.txtMiniCurriculum);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtClassCode);
            this.Controls.Add(this.txtAR);
            this.Controls.Add(this.Hobby);
            this.Controls.Add(this.MiniCurriculum);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.ClassCode);
            this.Controls.Add(this.AR);
            this.Name = "FrmAddStudent";
            this.Text = "Cadastrar Estudantes";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AR;
        private System.Windows.Forms.Label ClassCode;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label MiniCurriculum;
        private System.Windows.Forms.Label Hobby;
        private System.Windows.Forms.TextBox txtAR;
        private System.Windows.Forms.TextBox txtClassCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtMiniCurriculum;
        private System.Windows.Forms.TextBox txtHobby;
        private System.Windows.Forms.Button btnCadastrar;
    }
}