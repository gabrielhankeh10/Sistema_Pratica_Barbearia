using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    class uCtrlParcelas :uController
    {
        private uParcelas Parcelas = new uParcelas();
        private uDaoParcelas DaoParcelas = new uDaoParcelas();
        public uCtrlParcelas()
        {

        }
        public bool Salvar(uParcelas parcelas)
        {
            Parcelas = parcelas;
            return DaoParcelas.Salvar(parcelas);
        }
    }
}
