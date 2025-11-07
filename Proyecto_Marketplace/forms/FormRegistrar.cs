using Proyecto_Marketplace.clases;
using System.Text.RegularExpressions; // Para validar email

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
            this.Size = new Size(600, 600); // (Asegúrate de tener espacio para el campo Email)
        }

        public void botonCancelarReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void botonConfirmarReg_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textRegUsuario.Text.Trim();
            string contrasenia = textRegContrasenia.Text;
            string confirmarContrasenia = textRegConfirmarContrasenia.Text;
            string contacto = textContacto.Text.Trim();
            string cuil = textCuil.Text.Trim();
            string email = txtEmail.Text.Trim();

            // 1. Validaciones de campos vacíos
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia) ||
                string.IsNullOrEmpty(contacto) || string.IsNullOrEmpty(cuil) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error"); return;
            }
            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error"); return;
            }

            // 2. Validaciones de Formato (Regex)
            if (!long.TryParse(contacto, out _) || !long.TryParse(cuil, out _))
            {
                MessageBox.Show("El Contacto y el CUIL deben ser solo números.", "Error"); return;
            }

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, patronEmail))
            {
                MessageBox.Show("El formato del email no es válido.", "Error"); return;
            }

            // --- ¡NUEVAS VALIDACIONES DE DUPLICADOS! ---
            if (RepositorioUsuarios.BuscarPorNombre(nombreUsuario) != null)
            {
                MessageBox.Show("El nombre de usuario ya está en uso.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteEmail(email))
            {
                MessageBox.Show("El email ingresado ya está registrado por otro usuario.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteCuil(cuil))
            {
                MessageBox.Show("El CUIL ingresado ya está registrado por otro usuario.", "Error"); return;
            }

            if (RepositorioUsuarios.ExisteContacto(contacto))
            {
                MessageBox.Show("El número de contacto ya está registrado por otro usuario.", "Error"); return;
            }
            // --- FIN DE NUEVAS VALIDACIONES ---

            // 3. Generar Código y Crear Usuario
            string codigoVerificacion = new Random().Next(100000, 999999).ToString();
            Usuario nuevoUsuario = new Usuario(nombreUsuario, contrasenia, contacto, cuil, email);

            // 4. Guardar Usuario (como NO verificado)
            RepositorioUsuarios.AgregarUsuario(nuevoUsuario);

            // 5. Enviar Email (asíncrono)
            await EmailService.EnviarEmailVerificacion(email, nombreUsuario, codigoVerificacion);

            MessageBox.Show("Registro casi completo. Te hemos enviado un código a tu email. Por favor, ingrésalo para activar tu cuenta.", "Verifica tu Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6. Abrir el formulario de verificación
            this.Hide();
            FormVerificacion formVer = new FormVerificacion(codigoVerificacion, nuevoUsuario);
            DialogResult verificacionResult = formVer.ShowDialog();

            if (verificacionResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Si el usuario cerró la ventana de verificación,
                // el usuario queda guardado pero NO verificado.
                // Mostramos el formulario de registro de nuevo.
                this.Show();
            }
        }
    }
}