using Agenda.EL;
using AgendaContactos.DAL;
using AgendaContactos.EL;

namespace AgendaContactos.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public bool Login(UsuarioEL u)
        {
            return dal.Login(u);
        }
    }
}

