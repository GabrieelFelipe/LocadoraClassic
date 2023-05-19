using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoriasLivraria
{
    public class Categorias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valordiaria { get; set; }


        //  CONSTRUTORES ↓

        public Categorias()
        { }

        public Categorias(int id)
        {
            Id = id;
        }

        public Categorias(string nome, int id, string valordiaria)
        {
            Nome = nome;
            Id = id;
            Valordiaria = valordiaria;  
        }
    }
}
