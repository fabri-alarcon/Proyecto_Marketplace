namespace Proyecto_Marketplace
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Control de tamaño de la ventana formlogin
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordes fijos
            this.MaximizeBox = false; // Deshabilita el botón maximizar
            this.MinimizeBox = true; // Puedes dejar minimizar si quieres
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrada
            this.Size = new Size(600, 400); // Tamaño fijo de la ventana

        }




        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            // por ahora vacío, después le agregás lógica
        }

        private void botonContinuarInvitado_Click(object sender, EventArgs e)
        {
            FormApp ventanaPrincipal = new FormApp(); 
            this.Hide();                    //ocultar de la ventana actual osea login
            ventanaPrincipal.ShowDialog(); //bloquea el form de login hasta cerrar la ventana principal de la app
            this.Close();                  //cierra la ventana principal de la app
        }




    }
}
