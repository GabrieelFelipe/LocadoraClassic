using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gráficosPizzaDeClientesPorEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Classe --- Objeto -------- Construtor.  Orientação a objetos ↓ 
            FrmTelaGenero frnTelaGenero = new FrmTelaGenero();
            //frnTelaGenero.MdiParent = this;
            frnTelaGenero.Show();
            xilften.Visible = false;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTelaCategoria frnTelaCategoria = new FrmTelaCategoria();
            //frnTelaCategoria.MdiParent = this;
            frnTelaCategoria.Show();
        }
    }
}
