
using Modelos;
using Controllers;
using System;
using System.Collections.Generic;

namespace ConsoleView
{
    class Program
    {

        enum OpcoesMenuPrincipal  // Enumeradores
        {
            CadastrarCliente=1,
            PesquisarCliente=2,
            EditarCliente=3,
            ExcluirCliente=4,
            ListarClientes=5,
            LimparTela=6,
            Sair=7,
        }
        private static OpcoesMenuPrincipal Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha sua opção");
            Console.WriteLine("");

            Console.WriteLine(" - Cliente - ");
            Console.WriteLine("1 - Cadastrar Novo");
            Console.WriteLine("2 - Pesquisar Cliente");
            Console.WriteLine("3 - Editar Cliente");
            Console.WriteLine("4 - Excluir Cliente");
            Console.WriteLine("5 - Listar Clientes");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("7 - Sair");


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
                        Cliente cliente = CadastrarCliente();
                        ExbirCliente(cliente);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        Cliente clienteBusca = PesquisarCliente();
                        ExbirCliente(clienteBusca);
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        ExcluirCliente();
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        break;
                    case OpcoesMenuPrincipal.ListarClientes:
                        ListarClientes();
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

        private static void ListarClientes()
        {
            Console.WriteLine();
            Console.WriteLine(" -- Clientes Cadastrados --");

            ClienteController cc = new ClienteController();
            List<Cliente> lista = cc.ListarClientes();

            foreach (Cliente cli in lista)
            {
                ExbirCliente(cli);
            }

        }

        private static void ExcluirCliente()
        {
            ClienteController cc = new ClienteController();
            Console.WriteLine("Digite o ID do cliente que deseja excluir: ");
            int idCliente = Console.Read();
            Boolean status = cc.ExcluirCliente(idCliente);
            if (status)
            {
                Console.WriteLine();
                Console.WriteLine(" -- Excluido com sucesso -- ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" -- Cliente nao encontrado --");
                Console.WriteLine();
            }
        }

        private static Cliente PesquisarCliente()
        {
            Console.WriteLine("Nome do cliente pesquisado: ");
            String nome = Console.ReadLine();
            ClienteController cc = new ClienteController();
            Cliente ClienteRetornado =cc.BuscarClientePorNome(nome);
            if (ClienteRetornado != null)
            {
                return ClienteRetornado;
            }else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" -- Cliente não encontrado -- ");
                Console.WriteLine();
                return null;
            }
            
        }

        private static Cliente CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite o nome:");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Digite o cpf:");
            cliente.Cpf = int.Parse(Console.ReadLine());

            Console.WriteLine("");


            cliente._Endereco = new Endereco();

            Console.WriteLine("Endereço");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome da Rua:");
            cliente._Endereco.Rua = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Digite o numero:");
            cliente._Endereco.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite complemento:");
            cliente._Endereco.Complemento = Console.ReadLine();

            ClienteController cc = new ClienteController();
            cc.SalvarCliente(cliente);

            return cliente;
           



        }

        private static void ExbirCliente(Cliente cliente)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------Cliente Cadastrado---------");
            Console.WriteLine("");
            Console.WriteLine("ID:" + cliente.PessoaID);
            Console.WriteLine("Nome do cliente: " + cliente.Nome);
            Console.WriteLine("CPF do cliente: " + cliente.Cpf);
            Console.WriteLine("");
            Console.WriteLine("Endereço do cliente");
            Console.WriteLine("Nome da Rua: " + cliente._Endereco.Rua);
            Console.WriteLine("Numero da casa: " + cliente._Endereco.Numero);
            Console.WriteLine("Complemento: " + cliente._Endereco.Complemento);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }
}
