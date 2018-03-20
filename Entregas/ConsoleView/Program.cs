
using Modelos;
using Controllers;
using System;

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
            LimparTela=5,
            Sair=6,
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
            Console.WriteLine("3 - Excluir Cliente");

            Console.WriteLine(" - Geral - ");
            Console.WriteLine("4 - Limpar Tela");
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
                        Cliente cliente = CadastrarCliente();
                        ExibirCliente(cliente);
                        break;
                    case OpcoesMenuPrincipal.PesquisarCliente:
                        Cliente clienteBusca = PesquisarCliente();
                        ExibirCliente(clienteBusca);
                        break;
                    case OpcoesMenuPrincipal.EditarCliente:
                        EditarCliente();
                        break;
                    case OpcoesMenuPrincipal.ExcluirCliente:
                        ExcluirCliente();
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

        private static void EditarCliente()
        {
            
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

            Endereco e = CadastrarEndereco();
            

            cliente.EnderecoID = e.EnderecoID;

            ClienteController cc = new ClienteController();
            cc.SalvarCliente(cliente);

            return cliente;

        }
        private static Endereco CadastrarEndereco()
        {
            Endereco endereco = new Endereco();

            Console.WriteLine("Endereço");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome da Rua:");
            endereco.Rua = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Digite o numero:");
            endereco.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite complemento:");
            endereco.Complemento = Console.ReadLine();

            EnderecoController ee = new EnderecoController();
            ee.SalvarEndereco(endereco);

            return endereco;

        }


        

        private static void ExibirCliente(Cliente cliente)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------Cliente Cadastrado---------");
            Console.WriteLine("");
            Console.WriteLine("ID:" + cliente.PessoaID);
            Console.WriteLine("Nome do cliente: " + cliente.Nome);
            Console.WriteLine("CPF do cliente: " + cliente.Cpf);
            Console.WriteLine("");

            EnderecoController ee = new EnderecoController();
            Endereco endereco = ee.BuscarEnderecoPorID(cliente.EnderecoID);

            Console.WriteLine("Endereço do cliente");
            Console.WriteLine("Nome da Rua: " + endereco.Rua);
            Console.WriteLine("Numero da casa: " + endereco.Numero);
            Console.WriteLine("Complemento: " + endereco.Complemento);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");


        }
    }
}
