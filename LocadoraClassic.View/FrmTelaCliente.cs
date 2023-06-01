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
    public partial class FrmTelaCliente : Form
    {

        Cliente cliente = new Cliente();
        int id = 0;
        ClienteDAL clienteDAL = new ClienteDAL();

        public FrmTelaCliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void FrmTelaClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            dgvClientes.DataSource = new ClienteDAL().ObterClientes().ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            //Objeto DAL
            ClienteDAL clientedal = new ClienteDAL();

            //Pegar o valor da caixinha e colocar na 
            cliente.Nome = txtCliente.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = maskedTxtTelefone.Text;
            cliente.CPF = maskedTxtCpf.Text;
            cliente.RG = txtRg.Text;


            //Inserir no Banco de dados
            clientedal.InserirCliente(cliente);

            //Limpar a caixa
            txtCliente.Text = "";
            txtEndereco.Text = "";
            maskedTxtTelefone.Text = "";
            maskedTxtCpf.Text = "";
            txtRg.Text = "";

            CarregarGrid();
            MessageBox.Show("Dados do cliente inseridos!");
        }

        private void FrmTelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                int id = 0;
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                txtCliente.Text = nome;
                
                string endereco = selectedRow.Cells["Endereco"].Value.ToString();
                txtEndereco.Text = endereco;
                
                string telefone = selectedRow.Cells["Telefone"].Value.ToString();
                maskedTxtTelefone.Text = telefone;
                
                string cPF = selectedRow.Cells["CPF"].Value.ToString();
                maskedTxtCpf.Text = cPF;
                
                string rG = selectedRow.Cells["RG"].Value.ToString();
                txtRg.Text = rG;

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
                MessageBox.Show("Categoria excluída!");
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.ExcluirCliente(id);
            CarregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtCliente.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = maskedTxtTelefone.Text;
            cliente.CPF = maskedTxtCpf.Text;
            cliente.RG = txtRg.Text;
            cliente.Id = id;

            clienteDAL.AtualizarCliente(cliente);

            txtCliente.Text = "";
            txtEndereco.Text = "";
            maskedTxtTelefone.Text = "";
            maskedTxtCpf.Text = "";
            txtRg.Text = "";
            CarregarGrid();
            MessageBox.Show("Cliente atualizado!");
        }
    }
}
