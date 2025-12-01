using Proyecto_Marketplace.clases;

namespace Proyecto_Marketplace.forms
{
    public partial class Verificación : Form
    {
        private string codigoCorrecto;
        private Usuario usuarioAVerificar;

        public Verificación(string codigo, Usuario usuario)
        {
            InitializeComponent();
            codigoCorrecto = codigo;
            usuarioAVerificar = usuario;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == codigoCorrecto)
            {
                //Código correcto
                usuarioAVerificar.IsEmailVerified = true;

                RepositorioUsuarios.ActualizarUsuario(usuarioAVerificar);

                MessageBox.Show("¡Email verificado con éxito! Ahora puedes iniciar sesión.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cierro este formulario y el de Registro
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
   
            else
            {
                // Código incorrecto
                MessageBox.Show("El código es incorrecto. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}