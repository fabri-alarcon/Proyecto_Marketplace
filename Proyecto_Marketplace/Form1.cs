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

        // BOT�N: INICIAR SESI�N
        private void button1_Click(object sender, EventArgs e)
        {
            string user = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario:", "Login", "juan");
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Ingrese contrase�a:", "Login", "1234");

            Vendedor v = new Vendedor("juan", "1234", "juan@mail.com");

            if (v.ValidarLogin(user, pass))
            {
                vendedorActual = v;
                usuarioLogueado = true;
                MessageBox.Show($"Bienvenido {v.NombreUsuario}! Ahora pod�s publicar tus servicios.");
                label1.Text = "Sesi�n iniciada como vendedor";
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
            }
        }

        // BOT�N: REGISTRARSE
        private void button2_Click(object sender, EventArgs e)
        {
            string user = Microsoft.VisualBasic.Interaction.InputBox("Nuevo nombre de usuario:", "Registro");
            string pass = Microsoft.VisualBasic.Interaction.InputBox("Contrase�a:", "Registro");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Email:", "Registro");

            vendedorActual = new Vendedor(user, pass, email);
            usuarioLogueado = true;
            MessageBox.Show($"Usuario registrado con �xito: {user}");
        }

        // BOT�N: CONTINUAR COMO INVITADO
        private void button3_Click(object sender, EventArgs e)
        {
            usuarioLogueado = false;
            MessageBox.Show("Entraste como invitado. Solo pod�s ver publicaciones.");
            label1.Text = "Modo invitado";
        }

        // M�todo auxiliar para crear publicaci�n (solo si logueado)
        private void CrearPublicacion()
        {
            if (!usuarioLogueado)
            {
                MessageBox.Show("Ten�s que iniciar sesi�n para publicar.");
                return;
            }

            string titulo = Microsoft.VisualBasic.Interaction.InputBox("T�tulo de la publicaci�n:");
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Descripci�n:");
            string img = Microsoft.VisualBasic.Interaction.InputBox("URL o ruta de la imagen:");
            string contacto = Microsoft.VisualBasic.Interaction.InputBox("N�mero de WhatsApp (ej: 5493624000000):");

            Publicacion pub = new Publicacion(titulo, desc, img, contacto);
            publicaciones.Add(pub);
            vendedorActual.AgregarPublicacion(pub);

            MessageBox.Show($"Publicaci�n creada:\n{pub.Titulo}\n{pub.Descripcion}\n{pub.ContactoWhatsApp}");
        }
    }
}
