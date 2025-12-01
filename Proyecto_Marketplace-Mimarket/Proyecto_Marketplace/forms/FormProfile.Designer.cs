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
            pictureBoxPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPerfil.ErrorImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Image = (Image)resources.GetObject("pictureBoxPerfil.Image");
            pictureBoxPerfil.ImageLocation = "";
            pictureBoxPerfil.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBoxPerfil.Location = new Point(119, 111);
            pictureBoxPerfil.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(187, 189);
            pictureBoxPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfil.TabIndex = 0;
            pictureBoxPerfil.TabStop = false;
            // 
            // boton_cambiarFoto
            // 
            boton_cambiarFoto.Location = new Point(77, 308);
            boton_cambiarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_cambiarFoto.Name = "boton_cambiarFoto";
            boton_cambiarFoto.Size = new Size(122, 35);
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
            labelBienvenida.Location = new Point(77, -3);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(304, 66);
            labelBienvenida.TabIndex = 2;
            labelBienvenida.Text = "Bienvenido!";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreUsuario.ForeColor = Color.White;
            labelNombreUsuario.Location = new Point(151, 79);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(122, 28);
            labelNombreUsuario.TabIndex = 3;
            labelNombreUsuario.Text = "Usuario";
            labelNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // boton_eliminarFoto
            // 
            boton_eliminarFoto.Location = new Point(216, 308);
            boton_eliminarFoto.Margin = new Padding(3, 4, 3, 4);
            boton_eliminarFoto.Name = "boton_eliminarFoto";
            boton_eliminarFoto.Size = new Size(122, 35);
            boton_eliminarFoto.TabIndex = 4;
            boton_eliminarFoto.Text = "eliminar";
            boton_eliminarFoto.UseVisualStyleBackColor = true;
            boton_eliminarFoto.Click += boton_eliminarFoto_Click;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(242, 152);
            btnGuardarCambios.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(136, 32);
            btnGuardarCambios.TabIndex = 5;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "Contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(242, 35);
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
            label4.Location = new Point(379, 247);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Location = new Point(14, 597);
            botonVolverAtras.Margin = new Padding(3, 4, 3, 4);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(128, 35);
            botonVolverAtras.TabIndex = 11;
            botonVolverAtras.Text = "volver atrás";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += botonVolverAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 121);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Usuario";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(19, 57);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(123, 27);
            txtContacto.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(19, 153);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(123, 27);
            txtNombreUsuario.TabIndex = 14;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(242, 57);
            txtCuil.Name = "txtCuil";
            txtCuil.ReadOnly = true;
            txtCuil.Size = new Size(135, 27);
            txtCuil.TabIndex = 15;
            // 
            // flowHistorial
            // 
            flowHistorial.Controls.Add(label6);
            flowHistorial.Location = new Point(527, 139);
            flowHistorial.Name = "flowHistorial";
            flowHistorial.Size = new Size(635, 475);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 648);
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
            panel1.Location = new Point(14, 351);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 220);
            panel1.TabIndex = 16;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1197, 648);
            Controls.Add(flowHistorial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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