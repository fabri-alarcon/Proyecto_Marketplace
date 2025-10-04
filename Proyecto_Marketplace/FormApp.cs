using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Marketplace
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();

            //Control de tamaño de la ventana formapp
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordes fijos
            this.MaximizeBox = false; // Deshabilita el botón maximizar
            this.MinimizeBox = true; // Puedes dejar minimizar si quieres
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrada
            this.Size = new Size(800, 600); // Tamaño fijo de la ventana






            // Crear FlowLayoutPanel, es un ontenedor especial que organiza automáticamente los controles que
            // le agregas en flujo es decir, uno tras otro, como si fueran palabras en un texto.

            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Width = 760;  // Ancho del área disponible
            flowPanel.Height = 500; // Alto del área disponible
            flowPanel.Left = 90;    // Distancia desde el borde izquierdo de la ventana
            flowPanel.Top = 80;     // Distancia desde el borde superior de la ventana (por ejemplo, debajo de un menú o header)
            flowPanel.AutoScroll = true;
            flowPanel.Margin = new Padding(50);
            flowPanel.WrapContents = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;

            this.Controls.Add(flowPanel);



            // Simular Publicacion
            List<Publicacion> listaPublicacion = new List<Publicacion>();
            Publicacion post1 = new Publicacion("Auriculares Inalámbricos", "fdsfdsf", "232", "43232", "dnsaid");
            Publicacion post2 = new Publicacion("Auriculares Inalámbricos", "fdsfdsf", "232", "43232", "dnsaid");
            Publicacion post3 = new Publicacion("Auriculares Inalámbricos", "fdsfdsf", "232", "43232", "dnsaid");
            Publicacion post4 = new Publicacion("Auriculares Inalámbricos", "fdsfdsf", "232", "43232", "dnsaid");
            listaPublicacion.Add(post1);
            listaPublicacion.Add(post2);
            listaPublicacion.Add(post3);
            listaPublicacion.Add(post4);


            // Crear posts dinámicamente, Image imagen , Image.FromFile("img1.jpg")
            foreach (var publicacion in listaPublicacion)
            {
                Panel post = new Panel();
                post.Width = 200;
                post.Height = 250;
                post.Margin = new Padding(60);
                post.BackColor = Color.White;
                post.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pb = new PictureBox();
                pb.Image = publicacion.Imagen;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Width = 180;
                pb.Height = 150;
                pb.Top = 10;
                pb.Left = 10;

                Label lblTitulo = new Label();
                lblTitulo.Text = publicacion.Titulo;
                lblTitulo.Top = 170;
                lblTitulo.Left = 10;
                lblTitulo.Width = 180;
                lblTitulo.Font = new Font("Arial", 10, FontStyle.Bold);

                Label lblPrecio = new Label();
                lblPrecio.Text = "$" + publicacion.Precio;
                lblPrecio.Top = 200;
                lblPrecio.Left = 10;
                lblPrecio.Width = 180;
                lblPrecio.Font = new Font("Arial", 9, FontStyle.Regular);
                lblPrecio.ForeColor = Color.Green;

                post.Controls.Add(pb);
                post.Controls.Add(lblTitulo);
                post.Controls.Add(lblPrecio);

                flowPanel.Controls.Add(post);
            }

        }
    }
}
