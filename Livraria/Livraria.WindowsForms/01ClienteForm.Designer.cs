namespace Livraria.WindowsForms
{
    partial class Visual01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visual01));
            this.txtClienteCpf = new System.Windows.Forms.TextBox();
            this.labelClienteTelefone = new System.Windows.Forms.Label();
            this.txtClienteTelefone = new System.Windows.Forms.TextBox();
            this.txtClienteRg = new System.Windows.Forms.TextBox();
            this.labelClienteEndereco = new System.Windows.Forms.Label();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.txtClienteEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteCadastrar = new System.Windows.Forms.Button();
            this.labelClienteNome = new System.Windows.Forms.Label();
            this.labelClienteRg = new System.Windows.Forms.Label();
            this.labelClienteCpf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCategoriaId = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClienteCpf
            // 
            this.txtClienteCpf.Location = new System.Drawing.Point(274, 341);
            this.txtClienteCpf.Name = "txtClienteCpf";
            this.txtClienteCpf.Size = new System.Drawing.Size(254, 20);
            this.txtClienteCpf.TabIndex = 19;
            // 
            // labelClienteTelefone
            // 
            this.labelClienteTelefone.AutoSize = true;
            this.labelClienteTelefone.Location = new System.Drawing.Point(271, 241);
            this.labelClienteTelefone.Name = "labelClienteTelefone";
            this.labelClienteTelefone.Size = new System.Drawing.Size(49, 13);
            this.labelClienteTelefone.TabIndex = 18;
            this.labelClienteTelefone.Text = "Telefone";
            // 
            // txtClienteTelefone
            // 
            this.txtClienteTelefone.Location = new System.Drawing.Point(274, 257);
            this.txtClienteTelefone.Name = "txtClienteTelefone";
            this.txtClienteTelefone.Size = new System.Drawing.Size(254, 20);
            this.txtClienteTelefone.TabIndex = 17;
            // 
            // txtClienteRg
            // 
            this.txtClienteRg.Location = new System.Drawing.Point(274, 300);
            this.txtClienteRg.Name = "txtClienteRg";
            this.txtClienteRg.Size = new System.Drawing.Size(254, 20);
            this.txtClienteRg.TabIndex = 16;
            // 
            // labelClienteEndereco
            // 
            this.labelClienteEndereco.AutoSize = true;
            this.labelClienteEndereco.Location = new System.Drawing.Point(271, 198);
            this.labelClienteEndereco.Name = "labelClienteEndereco";
            this.labelClienteEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelClienteEndereco.TabIndex = 15;
            this.labelClienteEndereco.Text = "Endereço";
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(274, 171);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(254, 20);
            this.txtClienteNome.TabIndex = 14;
            // 
            // txtClienteEndereco
            // 
            this.txtClienteEndereco.Location = new System.Drawing.Point(274, 214);
            this.txtClienteEndereco.Name = "txtClienteEndereco";
            this.txtClienteEndereco.Size = new System.Drawing.Size(254, 20);
            this.txtClienteEndereco.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GENISO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "Livraria";
            // 
            // btnClienteCadastrar
            // 
            this.btnClienteCadastrar.Location = new System.Drawing.Point(330, 385);
            this.btnClienteCadastrar.Name = "btnClienteCadastrar";
            this.btnClienteCadastrar.Size = new System.Drawing.Size(139, 29);
            this.btnClienteCadastrar.TabIndex = 11;
            this.btnClienteCadastrar.Text = "Cadastrar";
            this.btnClienteCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelClienteNome
            // 
            this.labelClienteNome.AutoSize = true;
            this.labelClienteNome.Location = new System.Drawing.Point(271, 155);
            this.labelClienteNome.Name = "labelClienteNome";
            this.labelClienteNome.Size = new System.Drawing.Size(35, 13);
            this.labelClienteNome.TabIndex = 20;
            this.labelClienteNome.Text = "Nome";
            // 
            // labelClienteRg
            // 
            this.labelClienteRg.AutoSize = true;
            this.labelClienteRg.Location = new System.Drawing.Point(271, 284);
            this.labelClienteRg.Name = "labelClienteRg";
            this.labelClienteRg.Size = new System.Drawing.Size(23, 13);
            this.labelClienteRg.TabIndex = 21;
            this.labelClienteRg.Text = "RG";
            // 
            // labelClienteCpf
            // 
            this.labelClienteCpf.AutoSize = true;
            this.labelClienteCpf.Location = new System.Drawing.Point(271, 325);
            this.labelClienteCpf.Name = "labelClienteCpf";
            this.labelClienteCpf.Size = new System.Drawing.Size(27, 13);
            this.labelClienteCpf.TabIndex = 22;
            this.labelClienteCpf.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GENISO", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cadastro Cliente";
            // 
            // labelCategoriaId
            // 
            this.labelCategoriaId.AutoSize = true;
            this.labelCategoriaId.Location = new System.Drawing.Point(271, 116);
            this.labelCategoriaId.Name = "labelCategoriaId";
            this.labelCategoriaId.Size = new System.Drawing.Size(18, 13);
            this.labelCategoriaId.TabIndex = 25;
            this.labelCategoriaId.Text = "ID";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(274, 132);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(254, 20);
            this.txtClienteId.TabIndex = 24;
            // 
            // Visual01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategoriaId);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClienteCpf);
            this.Controls.Add(this.labelClienteRg);
            this.Controls.Add(this.labelClienteNome);
            this.Controls.Add(this.txtClienteCpf);
            this.Controls.Add(this.labelClienteTelefone);
            this.Controls.Add(this.txtClienteTelefone);
            this.Controls.Add(this.txtClienteRg);
            this.Controls.Add(this.labelClienteEndereco);
            this.Controls.Add(this.txtClienteNome);
            this.Controls.Add(this.txtClienteEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClienteCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visual01";
            this.Text = "Cliente - Livraria";
            this.Load += new System.EventHandler(this.Visual01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteCpf;
        private System.Windows.Forms.Label labelClienteTelefone;
        private System.Windows.Forms.TextBox txtClienteTelefone;
        private System.Windows.Forms.TextBox txtClienteRg;
        private System.Windows.Forms.Label labelClienteEndereco;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.TextBox txtClienteEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClienteCadastrar;
        private System.Windows.Forms.Label labelClienteNome;
        private System.Windows.Forms.Label labelClienteRg;
        private System.Windows.Forms.Label labelClienteCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCategoriaId;
        private System.Windows.Forms.TextBox txtClienteId;
    }
}

