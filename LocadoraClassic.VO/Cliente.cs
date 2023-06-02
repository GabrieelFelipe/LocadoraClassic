using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }


        public Cliente()
        {

        }


        public Cliente(int id, string nome, string endereco, string telefone, string cPF, string rG)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            CPF = cPF;
            RG = rG;
        }


        public Cliente(string nome)
        {
            Nome = nome;
        }




    }
}
