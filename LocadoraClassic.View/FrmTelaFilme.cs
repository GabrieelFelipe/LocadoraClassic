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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraClassic.View
{
    public partial class FrmTelaFilme : Form
    {
        
        List<Categoria> categorias = new List<Categoria>();
        Categoria categoria = new Categoria();
        Genero genero = new Genero();
        GeneroDAL generoDAL = new GeneroDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        List<Genero> generos = new List<Genero>();
        int idSelecionadoCat;
        int idSelecionadoGen;

        public FrmTelaFilme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaFilme_Load(object sender, EventArgs e)
        {
            //*******************MOCK DA LISTA*********************
            CarregarCategoria();
            CarregarGenero();
        }

        private void cbBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            idSelecionadoCat = (int)cbBoxCategoria.SelectedValue;
            idSelecionadoGen = (int)cbBoxGenero.SelectedValue;

            MessageBox.Show("Id Cat:" + idSelecionadoCat.ToString());
            MessageBox.Show("Id Gen:" + idSelecionadoGen.ToString());

            Filme filme = new Filme();
            filme.IdCategoria = idSelecionadoCat;
            filme.IdGenero = idSelecionadoGen;
            filme.Nome = txtNomefilme.Text;
            filme.Sinopse = txtSinopse.Text;
            filme.Duracao = TimeSpan.Parse(maskedTxtDuracao.Text);
            filme.StLocado = checkBoxLocado.Checked;
            filme.Banner = "C:/imagens/filme.png";
            FilmeDAL filmeDAL = new FilmeDAL();
            filmeDAL.InserirFilme(filme);

        }

        private void cbBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomefilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTxtDuracao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSinopse_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxLocado_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void CarregarCategoria()
        {

            //Criando categorias

            /* categoria.Id = 1;
             categoria.Nome = "Classic Vintage Raro";
             categoria.vlDiaria = 19.78m;

             Categoria categoria2 = new Categoria();
             categoria2.Id = 2;
             categoria2.Nome = "Popular Padrão";
             categoria2.vlDiaria = 9.50m;

             //Adicionando as duas categorias

             categorias.Add(categoria);
             categorias.Add(categoria2);*/

            cbBoxCategoria.DisplayMember = "Nome";
            cbBoxCategoria.ValueMember = "Id";
            cbBoxCategoria.DataSource = categoriaDAL.ObterCategorias().ToList();
        }


        public void CarregarGenero()
        {

            //Criando categorias

            /*genero.Id = 1;
            genero.Nome = "Terror";
          

            Genero genero2 = new Genero();
            genero2.Id = 2;
            genero2.Nome = "Comedia";


            //Adicionando dois generos
            generos.Add(genero);
            generos.Add(genero2);*/



            cbBoxGenero.DisplayMember = "Nome";
            cbBoxGenero.ValueMember = "Id";
            cbBoxGenero.DataSource = generoDAL.ObterGeneros().ToList();


        }
    }
}
