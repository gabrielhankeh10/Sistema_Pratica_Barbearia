using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uProdutos :uPai
    {
        public uProdutos()
        {

        }
        public uPai Pai { get; set; }
        public string Descricao_produto { get; set; }
        public string Marca { get; set; }
        public decimal Preco_venda { get; set; }
        public decimal Preco_custo { get; set; }
        public int Qtd_estoque { get; set; }
    }
}
