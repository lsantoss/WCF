using Passagens;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ClienteService));

            Uri endereco = new Uri("http://localhost:3030/clientes");

             host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), endereco);

            try
            {
                host.Open();
                ExibeInformacoesServico(host);

                Console.ReadLine();

                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void ExibeInformacoesServico(ServiceHost sh)
        {
            Console.WriteLine($"{sh.Description.ServiceType} online");

            foreach(ServiceEndpoint se in sh.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}