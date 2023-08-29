using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uItensCompra :uPai
    {
        public uItensCompra()
        {
            uProdutos Produtos = new uProdutos();
        }
        public uProdutos Produtos { get; set; }
        public int Num_nfc { get; set; }
        public int Modelo_nfc { get; set; }
        public int Serie_nfc { get; set; }
        public int Id_fornecedor { get; set; }
        public int Qtd { get; set; }
        public decimal Preco_custo { get; set; }
        public decimal Total_custo { get; set; }
        public decimal Desconto { get; set; }
        public decimal Percentual_compra { get; set; }
        public decimal Media_ponderada { get; set; }
    }
}
