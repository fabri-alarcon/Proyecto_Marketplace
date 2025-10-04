using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Marketplace
{
    public class Publicacion
    {

        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public Image Imagen { get; set; }
        public string Ubicacion { get; set; }
        public string Contacto { get; set; }


        // Constructor
        public Publicacion(string titulo, string descripcion, string precio, string ubicacion, string contacto)
            {
                Titulo = titulo;
                Precio = precio;
                //Imagen = imagen;
                Descripcion = descripcion;
                Ubicacion = ubicacion;
                Contacto = contacto;
        }
    }
}
