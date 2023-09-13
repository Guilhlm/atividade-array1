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

            string[] nome = { "gui", "pedro", "renon","edilson","monique", "gustavo" };
            float[] idade = { 17, 25, 19, 19, 18, 29 };

            float sominha = 0;

            Array.ForEach(idade, i => sominha += i / 6);
            
            for (int i = 0; i < nome.Length && i < idade.Length; i++)
            {
                Console.WriteLine(nome[i]);
                Console.WriteLine(idade[i]);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("media das idades");
            Console.WriteLine(sominha);



            Console.ReadKey();
        }
    }
}
