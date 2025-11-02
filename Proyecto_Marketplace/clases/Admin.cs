using Proyecto_Marketplace.clases;

namespace Proyecto_Marketplace.clases
{
    public class Admin : Usuario
    {
        // --- INICIO DE LA CORRECIÓN ---

        // El constructor de Admin ahora debe llamar al constructor de 4 argumentos de Usuario
        public Admin(string nombre, string pass, string contacto)
            : base(nombre, pass, contacto, "") // <-- Pasamos un CUIL vacío
        {
            Rol = "Admin";
        }

        // --- FIN DE LA CORRECIÓN ---
    }
}
