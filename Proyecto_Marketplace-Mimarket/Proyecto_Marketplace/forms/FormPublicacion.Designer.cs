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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPublicacion));
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
            BtnSiguiente = new Button();
            lblContadorImagenes = new Label();
            BtnAnterior = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagenPubli).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.Control;
            labelTitulo.Location = new Point(456, 44);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(96, 41);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "titulo";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.ForeColor = SystemColors.Control;
            labelTipo.Location = new Point(459, 311);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(106, 28);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "valor_tipo";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = SystemColors.Control;
            labelDescripcion.Location = new Point(86, 384);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(123, 29);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "descripcion";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = SystemColors.Control;
            labelPrecio.Location = new Point(458, 223);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(127, 28);
            labelPrecio.TabIndex = 2;
            labelPrecio.Text = "valor_precio";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ControlLight;
            labelUsuario.Location = new Point(456, 131);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(168, 32);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "valor_usuario";
            // 
            // pictureBoxImagenPubli
            // 
            pictureBoxImagenPubli.Location = new Point(86, 32);
            pictureBoxImagenPubli.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagenPubli.Name = "pictureBoxImagenPubli";
            pictureBoxImagenPubli.Size = new Size(287, 305);
            pictureBoxImagenPubli.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagenPubli.TabIndex = 4;
            pictureBoxImagenPubli.TabStop = false;
            // 
            // botonEnviarMensaje
            // 
            botonEnviarMensaje.Location = new Point(725, 553);
            botonEnviarMensaje.Margin = new Padding(3, 4, 3, 4);
            botonEnviarMensaje.Name = "botonEnviarMensaje";
            botonEnviarMensaje.Size = new Size(142, 45);
            botonEnviarMensaje.TabIndex = 5;
            botonEnviarMensaje.Text = "enviar mensaje";
            botonEnviarMensaje.UseVisualStyleBackColor = true;
            botonEnviarMensaje.Click += botonEnviarMensaje_Click;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(14, 553);
            botonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(142, 45);
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
            label1.Location = new Point(457, 103);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 7;
            label1.Text = "PUBLICADO POR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(459, 195);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 8;
            label2.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(459, 281);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 9;
            label3.Text = "TIPO";
            // 
            // labelFechaPublicacion
            // 
            labelFechaPublicacion.AutoSize = true;
            labelFechaPublicacion.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelFechaPublicacion.ForeColor = SystemColors.ControlLight;
            labelFechaPublicacion.Location = new Point(86, 341);
            labelFechaPublicacion.Name = "labelFechaPublicacion";
            labelFechaPublicacion.Size = new Size(82, 17);
            labelFechaPublicacion.TabIndex = 10;
            labelFechaPublicacion.Text = "valor_fecha";
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.BackColor = Color.Transparent;
            BtnSiguiente.BackgroundImage = (Image)resources.GetObject("BtnSiguiente.BackgroundImage");
            BtnSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSiguiente.FlatAppearance.BorderSize = 0;
            BtnSiguiente.FlatStyle = FlatStyle.Flat;
            BtnSiguiente.ForeColor = Color.Transparent;
            BtnSiguiente.Location = new Point(379, 164);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(37, 37);
            BtnSiguiente.TabIndex = 11;
            BtnSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblContadorImagenes
            // 
            lblContadorImagenes.AutoSize = true;
            lblContadorImagenes.BackColor = Color.Transparent;
            lblContadorImagenes.Location = new Point(342, 9);
            lblContadorImagenes.Name = "lblContadorImagenes";
            lblContadorImagenes.Size = new Size(50, 20);
            lblContadorImagenes.TabIndex = 13;
            lblContadorImagenes.Text = "label4";
            // 
            // BtnAnterior
            // 
            BtnAnterior.BackColor = Color.Transparent;
            BtnAnterior.BackgroundImage = (Image)resources.GetObject("BtnAnterior.BackgroundImage");
            BtnAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAnterior.FlatAppearance.BorderSize = 0;
            BtnAnterior.FlatStyle = FlatStyle.Flat;
            BtnAnterior.ForeColor = Color.Transparent;
            BtnAnterior.Location = new Point(42, 164);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(37, 37);
            BtnAnterior.TabIndex = 12;
            BtnAnterior.UseVisualStyleBackColor = false;
            // 
            // FormPublicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(950, 615);
            Controls.Add(lblContadorImagenes);
            Controls.Add(BtnAnterior);
            Controls.Add(BtnSiguiente);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button BtnSiguiente;
        private Label lblContadorImagenes;
        private Button BtnAnterior;
    }
}