namespace Proyecto_Marketplace.clases
{
    public class Usuario
    {
        // --- PROPIEDADES ---
        private string nombreUsuario;
        private string contraseña;
        public string contacto { get; set; }
        private string RutaFoto;
        public string Rol { get; set; }
        public string Cuil { get; set; }

        // --- ¡NUEVAS PROPIEDADES! ---
        public string Email { get; set; }
        public bool IsEmailVerified { get; set; }
        // --- FIN DE PROPIEDADES NUEVAS ---

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        // --- CONSTRUCTORES ---

        public Usuario() { }

        public Usuario(string nom)
        {
            nombreUsuario = nom;
            Rol = (nom == "Invitado") ? "Invitado" : "Usuario";
            contacto = "";
            Cuil = "";
            Email = "";
            IsEmailVerified = false;
        }

        // Constructor principal para el Registro (ACTUALIZADO)
        public Usuario(string nombre, string pass, string contactoUsuario, string cuilUsuario, string emailUsuario)
        {
            nombreUsuario = nombre;
            contraseña = pass;
            contacto = contactoUsuario;
            Cuil = cuilUsuario;
            Email = emailUsuario; // <-- Añadido
            IsEmailVerified = false; // <-- Por defecto, no está verificado
            RutaFoto = "";
            Rol = "Usuario";
        }

        // --- MÉTODOS ---

        public string cambiarRutaFotoPerfil(string nuevaRuta)
        {
            RutaFoto = nuevaRuta;
            return RutaFoto;
        }

        public string obtenerRutaFotoPerfil()
        {
            return RutaFoto;
        }

        public bool ValidarLogin(string nombre, string pass)
        {
            return nombre == nombreUsuario && pass == contraseña;
        }
    }
}