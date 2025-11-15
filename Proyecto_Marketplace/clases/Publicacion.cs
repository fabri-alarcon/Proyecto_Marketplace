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
                // Usa a primeira imagem da lista para a pré-visualização (e.g., PublicacionCard)
                string ruta = RutasImagenes.FirstOrDefault();

                if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
                {
                    string placeholderPath = Path.Combine(Application.StartupPath, "media", "placeholder.png");
                    if (File.Exists(placeholderPath))
                        return Image.FromFile(placeholderPath);
                    return new Bitmap(100, 100);
                }

                try
                {
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
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
        public string EstadoVenta { get; set; } = null!;
        public string EstadoModeracion { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public Publicacion()
        {
        }

        // Construtor Producto (9 argumentos) - Sin cambios
        public Publicacion(string titulo, string precio, string descripcion, List<string> rutasImagenes, string ubicacion, string contacto, string estadoVenta, string usuario, string categoria)
        {
            Titulo = titulo;
            Precio = precio; // <-- Se guarda
            RutasImagenes = rutasImagenes ?? new List<string>();
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            EstadoVenta = estadoVenta;
            Tipo = "Producto";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now;
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }

        // --- INICIO DE CORRECCIÓN ---
        // Construtor de Serviço (Ahora 8 argumentos)
        public Publicacion(string titulo, string precio, List<string> rutasImagenes, string descripcion, string ubicacion, string contacto, string usuario, string categoria)
        {
            Titulo = titulo;
            Precio = precio; // <-- ¡CORREGIDO! Ahora guarda el precio
            RutasImagenes = rutasImagenes ?? new List<string>();
            Descripcion = descripcion;
            Ubicacion = ubicacion;
            Contacto = contacto;
            Tipo = "Servicio";
            UsuarioCreador = usuario;
            FechaPublicacion = DateTime.Now;
            EstadoVenta = "Disponible"; // Los servicios no se "venden"
            EstadoModeracion = "Pendiente";
            Categoria = categoria;
        }
        // --- FIN DE CORRECCIÓN ---
    }
}