using Sistema__Renovo_Barber.Classes;
using Sistema__Renovo_Barber.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Controllers
{
    public class uCtrlPaises : uController
    {
        private uPais Pais = new uPais();
        private uDaoPaises DaoPais = new uDaoPaises();
        public uCtrlPaises()
        {
            
        }
        public void Salvar(uPais pais)
        {
            Pais = pais;
            DaoPais.Salvar(Pais);
        }
        public void Alterar(uPais pais)
        {
            Pais = pais;
            DaoPais.Alterar(Pais);
        }
        public void Excluir(uPais pais)
        {
            Pais = pais;
            DaoPais.Excluir(Pais);
        }
        public uPais PesquisarNome(string pais)
        {
            return DaoPais.SelecionarNome(pais);
        }
        public uPais Carregar(int Id)
        {
            uPais Pais = DaoPais.Selecionar(Id);
            return Pais;
        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoPais.PopularGrid();
            return vData;
        }
    }
}
