namespace Proyecto_Marketplace.forms
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            pictureBoxPerfil = new PictureBox();
            boton_cambiarFoto = new Button();
            labelBienvenida = new Label();
            labelNombreUsuario = new Label();
            boton_eliminarFoto = new Button();
            btnGuardarCambios = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            botonVolverAtras = new Button();
            label5 = new Label();
            txtContacto = new TextBox();
            txtNombreUsuario = new TextBox();
            txtCuil = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.BackColor = Color.Indigo;
            pictureBoxPerfil.BackgroundImage = (Image)resources.GetObject("pictureBoxPerfil.BackgroundImage");
            pictureBoxPerfil.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPerfil.ErrorImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.ImageLocation = "";
            pictureBoxPerfil.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Location = new Point(40, 16);
            pictureBoxPerfil.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(215, 245);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 0;
            pictureBoxPerfil.TabStop = false;
            // 
            // boton_cambiarFoto
            // 
            boton_cambiarFoto.Location = new Point(40, 269);
            boton_cambiarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_cambiarFoto.Name = "boton_cambiarFoto";
            boton_cambiarFoto.Size = new Size(102, 31);
            boton_cambiarFoto.TabIndex = 1;
            boton_cambiarFoto.Text = "cambiar ";
            boton_cambiarFoto.UseVisualStyleBackColor = true;
            boton_cambiarFoto.Click += boton_cambiarFoto_Click;
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = Color.White;
            labelBienvenida.Location = new Point(304, 16);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(369, 81);
            labelBienvenida.TabIndex = 2;
            labelBienvenida.Text = "Bienvenido!";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(304, 85);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(250, 81);
            labelNombreUsuario.TabIndex = 3;
            labelNombreUsuario.Text = "Usuario";
            // 
            // boton_eliminarFoto
            // 
            boton_eliminarFoto.Location = new Point(149, 269);
            boton_eliminarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_eliminarFoto.Name = "boton_eliminarFoto";
            boton_eliminarFoto.Size = new Size(106, 31);
            boton_eliminarFoto.TabIndex = 4;
            boton_eliminarFoto.Text = "eliminar";
            boton_eliminarFoto.UseVisualStyleBackColor = true;
            boton_eliminarFoto.Click += boton_eliminarFoto_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(385, 296);
            btnGuardarCambios.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(156, 31);
            btnGuardarCambios.TabIndex = 5;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(320, 184);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(350, 255);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "CUIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(370, 217);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(398, 184);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(682, 568);
            botonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(86, 31);
            botonVolverAtras.TabIndex = 11;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(333, 220);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Usuario";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(398, 181);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(398, 217);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(398, 252);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(125, 27);
            txtCuil.TabIndex = 15;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(782, 615);
            Controls.Add(txtCuil);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContacto);
            Controls.Add(label5);
            Controls.Add(botonVolverAtras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardarCambios);
            Controls.Add(boton_eliminarFoto);
            Controls.Add(labelNombreUsuario);
            Controls.Add(labelBienvenida);
            Controls.Add(boton_cambiarFoto);
            Controls.Add(pictureBoxPerfil);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPerfil;
        private Button boton_cambiarFoto;
        private Label labelBienvenida;
        private Label labelNombreUsuario;
        private Button boton_eliminarFoto;
        private Button btnGuardarCambios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button botonVolverAtras;
        private Label label5;
        private TextBox txtContacto;
        private TextBox txtNombreUsuario;
        private TextBox txtCuil;
    }
}