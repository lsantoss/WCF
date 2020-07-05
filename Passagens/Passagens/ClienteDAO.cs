using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    public class ClienteDAO
    {
        public static List<Cliente> Clientes = new List<Cliente>();

        public void Add(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public Cliente Buscar(string nome)
        {
            return Clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}