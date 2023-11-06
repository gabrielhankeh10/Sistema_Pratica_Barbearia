using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber.Classes
{
    public class uAgenda
    {
        public uAgenda()
        {
            uFuncionario Funcionario = new uFuncionario();
            uCliente Cliente = new uCliente();
            uServicos Servicos = new uServicos();
            uContasReceber ContasReceber = new uContasReceber();
        }

        public uFuncionario Funcionario { get; set; }
        public uCliente Cliente { get; set; }
        public uServicos Servicos { get; set; }
        public uContasReceber ContasReceber { get; set; }
        public int Intervalo { get; set; }
        public int id_agenda { get; set; }
        public int? id_agenda_referencia { get; set; }
        public DateTime Data { get; set; }
    }
}
