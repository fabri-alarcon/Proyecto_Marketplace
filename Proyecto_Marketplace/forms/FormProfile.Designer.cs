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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            botonVolverAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.BackColor = Color.Indigo;
            pictureBoxPerfil.BackgroundImage = (Image)resources.GetObject("pictureBoxPerfil.BackgroundImage");
            pictureBoxPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPerfil.ErrorImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.ImageLocation = "";
            pictureBoxPerfil.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Location = new Point(35, 12);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(188, 184);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 0;
            pictureBoxPerfil.TabStop = false;
            // 
            // boton_cambiarFoto
            // 
            boton_cambiarFoto.Location = new Point(35, 202);
            boton_cambiarFoto.Name = "boton_cambiarFoto";
            boton_cambiarFoto.Size = new Size(89, 23);
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
            labelBienvenida.Location = new Point(266, 12);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(298, 65);
            labelBienvenida.TabIndex = 2;
            labelBienvenida.Text = "Bienvenido!";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(266, 64);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(201, 65);
            labelNombreUsuario.TabIndex = 3;
            labelNombreUsuario.Text = "Usuario";
            // 
            // boton_eliminarFoto
            // 
            boton_eliminarFoto.Location = new Point(130, 202);
            boton_eliminarFoto.Name = "boton_eliminarFoto";
            boton_eliminarFoto.Size = new Size(93, 23);
            boton_eliminarFoto.TabIndex = 4;
            boton_eliminarFoto.Text = "eliminar";
            boton_eliminarFoto.UseVisualStyleBackColor = true;
            boton_eliminarFoto.Click += boton_eliminarFoto_Click;
            // 
            // button1
            // 
            button1.Location = new Point(454, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "cambiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(283, 138);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(283, 163);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "CUIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(324, 163);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "valor_cuil";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(348, 138);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 10;
            label4.Text = "valor_contacto";
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(597, 426);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(75, 23);
            botonVolverAtras.TabIndex = 11;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(684, 461);
            Controls.Add(botonVolverAtras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(boton_eliminarFoto);
            Controls.Add(labelNombreUsuario);
            Controls.Add(labelBienvenida);
            Controls.Add(boton_cambiarFoto);
            Controls.Add(pictureBoxPerfil);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button botonVolverAtras;
    }
}