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
        public FrmTelaCliente()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void FrmTelaClientes_Load(object sender, EventArgs e)
        {
            
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
    }
}
