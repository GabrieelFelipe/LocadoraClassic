using LocadoraClassic.DAL;
using LocadoraClassic.VO;
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
    public partial class FrmTelaCategoria : Form
    {
        public FrmTelaCategoria()
        {
            InitializeComponent();
        }

        private void FrmTelaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto VO
            Categoria categoria = new Categoria();

            //Objeto DAL
            CategoriaDAL categoriadal = new CategoriaDAL();

            //Pegar o valor da caixinha e colocar na 
            categoria.Nome = txtCategoria1.Text;

            //Inserir no Banco de dados
            categoriadal.InserirCategoria(categoria);

            //Limpar a caixa
            txtCategoria1.Text = "";
            CarregarGrid();
            MessageBox.Show("Categoria inserida!");
        }

        

        public void CarregarGrid()
        {
            dgvCategorias.DataSource = new CategoriaDAL().ObterCategorias().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmTelaCategoria_Load_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
