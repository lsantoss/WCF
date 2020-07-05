using System.Runtime.Serialization;

namespace Passagens
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Cpf { get; set; }
    }
}