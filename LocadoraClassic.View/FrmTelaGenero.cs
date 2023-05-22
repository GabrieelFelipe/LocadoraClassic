using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;
using LocadoraClassic.DAL;

namespace LocadoraClassic.View
{
    public partial class FrmTelaGenero : Form
    {
        public FrmTelaGenero()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto VO
            Genero genero = new Genero();

            //Objeto DAL
            GeneroDAL generodal = new GeneroDAL();

            //Pegar o valor da caixinha e colocar na 
            genero.Nome = txtGenero.Text;

            //Inserir no Banco de dados
            generodal.InserirGenero(genero);

            //Limpar a caixa
            txtGenero.Text = "";
            MessageBox.Show("Dado inserido!");

            
        }

        private void FrmTelaGenero_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
