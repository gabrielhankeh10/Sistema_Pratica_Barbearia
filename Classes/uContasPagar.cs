using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uContasPagar : uPai
    {
        public uContasPagar()
        {
            uFornecedor Fornecedor = new uFornecedor();
            uCondicaoPagamento CondicaoPagamento = new uCondicaoPagamento();
            uCompras Compras = new uCompras();
        }
        public uFornecedor Fornecedor { get; set; }
        public uCondicaoPagamento CondicaoPagamento { get; set; }
        public uCompras Compras { get; set; }
        public uFormaPagamento FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public string Situacao { get; set; }
        public int NumParcela { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataBaixa { get; set; }
        public DateTime DataVencimento { get; set; }
        public static List<uContasPagar> MakeBills(uCompras compras, uCondicaoPagamento condicaoPagamento)
        {
            List<uContasPagar> vLista = new List<uContasPagar>();
            uCondicaoPagamento condicao = condicaoPagamento;
            int QtdParcelas = condicao.uParcelas.Count;
            int i = 0;
            foreach(uParcelas parcelas in condicao.uParcelas)
            {
                uContasPagar Pagar = new uContasPagar();
                Pagar.Compras.Num_nfc = compras.Num_nfc;
                Pagar.Compras.Modelo_nfc = compras.Modelo_nfc;
                Pagar.Compras.Serie_nfc = compras.Serie_nfc;
                Pagar.Fornecedor.id = compras.Fornecedor.id;
                Pagar.CondicaoPagamento = condicaoPagamento;
                Pagar.Situacao = "AB";
                Pagar.Compras = compras;
                Pagar.DataVencimento = compras.Data_emissao.AddDays(parcelas.DiasTotais);
                Pagar.data_criacao = compras.Data_emissao;
                Pagar.Valor = ((Convert.ToDecimal(parcelas.Porcentagem) / 100) * compras.Valor_total) + (condicao.Taxa / condicao.uParcelas.Count);
                Pagar.FormaPagamento = parcelas.FormaPagamento;
                Pagar.NumParcela = i;
                i++;
                vLista.Add(Pagar);
            }
            return vLista;
        }
    }
}
