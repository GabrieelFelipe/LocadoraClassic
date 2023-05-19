using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDotNet.CompetenciaUm
{
    internal class Program
    {
        //O compilador vai chegar aqui
        static void Main(string[] args)
        { //inicio do algoritimo

            /*
            *Exemplo de anotações grandes
            *
            *
            */

            //Variáveis
            int notaUm;
            int notaDois;
            int notaTres;
            int notaQuatro;
            int soma;
            double media;
            //string é nome

            //perguntas do Paulo
            //A linguagem C# é Case Sensitive (diferencia maiúscula de minúscula)

            //O sinal de igualdade (=) significa atribuição, ou seja, colocar um valor dentro da variavel
            Console.WriteLine("Qual a sua primeira nota?");
            notaUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua segunda nota?");
            notaDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua terceira nota?");
            notaTres = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua quarta nota?");
            notaQuatro = int.Parse(Console.ReadLine());

            //
            soma = notaUm+notaDois+notaTres+notaQuatro;

            
            media = soma / 4;

            string msg;

            if (media > -70)
            {
                msg = "Aprovado parabèns!";
            }
            else
            { 
                    msg = "reprovado continue tentando...";
            }

            //
            Console.WriteLine($"Você tirou {media} {msg}");

            Console.ReadKey();


         
        } // fim do algoritmo
    }
}
