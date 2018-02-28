using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = string.Empty;


            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Ola " + nome);
            Console.ReadKey();
        }
    }
}
