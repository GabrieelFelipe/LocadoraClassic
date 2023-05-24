using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {
        public void InserirCategoria(Categoria categoria)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO categoria(diaria)values(@diaria)";
            comando.Parameters.Add(new MySqlParameter("@diaria", categoria.Diaria));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Categoria> ObterCategorias()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM categoria";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = Convert.ToInt32(reader["id"]);
                categoria.Nome = reader["nome"].ToString();
                categorias.Add(categoria);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return categorias;
        }
    }
}
