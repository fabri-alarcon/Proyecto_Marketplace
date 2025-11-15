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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            flowHistorial.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            pictureBoxPerfil.Location = new Point(56, 65);
            pictureBoxPerfil.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(122, 120);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 0;
            pictureBoxPerfil.TabStop = false;
            // 
            // boton_cambiarFoto
            // 
            boton_cambiarFoto.Location = new Point(56, 199);
            boton_cambiarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_cambiarFoto.Name = "boton_cambiarFoto";
            boton_cambiarFoto.Size = new Size(122, 34);
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
            labelBienvenida.Location = new Point(3, 1);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(304, 66);
            labelBienvenida.TabIndex = 2;
            labelBienvenida.Text = "Bienvenido!";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(56, 33);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(122, 28);
            labelNombreUsuario.TabIndex = 3;
            labelNombreUsuario.Text = "Usuario";
            labelNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton_eliminarFoto
            // 
            boton_eliminarFoto.Location = new Point(56, 251);
            boton_eliminarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_eliminarFoto.Name = "boton_eliminarFoto";
            boton_eliminarFoto.Size = new Size(122, 34);
            boton_eliminarFoto.TabIndex = 4;
            boton_eliminarFoto.Text = "eliminar";
            boton_eliminarFoto.UseVisualStyleBackColor = true;
            boton_eliminarFoto.Click += boton_eliminarFoto_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(255, 318);
            btnGuardarCambios.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(124, 51);
            btnGuardarCambios.TabIndex = 5;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(256, 139);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(256, 255);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 8;
            label2.Text = "CUIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(352, 280);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(380, 247);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(12, 480);
            botonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(128, 34);
            botonVolverAtras.TabIndex = 11;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(256, 201);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Usuario";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(256, 171);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(123, 27);
            txtContacto.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(257, 225);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(123, 27);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(256, 280);
            txtCuil.Name = "txtCuil";
            txtCuil.ReadOnly = true;
            txtCuil.Size = new Size(123, 27);
            txtCuil.TabIndex = 15;
            // 
            // flowHistorial
            // 
            flowHistorial.Controls.Add(label6);
            flowHistorial.Location = new Point(527, 139);
            flowHistorial.Name = "flowHistorial";
            flowHistorial.Size = new Size(635, 474);
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
            label6.Size = new Size(139, 41);
            label6.TabIndex = 19;
            label6.Text = "Historial";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(labelBienvenida);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 67);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(labelNombreUsuario);
            panel2.Controls.Add(pictureBoxPerfil);
            panel2.Controls.Add(boton_cambiarFoto);
            panel2.Controls.Add(boton_eliminarFoto);
            panel2.Controls.Add(botonVolverAtras);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 581);
            panel2.TabIndex = 18;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1197, 648);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowHistorial);
            Controls.Add(txtCuil);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContacto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardarCambios);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            flowHistorial.ResumeLayout(false);
            flowHistorial.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Label label6;
    }
}