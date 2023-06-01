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

        Categoria categoria = new Categoria();
        int id = 0;
        CategoriaDAL categoriaDAL = new CategoriaDAL();

        public FrmTelaCategoria()
        {
            InitializeComponent();
            CarregarGrid();
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.CellDoubleClick += btnAtualizar_Click;
        }

        private void FrmTelaCategoria_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto VO
            Categoria categoria = new Categoria();

            //Objeto DAL
            CategoriaDAL categoriadal = new CategoriaDAL();

            //Pegar o valor da caixinha e colocar na 
            categoria.Nome = txtNome.Text;
            categoria.Diaria = txtDiaria.Text;

            //Inserir no Banco de dados
            categoriadal.InserirCategoria(categoria);

            //Limpar a caixa
            txtNome.Text = "";
            txtDiaria.Text = "";
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
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvCategorias.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                int id = 0;
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                txtNome.Text = nome;
                string diaria = selectedRow.Cells["Diaria"].Value.ToString();
                txtDiaria.Text = diaria;


                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
            }
        }

        private void FrmTelaCategoria_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            categoria.Nome = txtNome.Text;
            categoria.Diaria = txtDiaria.Text;
            categoria.Id = id;

            categoriaDAL.AtualizarCategoria(categoria);

            txtNome.Text = "";
            txtDiaria.Text = "";
            CarregarGrid();
            MessageBox.Show("Categoria atualizada!");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvCategorias.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
                MessageBox.Show("Categoria excluída!");
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            CategoriaDAL categoriaDAL = new CategoriaDAL();
            categoriaDAL.ExcluirCategoria(id);
            CarregarGrid();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
