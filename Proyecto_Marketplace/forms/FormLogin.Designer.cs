namespace Proyecto_Marketplace
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            botonIniciarSesion = new Button();
            botonRegistrarse = new Button();
            botonContinuarInvitado = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textUsuario = new TextBox();
            textContrasenia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Location = new Point(453, 189);
            botonIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(182, 43);
            botonIniciarSesion.TabIndex = 0;
            botonIniciarSesion.Text = "Iniciar Sesion";
            botonIniciarSesion.UseVisualStyleBackColor = true;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // botonRegistrarse
            // 
            botonRegistrarse.Location = new Point(453, 325);
            botonRegistrarse.Margin = new Padding(3, 4, 3, 4);
            botonRegistrarse.Name = "botonRegistrarse";
            botonRegistrarse.Size = new Size(182, 43);
            botonRegistrarse.TabIndex = 1;
            botonRegistrarse.Text = "Registrarse";
            botonRegistrarse.UseVisualStyleBackColor = true;
            botonRegistrarse.Click += botonRegistrarse_Click;
            // 
            // botonContinuarInvitado
            // 
            botonContinuarInvitado.Location = new Point(453, 376);
            botonContinuarInvitado.Margin = new Padding(3, 4, 3, 4);
            botonContinuarInvitado.Name = "botonContinuarInvitado";
            botonContinuarInvitado.Size = new Size(182, 43);
            botonContinuarInvitado.TabIndex = 2;
            botonContinuarInvitado.Text = "Continuar como invitado";
            botonContinuarInvitado.UseVisualStyleBackColor = true;
            botonContinuarInvitado.Click += botonContinuarInvitado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(14, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 52);
            label1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUsuario.Location = new Point(453, 80);
            textUsuario.Margin = new Padding(3, 4, 3, 4);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Ingrese Usuario";
            textUsuario.Size = new Size(181, 27);
            textUsuario.TabIndex = 5;
            // 
            // textContrasenia
            // 
            textContrasenia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textContrasenia.Location = new Point(453, 132);
            textContrasenia.Margin = new Padding(3, 4, 3, 4);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.PlaceholderText = "Ingrese Contraseña";
            textContrasenia.Size = new Size(181, 27);
            textContrasenia.TabIndex = 6;
            textContrasenia.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(667, 481);
            Controls.Add(textContrasenia);
            Controls.Add(textUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(botonContinuarInvitado);
            Controls.Add(botonRegistrarse);
            Controls.Add(botonIniciarSesion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonIniciarSesion;
        private Button botonRegistrarse;
        private Button botonContinuarInvitado;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textUsuario;
        private TextBox textContrasenia;
    }
}
