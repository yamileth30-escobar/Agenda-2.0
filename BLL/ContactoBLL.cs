using System.Data;
using AgendaContactos.DAL;
using AgendaContactos.EL;

namespace AgendaContactos.BLL
{
    public class ContactoBLL
    {
        private readonly ContactoDAL dal = new ContactoDAL();

        public void Guardar(Contacto c) => dal.Insertar(c);
        public DataTable Listar() => dal.Listar();
        public void Editar(Contacto c) => dal.Actualizar(c);
        public void Eliminar(int id) => dal.Eliminar(id);
        public DataTable Buscar(string valor) => dal.Buscar(valor);
    }
}
