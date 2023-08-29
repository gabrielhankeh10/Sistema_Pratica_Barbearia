using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    public class uCtrlContasPagar
    {
        private uContasPagar ContasPagar = new uContasPagar();
        private uDaoContasPagar DaoContasPagar = new uDaoContasPagar();

        public uCtrlContasPagar()
        {

        }
        public void SalvarTitulos(uContasPagar contasPagar)
        {
            ContasPagar = contasPagar;
            DaoContasPagar.Salvar(contasPagar);
        }
    }
}
