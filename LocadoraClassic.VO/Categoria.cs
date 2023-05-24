using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Diaria { get; set; }


        public Categoria()
        {

        }


        public Categoria(int id, string nome, string diaria)
        {
            Id = id;
            Nome = nome;
            Diaria = diaria;
        }


        public Categoria(string nome)
        {
            Nome = nome;
        }


    }
}
