using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nome = { "gui", "pedro", "renon","edilson","monique", "gustavo" }; //tipo da variavel [] - array variavel { };

            float[] idade = { 17, 25, 19, 19, 18, 29 }; //tipo da variavel [] - array variavel { };

            float sominha = 0; //variavel com valor fixo;

            Array.ForEach(idade, i => sominha += i / 6); //foreach executa tudo dentro da array;
            
            for (int i = 0; i < nome.Length && i < idade.Length; i++) // variavel.LENGTH soma tudo da array   // i= contador
            {
                Console.WriteLine(nome[i]); // (variavel[i=contagem]);

                Console.WriteLine(idade[i]); // (variavel[i=contagem]);
            }

            Console.ForegroundColor = ConsoleColor.Red; //corzinha;

            Console.WriteLine(""); //espaço de baiano;

            Console.WriteLine("media das idades"); //escreve texto;

            Console.WriteLine(sominha); //exibe o valor da minha variavel;

            Console.ReadKey(); //mantem o console ativo ;
        }
    }
}
