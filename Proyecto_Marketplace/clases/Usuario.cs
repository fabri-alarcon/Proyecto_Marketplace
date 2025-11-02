using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Marketplace.clases
{
    public class Usuario
    {
        // --- PROPIEDADES ---
        private string nombreUsuario;
        private string contraseña;
        public string contacto { get; set; }
        private string RutaFoto;
        public string Rol { get; set; }
        public string Cuil { get; set; }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        // --- CONSTRUCTORES ---

        // 1. Constructor Vacío (OBLIGATORIO para Newtonsoft.Json)
        public Usuario()
        {
            // Dejar vacío.
        }

        // 2. Constructor para "Invitado"
        public Usuario(string nom)
        {
            nombreUsuario = nom;
            Rol = (nom == "Invitado") ? "Invitado" : "Usuario";
            contacto = "";
            Cuil = "";
        }

        // 3. Constructor principal para el Registro (FormRegistrar)
        public Usuario(string nombre, string pass, string contactoUsuario, string cuilUsuario)
        {
            nombreUsuario = nombre;
            contraseña = pass;
            contacto = contactoUsuario;
            Cuil = cuilUsuario;
            RutaFoto = "";
            Rol = "Usuario";
        }

        // --- MÉTODOS ---

        // (Tuve que renombrar 'ObtenerRutaFotoPerfil' y 'CambiarRutaFotoPerfil' para 
        //  que coincidan con tu 'FormProfile.cs' que los llama 'obtener...' y 'cambiar...')
        public string cambiarRutaFotoPerfil(string nuevaRuta)
        {
            RutaFoto = nuevaRuta;
            return RutaFoto;
        }

        public string obtenerRutaFotoPerfil()
        {
            return RutaFoto;
        }

        public bool ValidarLogin(string nombre, string pass)
        {
            return nombre == nombreUsuario && pass == contraseña;
        }
    }
}