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
    class uCtrlFuncionario : uController
    {
        private uFuncionario Funcionario = new uFuncionario();
        private uDaoFuncionarios DaoFuncionario = new uDaoFuncionarios();
        public uCtrlFuncionario()
        {

        }
        public void Alterar(uFuncionario funcionario)
        {
            Funcionario = funcionario;
            DaoFuncionario.Alterar(Funcionario);
        }
        public uFuncionario Carregar(int Id)
        {
            uFuncionario Funcionario = DaoFuncionario.Selecionar(Id);
            return Funcionario;
        }
        public DataTable PopularGrid()
        {
            DataTable vData = new DataTable();
            vData = DaoFuncionario.PopularGrid();
            return vData;
        }
        public void Salvar(uFuncionario funcionario)
        {
            Funcionario = funcionario;
            DaoFuncionario.Salvar(funcionario);
        }
    }
}
