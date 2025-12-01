using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System; // Agregado para StringComparison

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
            existente.Cuil = u.Cuil;
            existente.IsEmailVerified = u.IsEmailVerified; // <-- ¡IMPORTANTE! Asegurarnos de guardar esto
            existente.cambiarRutaFotoPerfil(u.obtenerRutaFotoPerfil());
            GuardarTodo();
            return true;
        }

        // --- ¡NUEVOS MÉTODOS DE VALIDACIÓN! ---

        /// <summary>
        /// Comprueba si un email ya existe en la base de datos.
        /// </summary>
        public static bool ExisteEmail(string email)
        {
            CargarSiEsNecesario();
            // .Any() es más rápido que .FirstOrDefault() para solo comprobar existencia
            return usuariosEnMemoria.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Comprueba si un CUIL ya existe en la base de datos.
        /// </summary>
        public static bool ExisteCuil(string cuil)
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria.Any(u => u.Cuil == cuil);
        }

        /// <summary>
        /// Comprueba si un número de contacto ya existe en la base de datos.
        /// </summary>
        public static bool ExisteContacto(string contacto)
        {
            CargarSiEsNecesario();
            return usuariosEnMemoria.Any(u => u.contacto == contacto);
        }

        public static bool EliminarUsuario(Usuario u)
        {
            CargarSiEsNecesario();
            // RemoveAll devuelve el número de elementos eliminados
            int eliminados = usuariosEnMemoria.RemoveAll(
                user => user.NombreUsuario.Equals(u.NombreUsuario, System.StringComparison.OrdinalIgnoreCase)
            );

            if (eliminados > 0)
            {
                GuardarTodo();
                return true;
            }
            return false;
        }
    }
}