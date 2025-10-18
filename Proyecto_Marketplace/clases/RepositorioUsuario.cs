using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Proyecto_Marketplace.clases
{
    public static class RepositorioUsuarios
    {
        // Ruta donde se guardará el archivo JSON con todos los usuarios
        private static readonly string rutaArchivo = Path.Combine(System.Windows.Forms.Application.StartupPath, "usuarios.json");

        // Lista en memoria para evitar leer el archivo todo el tiempo
        private static List<Usuario> usuariosEnMemoria = null;

        // Carga los usuarios desde el archivo si todavía no se cargaron
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

        // Guarda todos los usuarios en el archivo JSON
        private static void GuardarTodo()
        {
            string json = JsonConvert.SerializeObject(usuariosEnMemoria, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        // Devuelve todos los usuarios
        public static IEnumerable<Usuario> ObtenerTodos()
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria;
        }

        // Busca un usuario por su nombre
        public static Usuario BuscarPorNombre(string nombre)
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria.FirstOrDefault(u => u.NombreUsuario.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
        }

        // Agrega un nuevo usuario, si no existe otro con el mismo nombre
        public static bool AgregarUsuario(Usuario u)
        {
            CargarSiEsNecesario();
            if (BuscarPorNombre(u.NombreUsuario) != null)
                return false;

            usuariosEnMemoria.Add(u);
            GuardarTodo();
            return true;
        }

        // Actualiza los datos de un usuario (por ejemplo, su foto)
        public static bool ActualizarUsuario(Usuario u)
        {
            CargarSiEsNecesario();
            var existente = BuscarPorNombre(u.NombreUsuario);
            if (existente == null) return false;

            existente.Contraseña = u.Contraseña;
            existente.cambiarRutaFotoPerfil(u.obtenerRutaFotoPerfil());
            GuardarTodo();
            return true;
        }
    }
}
