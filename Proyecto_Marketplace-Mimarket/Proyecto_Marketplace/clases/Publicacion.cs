using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_Marketplace.clases
{
    public class Publicacion
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; } = null!;

        public List<string> RutasImagenes { get; set; } = new List<string>();

        [JsonIgnore]
        public Image ImagenCargada
        {
            get
            {
                string rutaRelativa = RutasImagenes.FirstOrDefault(); // Esto es la ruta relativa guardada

                // Construye la ruta absoluta
                string rutaAbsoluta = string.IsNullOrEmpty(rutaRelativa) ? null : Path.Combine(Application.StartupPath, rutaRelativa);

                if (string.IsNullOrEmpty(rutaRelativa) || (rutaAbsoluta != null && !File.Exists(rutaAbsoluta)))
                {
                    string placeholderPath = Path.Combine(Application.StartupPath, "media", "placeholder.png");
                    if (File.Exists(placeholderPath))
                        return Image.FromFile(placeholderPath);
                    return new Bitmap(100, 100);
                }

                try
                {
                    // Usa la ruta absoluta para abrir el archivo
                    using (var fs = new FileStream(rutaAbsoluta, FileMode.Open, FileAccess.Read))
                    {
                        return new Bitmap(fs);
                    }
                }
                catch
                {
                    return new Bitmap(100, 100);
                }
            }
        }

        public string Ubicacion { get; set; }
        public string Contacto { get; set; }
       
        public string EstadoModeracion { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public Publicacion()
        {
        }

        // Construtor Producto (8 argumentos)
        public Publicacion(string titulo, string precio, string descripcion, List<string> rutasImagenes, string ubicacion, string contacto, string usuario, string categoria)
        {
            Titulo = titulo;
            Precio = precio; 
            RutasImagenes = rutasImagenes ?? new List<string>();
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            Tipo = "Producto";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now;
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }
        //Publicación Servicio (8 argumentos)
        public Publicacion(string titulo, string precio, List<string> rutasImagenes, string descripcion, string ubicacion, string contacto, string usuario, string categoria)
        {
            Titulo = titulo;
            Precio = precio; 
            RutasImagenes = rutasImagenes ?? new List<string>();
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            Tipo = "Servicio";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now;
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }
    }
}