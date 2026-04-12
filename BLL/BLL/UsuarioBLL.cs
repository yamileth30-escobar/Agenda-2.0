using AgendaContactos.DAL;
using AgendaContactos.EL;

namespace AgendaContactos.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL dal = new UsuarioDAL();

        public bool Login(Usuario u)
        {
            return dal.Login(u);
        }
    }
}
