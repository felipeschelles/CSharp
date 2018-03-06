
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {

        enum OpcoesMenuPrincipal
        {
            CadastrarCliente = 1,
            PesquisarCliente = 2,
            EditarCliente = 3,
            ExcluirCliente = 4,
            LimparTela = 5,
            Sair = 6,
        }
        private static OpcoesMenuPrincipal Menu()
        {

            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Cliente - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("3 - Excluir Cliente");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("4 - Lipar Tela");
            Console.WriteLine("6 - Sair");

            string opcao = Console.ReadLine();
            return (OpcoesMenuPrincipal)int.Parse(opcao);

        }

        static void Main(string[] args)
        {
            OpcoesMenuPrincipal opcaoDigitada = OpcoesMenuPrincipal.Sair;
            opcaoDigitada = Menu();

            while (opcaoDigitada != OpcoesMenuPrincipal.Sair)
            {

                switch (opcaoDigitada)
                {
                    case OpcoesMenuPrincipal.CadastrarCliente:
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        break;
                    case OpcoesMenuPrincipal.LimparTela:
                        break;
                    case OpcoesMenuPrincipal.Sair:
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                opcaoDigitada = Menu();
                

            }

            
        }

        private static Cliente PesquisarCliente()
        {
            return new Cliente();
        }

        private static void CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Digite o cpf:");
            cliente.Cpf = Console.Read();

            Console.WriteLine("");

         


        }
    }
}
