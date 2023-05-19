using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneroLivraria
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }


        //  CONSTRUTORES ↓

        public Genero()
        { }

        public Genero(int id)
        {
            Id = id;
        }

        public Genero(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }
    }
}
