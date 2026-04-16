namespace AgendaContactos.DAL
{
    public class Contacto
    {
        public string Categoria { get; internal set; }
        public string Correo { get; internal set; }
        public string Telefono { get; internal set; }
        public string Nombre { get; internal set; }
        public object Id { get; internal set; }
    }
}