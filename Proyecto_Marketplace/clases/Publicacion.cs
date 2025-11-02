using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // Importante para [JsonIgnore]

namespace Proyecto_Marketplace.clases
{
    public class Publicacion
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; } = null!;
        public string RutaImagen { get; set; } = null!;

        [JsonIgnore]
        public Image ImagenCargada
        {
            get
            {
                if (string.IsNullOrEmpty(RutaImagen) || !File.Exists(RutaImagen))
                {
                    string placeholderPath = Path.Combine(Application.StartupPath, "media", "placeholder.png");
                    if (File.Exists(placeholderPath))
                        return Image.FromFile(placeholderPath);
                    return new Bitmap(100, 100); // Evitamos devolver null
                }

                using (var fs = new FileStream(RutaImagen, FileMode.Open, FileAccess.Read))
                {
                    return new Bitmap(fs);
                }
            }
        }

        public string Ubicacion { get; set; }
        public string Contacto { get; set; }
        public string EstadoVenta { get; set; } = null!;
        public string EstadoModeracion { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }

        // --- INICIO DE LA CORRECCIÓN ---
        // Cambiamos 'private set' por 'set' para que JSON pueda escribirlos
        public string UsuarioCreador { get; set; }
        public DateTime FechaPublicacion { get; set; }
        // --- FIN DE LA CORRECCIÓN ---


        // Constructor vacío (default) para que Newtonsoft.Json pueda deserializar
        public Publicacion()
        {

        }

        // Constructor modificado
        public Publicacion(string titulo, string precio, string descripcion, string rutaImagen, string ubicacion, string contacto, string estadoVenta, string usuario, string categoria)
        {
            Titulo = titulo;
            Precio = precio;
            RutaImagen = rutaImagen;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            EstadoVenta = estadoVenta;
            Tipo = "Producto";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now; // Cambiado a .Now para hora local
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }

        // Constructor de Servicio modificado
        public Publicacion(string titulo, string rutaImagen, string descripcion, string ubicacion, string contacto, string usuario, string categoria)
        {
            Titulo = titulo;
            RutaImagen = rutaImagen;
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            Tipo = "Servicio";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now; // Cambiado a .Now para hora local
            EstadoVenta = "Disponible";
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }
    }
}