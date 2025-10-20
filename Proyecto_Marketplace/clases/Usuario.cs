namespace Proyecto_Marketplace.clases
{
    public class Usuario 
    {
        private string nombreUsuario;
        private string contraseña;
        public string contacto;
        private string RutaFoto;

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

     
        



        public Usuario(string nombre, string pass)
        {
            nombreUsuario = nombre;
            contraseña = pass;
            RutaFoto = "";
            contacto = "";
        }

        public Usuario(string nom)
        {
           nombreUsuario = nom;
        }
        public Usuario()
        {
            
        }



        public string cambiarRutaFotoPerfil(string nuevaRuta)
        {
            RutaFoto = nuevaRuta;
            return RutaFoto;
        }
        
        public string obtenerRutaFotoPerfil()
        {
            return RutaFoto;
        }


        // Verifica si el usuario y contraseña coinciden
        public bool ValidarLogin(string nombre, string pass)
        {
            return nombre == nombreUsuario && pass == contraseña;
        }
    }
}
