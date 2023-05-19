namespace Livraria.WindowsForms
{
    partial class Catgoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catgoria));
            this.comboBoxGeneroNome = new System.Windows.Forms.ComboBox();
            this.labelGeneroNome = new System.Windows.Forms.Label();
            this.labelGeneroId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneroBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxGeneroNome
            // 
            this.comboBoxGeneroNome.FormattingEnabled = true;
            this.comboBoxGeneroNome.Location = new System.Drawing.Point(269, 245);
            this.comboBoxGeneroNome.Name = "comboBoxGeneroNome";
            this.comboBoxGeneroNome.Size = new System.Drawing.Size(254, 21);
            this.comboBoxGeneroNome.TabIndex = 0;
            // 
            // labelGeneroNome
            // 
            this.labelGeneroNome.AutoSize = true;
            this.labelGeneroNome.Location = new System.Drawing.Point(269, 226);
            this.labelGeneroNome.Name = "labelGeneroNome";
            this.labelGeneroNome.Size = new System.Drawing.Size(35, 13);
            this.labelGeneroNome.TabIndex = 1;
            this.labelGeneroNome.Text = "Nome";
            // 
            // labelGeneroId
            // 
            this.labelGeneroId.AutoSize = true;
            this.labelGeneroId.Location = new System.Drawing.Point(266, 178);
            this.labelGeneroId.Name = "labelGeneroId";
            this.labelGeneroId.Size = new System.Drawing.Size(18, 13);
            this.labelGeneroId.TabIndex = 27;
            this.labelGeneroId.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GENISO", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 35);
            this.label2.TabIndex = 29;
            this.label2.Text = "Seleção de Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GENISO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 59);
            this.label3.TabIndex = 28;
            this.label3.Text = "Livraria";
            // 
            // btnGeneroBuscar
            // 
            this.btnGeneroBuscar.Location = new System.Drawing.Point(326, 301);
            this.btnGeneroBuscar.Name = "btnGeneroBuscar";
            this.btnGeneroBuscar.Size = new System.Drawing.Size(139, 29);
            this.btnGeneroBuscar.TabIndex = 30;
            this.btnGeneroBuscar.Text = "Buscar";
            this.btnGeneroBuscar.UseVisualStyleBackColor = true;
            // 
            // Catgoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneroBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelGeneroId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGeneroNome);
            this.Controls.Add(this.comboBoxGeneroNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catgoria";
            this.Text = "Genero - Livraria";
            this.Load += new System.EventHandler(this.Catgoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGeneroNome;
        private System.Windows.Forms.Label labelGeneroNome;
        private System.Windows.Forms.Label labelGeneroId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneroBuscar;
    }
}