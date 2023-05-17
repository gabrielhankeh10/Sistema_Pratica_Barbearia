using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uFornecedor : uPessoa
    {
        public uFornecedor()
        {
            uPessoa Pessoa = new uPessoa();
            uCidade Cidade = new uCidade();
        }
        public uPessoa Pessoa { get; set; }
        public uCidade Cidade { get; set; }
        public string NomeFantasia { get; set; }
        public string InscMunicipal { get; set; }
        public string InscEstadual { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
    }
}
