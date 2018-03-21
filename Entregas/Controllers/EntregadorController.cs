using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class EntregadorController
    {
        static List<Entregador> MeusEntregadores = new List<Entregador>();
        static int ultimoID = 0;
        public void SalvarCliente(Entregador entregador)
        {

            int id = ultimoID = +1;
            entregador.PessoaID = id;
            MeusEntregadores.Add(entregador);

        }

        public Entregador BuscarEntregadorPorNome(string nome)
        {

            var c = from x in MeusEntregadores
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

        public Entregador BuscarEntregadorPorID(int ID)
        {

            var e = from x in MeusEntregadores
                    where x.PessoaID.Equals(ID)
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

        public Boolean ExcluirEntregador(int ID)
        {

            Entregador entregador = BuscarEntregadorPorID(ID);

            if (entregador != null)
            {
                MeusEntregadores.Remove(entregador);
                return true;

            }
            else
            {
                return false;
            }


        }

        public List<Entregador> ListarEntregadores()
        {
            return MeusEntregadores;
        }


  //     public Entregador EditarContaEntregador(Entregador EntregadorEditado)
  //      {
  //          foreach (Entregador x in MeusEntregadores)
  //          {
  //              if (EntregadorEditado.PessoaID == x.PessoaID)
  //              {

   //              }
   //          }
   //     }
        
    }
}

