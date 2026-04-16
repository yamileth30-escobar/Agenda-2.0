using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AgendaContactos.EL;
using AgendaContactos.DAL;

namespace AgendaContactos.BLL
{
    public class CategoriaBLL
    {
        CategoriaDAL dal = new CategoriaDAL();

        public void Guardar(Categoria entidad)
        {
            if (!string.IsNullOrEmpty(entidad.NombreCategoria))
            {
                dal.Insertar(entidad);
            }
        }

        public DataTable Listar()
        {
            return dal.Listar();
        }
    }
}
