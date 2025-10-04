using System;

namespace Proyecto_Marketplace
{
    public class Publicacion
    {
        private string titulo;
        private string descripcion;
        private string imagenUrl;
        private string contactoWhatsApp;
        private DateTime fechaPublicacion;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string ImagenUrl
        {
            get { return imagenUrl; }
            set { imagenUrl = value; }
        }

        public string ContactoWhatsApp
        {
            get { return contactoWhatsApp; }
            set { contactoWhatsApp = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
            set { fechaPublicacion = value; }
        }

        public Publicacion(string titulo, string desc, string imagen, string contacto)
        {
            this.titulo = titulo;
            this.descripcion = desc;
            this.imagenUrl = imagen;
            this.contactoWhatsApp = contacto;
            this.fechaPublicacion = DateTime.Now;
        }
    }
}
