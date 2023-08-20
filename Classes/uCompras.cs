using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uCompras : uPai
    {
        public uCompras()
        {
            uFornecedor Fornecedor = new uFornecedor();
            uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
        }
        public uPai Pai { get; set; }
        public uFornecedor Fornecedor { get; set; }
        public uCondicaoPagamento CondicaoPagamento { get; set; }
        public int Num_nfc { get; set; }
        public int Modelo_nfc { get; set; }
        public int Serie_nfc { get; set; }
        public decimal Valor_total { get; set; }
        public decimal Valor_frete { get; set; }
        public decimal Valor_seguro { get; set; }
        public decimal Valor_outras_despesas { get; set; }
        public int MyProperty { get; set; }
        public DateTime Data_chegada { get; set; }
        public DateTime Data_emissao { get; set; }
        public DateTime Data_cancelamento { get; set; }

    }
}
