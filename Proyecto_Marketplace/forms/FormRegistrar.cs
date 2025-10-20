using Proyecto_Marketplace.clases;


namespace Proyecto_Marketplace.forms
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();

            //Control de tamaño de la ventana formregistrar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bordes fijos
            this.MaximizeBox = false; // Deshabilita el botón maximizar
            this.MinimizeBox = true; // Puedes dejar minimizar si quieres
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrada
            this.Size = new Size(600, 400); // Tamaño fijo de la ventana

        }

        public void botonCancelarReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void botonConfirmarReg_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textRegUsuario.Text.Trim();
            string contrasenia = textRegContrasenia.Text;
            string confirmarContrasenia = textRegConfirmarContrasenia.Text;
            // Validaciones básicas
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si el usuario ya existe
            var usuarioExistente = RepositorioUsuarios.BuscarPorNombre(nombreUsuario);
            if (usuarioExistente != null)
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear y guardar el nuevo usuario
            Usuario nuevoUsuario = new Usuario(nombreUsuario, contrasenia);
            RepositorioUsuarios.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}
