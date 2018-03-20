using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EnderecoController
    {
        static List<Endereco> MeusEnderecos = new List<Endereco>();
        static int ultimoID = 0;
        public void SalvarEndereco(Endereco endereco)
        {

            int id = ultimoID = +1;
            endereco.EnderecoID = id;
            MeusEnderecos.Add(endereco);

        }

     

        public Endereco BuscarEnderecoPorID(int ID)
        {

            var e = from x in MeusEnderecos
                    where x.EnderecoID.Equals(ID)
                    select x;

            if (e != null)
            {
                return e.FirstOrDefault();
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
                MeusEnderecos.Remove(endereco);
                return true;

            }
            else
            {
                return false;
            }


        }

        public List<Endereco> ListarEnderecos()
        {
            return MeusEnderecos;
        }


     //   public Endereco EditarEndereco(Endereco enderecoEditado)
     //   {
     //       foreach (Endereco x in MeusEnderecos)
     //       {
     //           if (enderecoEditado.EnderecoID == x.EnderecoID)
     //           {

    //            }
    //        }
    //    }

   // }
}
}
