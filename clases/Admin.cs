using Proyecto_Marketplace.clases;

namespace Proyecto_Marketplace.clases
{
    public class Admin : Usuario
    {
        public Admin(string nombre, string pass, string contacto)
            : base(nombre, pass, contacto, "", "") // Pasamos "" para cuil y "" para email
        {
            Rol = "Admin";
        }

       
    }
}