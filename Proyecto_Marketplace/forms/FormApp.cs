using Proyecto_Marketplace.clases;
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
            flowPanel.Height = 500; // Altura del área disponible
            flowPanel.Left = 90;    // Distancia desde el borde izquierdo de la ventana
            flowPanel.Top = 80;     // Distancia desde el borde superior de la ventana (por ejemplo, debajo de un menú o header)
            flowPanel.AutoScroll = true;
            flowPanel.Margin = new Padding(50);
            flowPanel.WrapContents = true;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;

            this.Controls.Add(flowPanel);



            // carga de Publicaciones default
            List<Publicacion> listaPublicacion = new List<Publicacion>();
            Publicacion post1 = new Publicacion("Auriculares Inalámbricos", "232", "fdsfdsf", Image.FromFile("media/auricularesImagen.jpeg"), "43232", "dnsaid", "Disponible");
            Publicacion post2 = new Publicacion("Auriculares Inalámbricos", "232", "fdsfdsf", Image.FromFile("media/auricularesImagen.jpeg"), "43232", "dnsaid", "Vendido");
            Publicacion post3 = new Publicacion("Auriculares Inalámbricos", "232", "fdsfdsf", Image.FromFile("media/auricularesImagen.jpeg"), "43232", "dnsaid", "Pendiente");
            Publicacion post4 = new Publicacion("Auriculares Inalámbricos", "232", "fdsfdsf", Image.FromFile("media/auricularesImagen.jpeg"), "43232", "dnsaid", "Disponible");
          
            listaPublicacion.Add(post1);
            listaPublicacion.Add(post2);
            listaPublicacion.Add(post3);
            listaPublicacion.Add(post4);


            // Crear posts dinámicamente, Image imagen , Image.FromFile("img1.jpg")
            foreach (var publicacion in listaPublicacion)
            {
                //Crear un panel para cada publicación
                Panel post = new Panel();
                post.Width = 200;
                post.Height = 250;
                post.Margin = new Padding(10);
                post.BackColor = Color.White;
                post.BorderStyle = BorderStyle.FixedSingle;

         // Agregar controles al panel

                //imagen parametros
                PictureBox pb = new PictureBox();
                pb.Image = publicacion.Imagen;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Width = 180; //anchu
                pb.Height = 170;//alto
                pb.Top = 20; //borde supperior
                pb.Left = 10; //borde izquierdo

                //titulo parametros
                Label lblTitulo = new Label();
                lblTitulo.Text = publicacion.Titulo;
                lblTitulo.Top = 170;
                lblTitulo.Left = 10;
                lblTitulo.Width = 180;
                lblTitulo.Font = new Font("Arial", 10, FontStyle.Bold);

                //precio parametros
                Label lblPrecio = new Label();
                lblPrecio.Text = "$" + publicacion.Precio;
                lblPrecio.Top = 200;
                lblPrecio.Left = 10;
                lblPrecio.Width = 180;
                lblPrecio.Font = new Font("Arial", 9, FontStyle.Regular);
                lblPrecio.ForeColor = Color.Green;

                //estado parametros
                Label lblEstado = new Label();
                lblEstado.Text = publicacion.Estado;
                lblEstado.Top = 220;
                lblEstado.Left = 10;
                lblEstado.Width = 180;
                lblEstado.Font = new Font("Arial", 9, FontStyle.Regular);

                // Cambiar color según el estado
                if (publicacion.Estado == "Disponible")
                    lblEstado.ForeColor = Color.Green; //objeto.ForeColor = Color.ColorNAme; es para cambiar el color de la letra
                else if (publicacion.Estado == "Vendido")
                    lblEstado.ForeColor = Color.Red;
                else
                    lblEstado.ForeColor = Color.Yellow; //Si esta en Pendiente;


                // Agregar controles al panel de la publicación
                post.Controls.Add(pb); 
                post.Controls.Add(lblTitulo);
                post.Controls.Add(lblPrecio);
                post.Controls.Add(lblEstado);

                // Agregar el panel de la publicación al FlowLayoutPanel
                flowPanel.Controls.Add(post);
            }

        }
    }
}
