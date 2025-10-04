using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Marketplace
{
    public partial class Form1 : Form
    {
        private List<Publicacion> publicaciones = new List<Publicacion>();
        private Vendedor vendedorActual;
        private bool usuarioLogueado = false;

        public Form1()
        {
            InitializeComponent();
        }

        // BOTÓN: INICIAR SESIÓN
        private void button1_Click(object sender, EventArgs e)
        {
            string user = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario:", "Login", "juan");
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Ingrese contraseña:", "Login", "1234");

            Vendedor v = new Vendedor("juan", "1234", "juan@mail.com");

            if (v.ValidarLogin(user, pass))
            {
                vendedorActual = v;
                usuarioLogueado = true;
                MessageBox.Show($"Bienvenido {v.NombreUsuario}! Ahora podés publicar tus servicios.");
                label1.Text = "Sesión iniciada como vendedor";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        // BOTÓN: REGISTRARSE
        private void button2_Click(object sender, EventArgs e)
        {
            string user = Microsoft.VisualBasic.Interaction.InputBox("Nuevo nombre de usuario:", "Registro");
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Contraseña:", "Registro");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email:", "Registro");

            vendedorActual = new Vendedor(user, pass, email);
            usuarioLogueado = true;
            MessageBox.Show($"Usuario registrado con éxito: {user}");
        }

        // BOTÓN: CONTINUAR COMO INVITADO
        private void button3_Click(object sender, EventArgs e)
        {
            usuarioLogueado = false;
            MessageBox.Show("Entraste como invitado. Solo podés ver publicaciones.");
            label1.Text = "Modo invitado";
        }

        // Método auxiliar para crear publicación (solo si logueado)
        private void CrearPublicacion()
        {
            if (!usuarioLogueado)
            {
                MessageBox.Show("Tenés que iniciar sesión para publicar.");
                return;
            }

            string titulo = Microsoft.VisualBasic.Interaction.InputBox("Título de la publicación:");
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Descripción:");
            string img = Microsoft.VisualBasic.Interaction.InputBox("URL o ruta de la imagen:");
            string contacto = Microsoft.VisualBasic.Interaction.InputBox("Número de WhatsApp (ej: 5493624000000):");

            Publicacion pub = new Publicacion(titulo, desc, img, contacto);
            publicaciones.Add(pub);
            vendedorActual.AgregarPublicacion(pub);

            MessageBox.Show($"Publicación creada:\n{pub.Titulo}\n{pub.Descripcion}\n{pub.ContactoWhatsApp}");
        }
    }
}
