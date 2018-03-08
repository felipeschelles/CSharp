using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    
    public class ClienteController
    {
        public List<Cliente> MeusClientes { get; set; }
        public void SalvarCliente(Cliente cliente)
        {

            MeusClientes.Add(cliente);
    
        }
        public ClienteController()
        {
            MeusClientes = new List<Cliente>();
        }
    }
}
