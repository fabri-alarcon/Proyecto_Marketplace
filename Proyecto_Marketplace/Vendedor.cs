using System.Collections.Generic;

namespace Proyecto_Marketplace
{
    public class Vendedor : Usuario
    {
        private List<Publicacion> publicaciones;

        public List<Publicacion> Publicaciones
        {
            get { return publicaciones; }
        }

        public Vendedor(string nombre, string pass, string correo)
            : base(nombre, pass, correo)
        {
            publicaciones = new List<Publicacion>();
        }

        public void AgregarPublicacion(Publicacion pub)
        {
            publicaciones.Add(pub);
        }
    }
}
