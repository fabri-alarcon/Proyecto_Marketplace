using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// (Tuve que quitar "using System.Xml;" porque no se usaba)
namespace Proyecto_Marketplace.clases
{
    public static class RepositorioUsuarios
    {
        private static readonly string rutaArchivo = Path.Combine(System.Windows.Forms.Application.StartupPath, "usuarios.json");
        private static List<Usuario> usuariosEnMemoria = null;

        private static void CargarSiEsNecesario()
        {
            if (usuariosEnMemoria != null) return;

            if (!File.Exists(rutaArchivo))
            {
                usuariosEnMemoria = new List<Usuario>();
                GuardarTodo();
            }
            else
            {
                string json = File.ReadAllText(rutaArchivo);
                usuariosEnMemoria = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }
        }

        private static void GuardarTodo()
        {
            string json = JsonConvert.SerializeObject(usuariosEnMemoria, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        public static IEnumerable<Usuario> ObtenerTodos()
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria;
        }

        public static Usuario BuscarPorNombre(string nombre)
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria.FirstOrDefault(u => u.NombreUsuario.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
        }

        public static bool AgregarUsuario(Usuario u)
        {
            CargarSiEsNecesario();
            if (BuscarPorNombre(u.NombreUsuario) != null)
                return false;

            usuariosEnMemoria.Add(u);
            GuardarTodo();
            return true;
        }

        public static bool ActualizarUsuario(Usuario u)
        {
            CargarSiEsNecesario();
            var existente = BuscarPorNombre(u.NombreUsuario);
            if (existente == null)
                return false;

            existente.Contraseña = u.Contraseña;
            existente.contacto = u.contacto;
            existente.Rol = u.Rol;
            existente.Cuil = u.Cuil; // <-- ESTA LÍNEA FALTABA EN TU CÓDIGO
            existente.cambiarRutaFotoPerfil(u.obtenerRutaFotoPerfil());
            GuardarTodo();
            return true;
        }
    }
}