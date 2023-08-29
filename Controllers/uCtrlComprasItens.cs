using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    public class uCtrlComprasItens
    {
        private uItensCompra ItensCompra = new uItensCompra();
        private uDaoItensCompra DaoItensCompra = new uDaoItensCompra();
        public uCtrlComprasItens()
        {

        }
        public void SalvarItens(uItensCompra itensCompra)
        {
            ItensCompra = itensCompra;
            DaoItensCompra.Salvar(ItensCompra);
        }
    }

}
