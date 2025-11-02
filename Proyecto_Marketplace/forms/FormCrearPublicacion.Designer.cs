namespace Proyecto_Marketplace.forms
{
    partial class FormCrearPublicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxPrecio = new TextBox();
            textBoxDescripcion = new TextBox();
            botonPublicar = new Button();
            botonVolverAtras = new Button();
            radioButtonServicio = new RadioButton();
            radioButtonProducto = new RadioButton();
            pictureBoxPublicacion = new PictureBox();
            botonSeleccionarImagen = new Button();
            botonEliminarFoto = new Button();
            comboCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublicacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(45, 68);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(119, 64);
            textBoxTitulo.Margin = new Padding(3, 4, 3, 4);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(377, 27);
            textBoxTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 228);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(45, 128);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(45, 304);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 3;
            label4.Text = "Descripcion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(666, 308);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(45, 192);
            label6.Name = "label6";
            label6.Size = new Size(203, 28);
            label6.TabIndex = 4;
            label6.Text = "Tipo de Publicacion:";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(122, 131);
            textBoxPrecio.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.Size = new Size(114, 27);
            textBoxPrecio.TabIndex = 5;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(45, 340);
            textBoxDescripcion.Margin = new Padding(3, 4, 3, 4);
            textBoxDescripcion.MaxLength = 600;
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(430, 224);
            textBoxDescripcion.TabIndex = 6;
            // 
            // botonPublicar
            // 
            botonPublicar.Location = new Point(695, 535);
            botonPublicar.Margin = new Padding(3, 4, 3, 4);
            botonPublicar.Name = "botonPublicar";
            botonPublicar.Size = new Size(86, 31);
            botonPublicar.TabIndex = 10;
            botonPublicar.Text = "Publicar";
            botonPublicar.UseVisualStyleBackColor = true;
            botonPublicar.Click += botonPublicar_Click_1;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(787, 535);
            botonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(86, 31);
            botonVolverAtras.TabIndex = 14;
            botonVolverAtras.Text = "Volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // radioButtonServicio
            // 
            radioButtonServicio.AutoSize = true;
            radioButtonServicio.ForeColor = SystemColors.Control;
            radioButtonServicio.Location = new Point(263, 196);
            radioButtonServicio.Margin = new Padding(3, 4, 3, 4);
            radioButtonServicio.Name = "radioButtonServicio";
            radioButtonServicio.Size = new Size(82, 24);
            radioButtonServicio.TabIndex = 15;
            radioButtonServicio.TabStop = true;
            radioButtonServicio.Text = "Servicio";
            radioButtonServicio.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducto
            // 
            radioButtonProducto.AutoSize = true;
            radioButtonProducto.ForeColor = SystemColors.Control;
            radioButtonProducto.Location = new Point(381, 192);
            radioButtonProducto.Margin = new Padding(3, 4, 3, 4);
            radioButtonProducto.Name = "radioButtonProducto";
            radioButtonProducto.Size = new Size(90, 24);
            radioButtonProducto.TabIndex = 16;
            radioButtonProducto.TabStop = true;
            radioButtonProducto.Text = "Producto";
            radioButtonProducto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPublicacion
            // 
            pictureBoxPublicacion.Location = new Point(627, 64);
            pictureBoxPublicacion.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPublicacion.Name = "pictureBoxPublicacion";
            pictureBoxPublicacion.Size = new Size(246, 268);
            pictureBoxPublicacion.TabIndex = 17;
            pictureBoxPublicacion.TabStop = false;
            // 
            // botonSeleccionarImagen
            // 
            botonSeleccionarImagen.Location = new Point(627, 340);
            botonSeleccionarImagen.Margin = new Padding(3, 4, 3, 4);
            botonSeleccionarImagen.Name = "botonSeleccionarImagen";
            botonSeleccionarImagen.Size = new Size(119, 31);
            botonSeleccionarImagen.TabIndex = 18;
            botonSeleccionarImagen.Text = "Seleccionar Imagen";
            botonSeleccionarImagen.UseVisualStyleBackColor = true;
            botonSeleccionarImagen.Click += botonSeleccionarImagen_Click_1;
            // 
            // botonEliminarFoto
            // 
            botonEliminarFoto.Location = new Point(753, 340);
            botonEliminarFoto.Margin = new Padding(3, 4, 3, 4);
            botonEliminarFoto.Name = "botonEliminarFoto";
            botonEliminarFoto.Size = new Size(120, 31);
            botonEliminarFoto.TabIndex = 19;
            botonEliminarFoto.Text = "Eliminar Foto";
            botonEliminarFoto.UseVisualStyleBackColor = true;
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(45, 251);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(158, 28);
            comboCategoria.TabIndex = 20;
            comboCategoria.Text = "Categoría";
            // 
            // FormCrearPublicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(914, 600);
            Controls.Add(comboCategoria);
            Controls.Add(botonEliminarFoto);
            Controls.Add(botonSeleccionarImagen);
            Controls.Add(pictureBoxPublicacion);
            Controls.Add(radioButtonProducto);
            Controls.Add(radioButtonServicio);
            Controls.Add(botonVolverAtras);
            Controls.Add(botonPublicar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxPrecio);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxTitulo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCrearPublicacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Publicaciones";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPublicacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxPrecio;
        private TextBox textBoxDescripcion;
        private Button botonPublicar;
        private Button botonVolverAtras;
        private RadioButton radioButtonServicio;
        private RadioButton radioButtonProducto;
        private PictureBox pictureBoxPublicacion;
        private Button botonSeleccionarImagen;
        private Button botonEliminarFoto;
        private ComboBox comboCategoria;
    }
}