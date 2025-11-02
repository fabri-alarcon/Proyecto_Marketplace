namespace Proyecto_Marketplace.forms
{
    partial class FormPublicacion
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
            labelTitulo = new Label();
            labelTipo = new Label();
            labelDescripcion = new Label();
            labelPrecio = new Label();
            labelUsuario = new Label();
            pictureBoxImagenPubli = new PictureBox();
            botonEnviarMensaje = new Button();
            botonVolverAtras = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelFechaPublicacion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenPubli).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.Control;
            labelTitulo.Location = new Point(298, 43);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(76, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "titulo";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.ForeColor = SystemColors.Control;
            labelTipo.Location = new Point(297, 193);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(87, 21);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "valor_tipo";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = SystemColors.Control;
            labelDescripcion.Location = new Point(27, 292);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 23);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "descripcion";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = SystemColors.Control;
            labelPrecio.Location = new Point(296, 144);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(104, 21);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "valor_precio";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ControlLight;
            labelUsuario.Location = new Point(296, 96);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(132, 25);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "valor_usuario";
            // 
            // pictureBoxImagenPubli
            // 
            pictureBoxImagenPubli.Location = new Point(27, 24);
            pictureBoxImagenPubli.Name = "pictureBoxImagenPubli";
            pictureBoxImagenPubli.Size = new Size(251, 229);
            pictureBoxImagenPubli.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenPubli.TabIndex = 4;
            pictureBoxImagenPubli.TabStop = false;
            // 
            // botonEnviarMensaje
            // 
            botonEnviarMensaje.Location = new Point(448, 415);
            botonEnviarMensaje.Name = "botonEnviarMensaje";
            botonEnviarMensaje.Size = new Size(124, 34);
            botonEnviarMensaje.TabIndex = 5;
            botonEnviarMensaje.Text = "enviar mensaje";
            botonEnviarMensaje.UseVisualStyleBackColor = true;
            botonEnviarMensaje.Click += botonEnviarMensaje_Click;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(12, 415);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(124, 34);
            botonVolverAtras.TabIndex = 6;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(297, 75);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 7;
            label1.Text = "PUBLICADO POR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(297, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 8;
            label2.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(297, 172);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 9;
            label3.Text = "TIPO";
            // 
            // labelFechaPublicacion
            // 
            labelFechaPublicacion.AutoSize = true;
            labelFechaPublicacion.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelFechaPublicacion.ForeColor = SystemColors.ControlLight;
            labelFechaPublicacion.Location = new Point(27, 265);
            labelFechaPublicacion.Name = "labelFechaPublicacion";
            labelFechaPublicacion.Size = new Size(63, 13);
            labelFechaPublicacion.TabIndex = 10;
            labelFechaPublicacion.Text = "valor_fecha";
            // 
            // FormPublicacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(584, 461);
            Controls.Add(labelFechaPublicacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonVolverAtras);
            Controls.Add(botonEnviarMensaje);
            Controls.Add(pictureBoxImagenPubli);
            Controls.Add(labelUsuario);
            Controls.Add(labelPrecio);
            Controls.Add(labelDescripcion);
            Controls.Add(labelTipo);
            Controls.Add(labelTitulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPublicacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publicacion";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenPubli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelTipo;
        private Label labelDescripcion;
        private Label labelPrecio;
        private Label labelUsuario;
        private PictureBox pictureBoxImagenPubli;
        private Button botonEnviarMensaje;
        private Button botonVolverAtras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelFechaPublicacion;
    }
}