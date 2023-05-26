namespace LocadoraClassic.View
{
    partial class FrmTelaCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.maskedTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(104, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(102, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(105, 42);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(576, 20);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(105, 89);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(576, 20);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(105, 233);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(576, 20);
            this.txtRg.TabIndex = 7;
            this.txtRg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // maskedTxtTelefone
            // 
            this.maskedTxtTelefone.Location = new System.Drawing.Point(105, 137);
            this.maskedTxtTelefone.Mask = "(00) 0 0000-0000 ";
            this.maskedTxtTelefone.Name = "maskedTxtTelefone";
            this.maskedTxtTelefone.Size = new System.Drawing.Size(576, 20);
            this.maskedTxtTelefone.TabIndex = 8;
            this.maskedTxtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTxtCpf
            // 
            this.maskedTxtCpf.Location = new System.Drawing.Point(105, 185);
            this.maskedTxtCpf.Mask = "000.000.000-00";
            this.maskedTxtCpf.Name = "maskedTxtCpf";
            this.maskedTxtCpf.Size = new System.Drawing.Size(576, 20);
            this.maskedTxtCpf.TabIndex = 9;
            this.maskedTxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(105, 331);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(576, 150);
            this.dgvClientes.TabIndex = 11;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmTelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTxtCpf);
            this.Controls.Add(this.maskedTxtTelefone);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTelaCliente";
            this.Text = "FrmTelaCliente";
            this.Load += new System.EventHandler(this.FrmTelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTxtCpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}