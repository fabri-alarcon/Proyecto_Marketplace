namespace Proyecto_Marketplace
{
    partial class FormApp
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
            botonBuscar = new Button();
            textBoxBusqueda = new TextBox();
            botonPerfil = new Button();
            botonPublicar = new Button();
            pictureBox2 = new PictureBox();
            botonCerrarSesion = new Button();
            botonVolverLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(596, 23);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 0;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(195, 23);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(395, 23);
            textBoxBusqueda.TabIndex = 1;
            // 
            // botonPerfil
            // 
            botonPerfil.Location = new Point(18, 82);
            botonPerfil.Name = "botonPerfil";
            botonPerfil.Size = new Size(75, 23);
            botonPerfil.TabIndex = 2;
            botonPerfil.Text = "Perfil";
            botonPerfil.UseVisualStyleBackColor = true;
            botonPerfil.Click += botonPerfil_Click;
            // 
            // botonPublicar
            // 
            botonPublicar.Location = new Point(18, 111);
            botonPublicar.Name = "botonPublicar";
            botonPublicar.Size = new Size(75, 23);
            botonPublicar.TabIndex = 3;
            botonPublicar.Text = "Publicar";
            botonPublicar.UseVisualStyleBackColor = true;
            botonPublicar.Click += botonPublicar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.perfilPredeterminado;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBox2.Location = new Point(18, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // botonCerrarSesion
            // 
            botonCerrarSesion.Location = new Point(11, 525);
            botonCerrarSesion.Name = "botonCerrarSesion";
            botonCerrarSesion.Size = new Size(90, 24);
            botonCerrarSesion.TabIndex = 6;
            botonCerrarSesion.Text = "cerrar sesion";
            botonCerrarSesion.UseVisualStyleBackColor = true;
            botonCerrarSesion.Click += botonCerrarSesion_Click;
            // 
            // botonVolverLogin
            // 
            botonVolverLogin.Location = new Point(11, 526);
            botonVolverLogin.Name = "botonVolverLogin";
            botonVolverLogin.Size = new Size(89, 23);
            botonVolverLogin.TabIndex = 7;
            botonVolverLogin.Text = "volver";
            botonVolverLogin.UseVisualStyleBackColor = true;
            botonVolverLogin.Click += botonVolverLogin_Click;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(784, 561);
            Controls.Add(botonVolverLogin);
            Controls.Add(botonCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(botonPublicar);
            Controls.Add(botonPerfil);
            Controls.Add(textBoxBusqueda);
            Controls.Add(botonBuscar);
            Name = "FormApp";
            Text = "Services and Products";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonBuscar;
        private TextBox textBoxBusqueda;
        private Button botonPerfil;
        private Button botonPublicar;
        private PictureBox pictureBox2;
        private Button botonCerrarSesion;
        private Button botonVolverLogin;
    }
}