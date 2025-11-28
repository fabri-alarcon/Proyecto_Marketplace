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
            flowHistorial = new FlowLayoutPanel();
            label6 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            flowHistorial.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.BackColor = Color.Transparent;
            pictureBoxPerfil.BackgroundImage = (Image)resources.GetObject("pictureBoxPerfil.BackgroundImage");
            pictureBoxPerfil.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxPerfil.ErrorImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Image = (Image)resources.GetObject("pictureBoxPerfil.Image");
            pictureBoxPerfil.ImageLocation = "";
            pictureBoxPerfil.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Location = new Point(104, 83);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(164, 142);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 0;
            pictureBoxPerfil.TabStop = false;
            // 
            // boton_cambiarFoto
            // 
            boton_cambiarFoto.Location = new Point(67, 231);
            boton_cambiarFoto.Name = "boton_cambiarFoto";
            boton_cambiarFoto.Size = new Size(107, 26);
            boton_cambiarFoto.TabIndex = 1;
            boton_cambiarFoto.Text = "cambiar ";
            boton_cambiarFoto.UseVisualStyleBackColor = true;
            boton_cambiarFoto.Click += boton_cambiarFoto_Click;
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Segoe UI", 28.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = Color.White;
            labelBienvenida.Location = new Point(67, -2);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(241, 52);
            labelBienvenida.TabIndex = 2;
            labelBienvenida.Text = "Bienvenido!";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(132, 59);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(107, 21);
            labelNombreUsuario.TabIndex = 3;
            labelNombreUsuario.Text = "Usuario";
            labelNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton_eliminarFoto
            // 
            boton_eliminarFoto.Location = new Point(189, 231);
            boton_eliminarFoto.Name = "boton_eliminarFoto";
            boton_eliminarFoto.Size = new Size(107, 26);
            boton_eliminarFoto.TabIndex = 4;
            boton_eliminarFoto.Text = "eliminar";
            boton_eliminarFoto.UseVisualStyleBackColor = true;
            boton_eliminarFoto.Click += boton_eliminarFoto_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(212, 114);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(119, 24);
            btnGuardarCambios.TabIndex = 5;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(212, 26);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "CUIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(308, 210);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(332, 185);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(12, 448);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(112, 26);
            botonVolverAtras.TabIndex = 11;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 91);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 12;
            label5.Text = "Usuario";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(17, 43);
            txtContacto.Margin = new Padding(3, 2, 3, 2);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(108, 23);
            txtContacto.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(17, 115);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(108, 23);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(212, 43);
            txtCuil.Margin = new Padding(3, 2, 3, 2);
            txtCuil.Name = "txtCuil";
            txtCuil.ReadOnly = true;
            txtCuil.Size = new Size(119, 23);
            txtCuil.TabIndex = 15;
            // 
            // flowHistorial
            // 
            flowHistorial.Controls.Add(label6);
            flowHistorial.Location = new Point(461, 104);
            flowHistorial.Margin = new Padding(3, 2, 3, 2);
            flowHistorial.Name = "flowHistorial";
            flowHistorial.Size = new Size(556, 356);
            flowHistorial.TabIndex = 16;
            flowHistorial.Click += flowHistorial_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 19;
            label6.Text = "Historial";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(labelBienvenida);
            panel2.Controls.Add(labelNombreUsuario);
            panel2.Controls.Add(pictureBoxPerfil);
            panel2.Controls.Add(boton_cambiarFoto);
            panel2.Controls.Add(boton_eliminarFoto);
            panel2.Controls.Add(botonVolverAtras);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 486);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnGuardarCambios);
            panel1.Controls.Add(txtCuil);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContacto);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 165);
            panel1.TabIndex = 16;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1047, 486);
            Controls.Add(flowHistorial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            flowHistorial.ResumeLayout(false);
            flowHistorial.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private FlowLayoutPanel flowHistorial;
        private Panel panel2;
        private Label label6;
        private Panel panel1;
    }
}