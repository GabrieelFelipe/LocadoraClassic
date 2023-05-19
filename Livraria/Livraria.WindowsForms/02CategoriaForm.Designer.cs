namespace Livraria.WindowsForms
{
    partial class Genero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            this.labelCategoriaId = new System.Windows.Forms.Label();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCategoriaNome = new System.Windows.Forms.Label();
            this.labelCategoriaValordiaria = new System.Windows.Forms.Label();
            this.txtCategoriaNome = new System.Windows.Forms.TextBox();
            this.txtCategoriaValordiaria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoriaCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoriaId
            // 
            this.labelCategoriaId.AutoSize = true;
            this.labelCategoriaId.Location = new System.Drawing.Point(270, 166);
            this.labelCategoriaId.Name = "labelCategoriaId";
            this.labelCategoriaId.Size = new System.Drawing.Size(18, 13);
            this.labelCategoriaId.TabIndex = 40;
            this.labelCategoriaId.Text = "ID";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Location = new System.Drawing.Point(273, 182);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(254, 20);
            this.txtCategoriaId.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GENISO", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 35);
            this.label2.TabIndex = 38;
            this.label2.Text = "Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCategoriaNome
            // 
            this.labelCategoriaNome.AutoSize = true;
            this.labelCategoriaNome.Location = new System.Drawing.Point(270, 205);
            this.labelCategoriaNome.Name = "labelCategoriaNome";
            this.labelCategoriaNome.Size = new System.Drawing.Size(35, 13);
            this.labelCategoriaNome.TabIndex = 35;
            this.labelCategoriaNome.Text = "Nome";
            // 
            // labelCategoriaValordiaria
            // 
            this.labelCategoriaValordiaria.AutoSize = true;
            this.labelCategoriaValordiaria.Location = new System.Drawing.Point(270, 248);
            this.labelCategoriaValordiaria.Name = "labelCategoriaValordiaria";
            this.labelCategoriaValordiaria.Size = new System.Drawing.Size(58, 13);
            this.labelCategoriaValordiaria.TabIndex = 30;
            this.labelCategoriaValordiaria.Text = "ValorDiaria";
            // 
            // txtCategoriaNome
            // 
            this.txtCategoriaNome.Location = new System.Drawing.Point(273, 221);
            this.txtCategoriaNome.Name = "txtCategoriaNome";
            this.txtCategoriaNome.Size = new System.Drawing.Size(254, 20);
            this.txtCategoriaNome.TabIndex = 29;
            // 
            // txtCategoriaValordiaria
            // 
            this.txtCategoriaValordiaria.Location = new System.Drawing.Point(273, 264);
            this.txtCategoriaValordiaria.Name = "txtCategoriaValordiaria";
            this.txtCategoriaValordiaria.Size = new System.Drawing.Size(254, 20);
            this.txtCategoriaValordiaria.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GENISO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 59);
            this.label1.TabIndex = 27;
            this.label1.Text = "Livraria";
            // 
            // btnCategoriaCadastrar
            // 
            this.btnCategoriaCadastrar.Location = new System.Drawing.Point(329, 315);
            this.btnCategoriaCadastrar.Name = "btnCategoriaCadastrar";
            this.btnCategoriaCadastrar.Size = new System.Drawing.Size(139, 29);
            this.btnCategoriaCadastrar.TabIndex = 26;
            this.btnCategoriaCadastrar.Text = "Cadastrar";
            this.btnCategoriaCadastrar.UseVisualStyleBackColor = true;
            // 
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategoriaId);
            this.Controls.Add(this.txtCategoriaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCategoriaNome);
            this.Controls.Add(this.labelCategoriaValordiaria);
            this.Controls.Add(this.txtCategoriaNome);
            this.Controls.Add(this.txtCategoriaValordiaria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategoriaCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Genero";
            this.Text = "Categoria - Livraria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoriaId;
        private System.Windows.Forms.TextBox txtCategoriaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCategoriaNome;
        private System.Windows.Forms.Label labelCategoriaValordiaria;
        private System.Windows.Forms.TextBox txtCategoriaNome;
        private System.Windows.Forms.TextBox txtCategoriaValordiaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoriaCadastrar;
    }
}