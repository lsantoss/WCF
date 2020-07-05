using System.Collections.Generic;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente Add(string nome, string cpf)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;

            ClienteDAO dao = new ClienteDAO();
            dao.Add(cliente);

            return cliente;
        }

        public Cliente Buscar(string nome)
        {
            return new ClienteDAO().Buscar(nome);
        }

        public List<Cliente> getClientes()
        {
            return ClienteDAO.Clientes;
        }
    }
}