namespace LocadoraClassic.View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeBarraDeAtradosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xilften = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xilften)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripe,
            this.categoriasToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // generoToolStripe
            // 
            this.generoToolStripe.Name = "generoToolStripe";
            this.generoToolStripe.Size = new System.Drawing.Size(180, 26);
            this.generoToolStripe.Text = "Gênero";
            this.generoToolStripe.Click += new System.EventHandler(this.gêneroToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatórioDiárioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar Locação";
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendentesToolStripMenuItem,
            this.faturamentoDoDiaToolStripMenuItem,
            this.faturamentoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // pendentesToolStripMenuItem
            // 
            this.pendentesToolStripMenuItem.Name = "pendentesToolStripMenuItem";
            this.pendentesToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.pendentesToolStripMenuItem.Text = "Pendentes";
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.faturamentoToolStripMenuItem.Text = "Faturamento do Mês";
            // 
            // gráficosPizzaDeClientesPorEndereçoToolStripMenuItem
            // 
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1,
            this.gráficoDeBarraDeAtradosPorMêsToolStripMenuItem});
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.Name = "gráficosPizzaDeClientesPorEndereçoToolStripMenuItem";
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.Text = "Gráficos";
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem.Click += new System.EventHandler(this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem_Click);
            // 
            // gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1
            // 
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1.Name = "gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1";
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1.Size = new System.Drawing.Size(379, 26);
            this.gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1.Text = "Gráfico Pizza de Clientes por Endereço";
            // 
            // gráficoDeBarraDeAtradosPorMêsToolStripMenuItem
            // 
            this.gráficoDeBarraDeAtradosPorMêsToolStripMenuItem.Name = "gráficoDeBarraDeAtradosPorMêsToolStripMenuItem";
            this.gráficoDeBarraDeAtradosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(379, 26);
            this.gráficoDeBarraDeAtradosPorMêsToolStripMenuItem.Text = "Gráfico de Barra de Atrados por Mês";
            // 
            // xilften
            // 
            this.xilften.Image = global::LocadoraClassic.View.Properties.Resources.Design_sem_nome;
            this.xilften.Location = new System.Drawing.Point(169, 132);
            this.xilften.Name = "xilften";
            this.xilften.Size = new System.Drawing.Size(454, 173);
            this.xilften.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.xilften.TabIndex = 1;
            this.xilften.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::LocadoraClassic.View.Properties.Resources.dark_red_color_solid_background_1920x1080;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xilften);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmMenu";
            this.Text = "Locadora Classic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xilften)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosPizzaDeClientesPorEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripe;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosPizzaDeClientesPorEndereçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeBarraDeAtradosPorMêsToolStripMenuItem;
        private System.Windows.Forms.PictureBox xilften;
    }
}

