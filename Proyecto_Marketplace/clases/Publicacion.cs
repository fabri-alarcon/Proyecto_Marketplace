using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Marketplace.clases
{
    public class Publicacion
    {

        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; } = null!;// Agregar "= null!;" (operador de tolerancia de valores NULL )
                                                   // me permite evitar errores de que este atributo sea null
        public Image Imagen { get; set; } = null!;
        public string Ubicacion { get; set; }
        public string Contacto { get; set; }
        public string Estado { get; set; } = null!;
        public string Tipo { get; set; }

        // Constructor
        public Publicacion(string titulo, string precio, string descripcion, Image imagen, string ubicacion, string contacto, string estado)
            {
                Titulo = titulo;
                Precio = precio;
                Imagen = imagen;
                Descripcion = descripcion;
                Ubicacion = ubicacion;
                Contacto = contacto;
                Estado = estado;
                Tipo = "Producto";
        }

        public Publicacion(string titulo, Image imagen, string descripcion, string ubicacion, string contacto)
        {
            Titulo = titulo;
            Imagen = imagen;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            Tipo = "Servicio";
        }
    }
}
