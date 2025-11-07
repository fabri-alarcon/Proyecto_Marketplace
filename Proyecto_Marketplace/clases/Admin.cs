using Proyecto_Marketplace.clases;

namespace Proyecto_Marketplace.clases
{
    public class Admin : Usuario
    {
        // --- INICIO DE LA CORRECIÓN ---

        // El constructor de Admin ahora debe llamar al constructor de 5 argumentos de Usuario
        // (nombre, pass, contacto, cuil, email)
        public Admin(string nombre, string pass, string contacto)
            : base(nombre, pass, contacto, "", "") // Pasamos "" para cuil y "" para email
        {
            Rol = "Admin";
        }

        // --- FIN DE LA CORRECIÓN ---
    }
}