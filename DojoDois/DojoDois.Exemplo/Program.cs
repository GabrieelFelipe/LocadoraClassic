using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoDois.Exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 10;               //variavel de valor
            string nome = "Rômulo";       //variavel de referencia

            Console.WriteLine(nome);
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(idade);
            Console.ReadKey();
        }
    }
}
