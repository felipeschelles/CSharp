﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();
        public void SalvarCliente(Cliente cliente)
        {

            MeusClientes.Add(cliente);
    
        }

        public Cliente BuscarClientePorNome(string nome)
        {
            
                var c = from x in MeusClientes
                            where x.Nome.ToLower().Contains(nome.Trim().ToLower())
                            select x;

            if (c != null){
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

        public Boolean ExcluirCliente(int ID)
        {

            Cliente cliente = BuscarClientePorID(ID);

            var c = from x in MeusClientes
                    where x.Equals(cliente)
                    
                    
                    

            if (c != null)
            {
                return c.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

    }
}
