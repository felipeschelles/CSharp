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
            Pessoa p = new Pessoa();


            Console.WriteLine("Escreva seu nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Ola " + p.Nome);
            Console.ReadKey();
        }
    }
}
