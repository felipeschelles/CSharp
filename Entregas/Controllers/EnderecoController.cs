using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class EnderecoController
    {
        static List<Endereco> MeusEndereco = new List<Endereco>();
        static int ultimoID = 0;
        public void SalvarEndereco(Endereco endereco)
        {

            int id = ultimoID = +1;
            Endereco.PessoaID = id;
            MeusEndereco.Add(Endereco);

        }

        public Endereco BuscarClientePorNome(string nome)
        {

            var c = from x in MeusClientes
                    where x.Nome.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
            {
                return c.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public Cliente BuscarClientePorID(int ID)
        {

            var c = from x in MeusClientes
                    where x.PessoaID.Equals(ID)
                    select x;

            if (c != null)
            {
                return c.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public Boolean ExcluirEndereco(int ID)
        {

            Endereco endereco = BuscarEnderecoPorID(ID);

            if (endereco != null)
            {
                MeusEndereco.Remove(endereco);
                return true;

            }
            else
            {
                return false;
            }


        }

        public List<Endereco> ListarEnderecos()
        {
            return MeusEndereco;
        }


        public Cliente EditarEndereco(Endereco enderecoEditado)
        {
            foreach (Endereco x in MeusEndereco)
            {
                if (enderecoEditado.PessoaID == x.PessoaID)
                {

                }
            }
        }

    }
}
}
