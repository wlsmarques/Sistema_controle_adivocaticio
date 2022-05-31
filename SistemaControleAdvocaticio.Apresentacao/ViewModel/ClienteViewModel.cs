using SistemaControleAdvocaticio.Dominio.Entidades;
using System.Collections.Generic;

namespace SistemaControleAdvocaticio.Apresentacao.ViewModel
{
    public class ClienteViewModel
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public List<Cliente> ListaCliente { get; set; }
    }
}
