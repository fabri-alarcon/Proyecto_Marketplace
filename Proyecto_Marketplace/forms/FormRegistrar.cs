using Proyecto_Marketplace.clases; // <-- ESTA LÍNEA ES LA SOLUCIÓN

namespace Proyecto_Marketplace.forms
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(600, 550);
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
            string contacto = textContacto.Text.Trim();
            string cuil = textCuil.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia) ||
                string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(cuil))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(contacto, out _) || !long.TryParse(cuil, out _))
            {
                MessageBox.Show("El Contacto y el CUIL deben ser solo números, sin guiones ni espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ahora sí encontrará la clase "RepositorioUsuarios"
            var usuarioExistente = RepositorioUsuarios.BuscarPorNombre(nombreUsuario);
            if (usuarioExistente != null)
            {
                MessageBox.Show("El nombre de usuario ya está en uso. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario nuevoUsuario = new Usuario(nombreUsuario, contrasenia, contacto, cuil);

            RepositorioUsuarios.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Registro exitoso. Ahora puede iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}