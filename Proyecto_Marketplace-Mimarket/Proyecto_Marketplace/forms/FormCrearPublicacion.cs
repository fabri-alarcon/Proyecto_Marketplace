using Proyecto_Marketplace.clases;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Proyecto_Marketplace.forms
{
    public partial class FormCrearPublicacion : Form
    {
        private RepositorioPublicaciones repoPublicaciones;
        private Usuario usuarioActual;

        private List<string> rutasImagenesSeleccionadas = new List<string>();
        private int indiceImagenActual = 0; //para el indice de cada imagen

        public FormCrearPublicacion(Usuario usuarioActual, RepositorioPublicaciones repoPublicaciones)
        {
            InitializeComponent();
            this.repoPublicaciones = repoPublicaciones;
            this.usuarioActual = usuarioActual;
            this.Size = new Size(816, 489);

            //Carga de ComboBox de Categorías
            comboCategoria.Items.Add("Tecnología");
            comboCategoria.Items.Add("Hogar y Muebles");
            comboCategoria.Items.Add("Indumentaria");
            comboCategoria.Items.Add("Deporte");
            comboCategoria.Items.Add("Vehiculos");
            comboCategoria.Items.Add("Otros");
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.SelectedIndex = 0;
        }

        private void botonPublicar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                MessageBox.Show("El Título y la Descripción son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string precioParaGuardar = "0"; // Valor por defecto si está vacío

            if (!string.IsNullOrWhiteSpace(textBoxPrecio.Text))
            {
                if (!decimal.TryParse(textBoxPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (precio < 0)
                {
                    MessageBox.Show("El precio no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si es válido y no está vacío, usamos el texto del input
                precioParaGuardar = textBoxPrecio.Text;
            }

            // para los radio buttoms
            string categoriaSeleccionada = comboCategoria.SelectedItem.ToString();
            string tipo = radioButtonProducto.Checked ? "Producto" : "Servicio";

            Publicacion nueva;
            if (tipo == "Producto")
            {

                nueva = new Publicacion(
                    textBoxTitulo.Text,
                    precioParaGuardar, // Usa el precio validado
                    textBoxDescripcion.Text,
                    rutasImagenesSeleccionadas,
                    usuarioActual.NombreUsuario,
                    usuarioActual.contacto,
                    "Disponible",
                    usuarioActual.NombreUsuario,
                    categoriaSeleccionada
                );
            }
            else
            {

                nueva = new Publicacion(
                    textBoxTitulo.Text,
                    precioParaGuardar,
                    rutasImagenesSeleccionadas,
                    textBoxDescripcion.Text,
                    usuarioActual.NombreUsuario,
                    usuarioActual.contacto,
                    usuarioActual.NombreUsuario,
                    categoriaSeleccionada
                );

            }

            repoPublicaciones.AgregarPublicacion(nueva);
            repoPublicaciones.GuardarPublicaciones();

            MessageBox.Show("Publicación creada. Pasará a moderación antes de ser visible.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void MostrarImagenActual()
        {
            if (rutasImagenesSeleccionadas.Count == 0)
            {
                if (pictureBoxPublicacion.Image != null)
                {
                    pictureBoxPublicacion.Image.Dispose();
                    pictureBoxPublicacion.Image = null;
                }
                return;
            }

            if (indiceImagenActual >= rutasImagenesSeleccionadas.Count)
                indiceImagenActual = rutasImagenesSeleccionadas.Count - 1;

            if (indiceImagenActual < 0)
                indiceImagenActual = 0;

            using (var fs = new FileStream(rutasImagenesSeleccionadas[indiceImagenActual], FileMode.Open, FileAccess.Read))
            {
                pictureBoxPublicacion.Image = new Bitmap(fs);
            }

            label7.Text = $"Imagen {indiceImagenActual + 1} de {rutasImagenesSeleccionadas.Count}";
        }
        
           
        










        private void botonSeleccionarImagen_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Seleccionar foto(s) de Publicación";
                dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                // Permitir la selección de múltiples archivos
                dialogo.Multiselect = true;

                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    string carpetaFotos = Path.Combine(Application.StartupPath, "FotosPublicacion");
                    if (!Directory.Exists(carpetaFotos))
                        Directory.CreateDirectory(carpetaFotos);

                    rutasImagenesSeleccionadas.Clear();

                    if (pictureBoxPublicacion.Image != null)
                    {
                        pictureBoxPublicacion.Image.Dispose();
                        pictureBoxPublicacion.Image = null;
                    }


                    if(dialogo.FileNames.Length > 10)
                    {
                        pictureBoxPublicacion.Image = Properties.Resources.predeterminado_de_publicaciones;
                        MessageBox.Show("Solo se permiten seleccionar hasta 10 imágenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //Iteramos sobre todos los archivos seleccionados
                    foreach (string rutaOriginal in dialogo.FileNames)
                    {
                        string nombreArchivo = $"{Guid.NewGuid()}{Path.GetExtension(rutaOriginal)}";
                        string rutaDestino = Path.Combine(carpetaFotos, nombreArchivo);

                        // Copiamos el archivo al directorio local
                        File.Copy(rutaOriginal, rutaDestino, true);
                        rutasImagenesSeleccionadas.Add(rutaDestino);
                    }

                    //Mostramos la primera imagen de la lista en el picturebox de previsualizacion
                    if (rutasImagenesSeleccionadas.Count > 0)
                    {
                        using (var fs = new FileStream(rutasImagenesSeleccionadas[0], FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxPublicacion.Image = new Bitmap(fs);
                        }
                    }
                    label7.Text = $"Imagen {indiceImagenActual + 1} de {rutasImagenesSeleccionadas.Count}"; //actualizar label
                    MessageBox.Show($"Se cargaron {rutasImagenesSeleccionadas.Count} imagen(es) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private void botonVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonEliminarFoto_Click(object sender, EventArgs e)
        {
            // Si no hay imágenes cargadas -> simplemente no eliminar nada
            if (rutasImagenesSeleccionadas.Count == 0)
            {
                MessageBox.Show("No hay imágenes para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener la ruta que vamos a eliminar
            string rutaAEliminar = rutasImagenesSeleccionadas[indiceImagenActual];

            // Eliminar de la lista
            rutasImagenesSeleccionadas.RemoveAt(indiceImagenActual);

            // Eliminar del disco (opcional)
            try
            {
                if (File.Exists(rutaAEliminar))
                    File.Delete(rutaAEliminar);
            }
            catch { }

            //Ajustar índice
            if (indiceImagenActual >= rutasImagenesSeleccionadas.Count)
                indiceImagenActual = rutasImagenesSeleccionadas.Count - 1;

            label7.Text = $"Imagen {indiceImagenActual + 1} de {rutasImagenesSeleccionadas.Count}";//actualizar label

            // Si NO quedaron imágenes, mostrar la imagen por defecto
            if (rutasImagenesSeleccionadas.Count == 0)
            {
                if (pictureBoxPublicacion.Image != null)
                {
                    pictureBoxPublicacion.Image.Dispose();
                }

                label7.Text = " ";

                // Mostrar imagen por defecto 
                pictureBoxPublicacion.Image = Properties.Resources.predeterminado_de_publicaciones; 
                return;
            }

            // 5. Si quedaban imágenes, mostrar la siguiente correcta
            using (var fs = new FileStream(rutasImagenesSeleccionadas[indiceImagenActual], FileMode.Open, FileAccess.Read))
            {
                pictureBoxPublicacion.Image = new Bitmap(fs);
            }

            MessageBox.Show("Imagen eliminada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (rutasImagenesSeleccionadas.Count == 0) return;

            indiceImagenActual--;
            if (indiceImagenActual < 0)
                indiceImagenActual = rutasImagenesSeleccionadas.Count - 1; // Va al final

            MostrarImagenActual();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (rutasImagenesSeleccionadas.Count == 0) return;

            indiceImagenActual++;
            if (indiceImagenActual >= rutasImagenesSeleccionadas.Count)
                indiceImagenActual = 0; // Vuelve al inicio

            MostrarImagenActual();
        }

        
    }
}