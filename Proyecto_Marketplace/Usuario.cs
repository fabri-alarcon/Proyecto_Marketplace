namespace Proyecto_Marketplace
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contraseña;
        private string email;

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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Usuario(string nombre, string pass, string correo)
        {
            nombreUsuario = nombre;
            contraseña = pass;
            email = correo;
        }

        // Verifica si el usuario y contraseña coinciden
        public bool ValidarLogin(string nombre, string pass)
        {
            return nombre == nombreUsuario && pass == contraseña;
        }
    }
}
