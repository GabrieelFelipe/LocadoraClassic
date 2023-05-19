using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteLivraria
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int RG { get; set; }
        public string CPF { get; set; }


        //  CONSTRUTORES ↓

        public Cliente()
        { }

        public Cliente(int id, int rG)
        {
            Id = id;
            RG = rG;
        }

        public Cliente
            (
            string nome, 
            int id,
            string endereco,
            string telefone,
            int rG,
            string cPF
            )
        
        {
            Nome = nome;
            Id = id;
            Endereco = endereco;
            Telefone = telefone;
            RG = rG;
            CPF = cPF;
        }


    }
}
