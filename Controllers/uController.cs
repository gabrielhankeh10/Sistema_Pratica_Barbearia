using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema__Renovo_Barber
{
    public class uController
    {
        public uController()
        {

        }
        uDao Dao = new uDao();
        Object Obj = null;
        
        public virtual void Salvar(Object obj)
        {
            Obj = obj;
            Dao.Salvar(Obj);
        }
        public virtual void Carregar()
        {

        }
        public virtual void Excluir()
        {

        }
        public virtual void Alterar()
        {

        }
    }
}
