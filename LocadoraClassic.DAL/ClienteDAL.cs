using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{

    public class ClienteDAL
    {
        public void InserirCliente(Cliente cliente)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO cliente(nome,endereco,telefone,CPF,RG)values(@nome,@endereco,@telefone,@CPF,@RG)";
            comando.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            comando.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@telefone", cliente.Telefone));
            comando.Parameters.Add(new MySqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new MySqlParameter("@RG", cliente.RG));

            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Cliente> ObterClientes()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                cliente.Telefone = reader["telefone"].ToString();
                cliente.CPF = reader["CPF"].ToString();
                cliente.RG = reader["RG"].ToString();
                clientes.Add(cliente);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;
        }
    }
}
