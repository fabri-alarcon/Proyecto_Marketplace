
namespace Proyecto_Marketplace.forms
{
    partial class FormRegistrar
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
            botonConfirmarReg = new Button();
            botonCancelarReg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textRegUsuario = new TextBox();
            textRegContrasenia = new TextBox();
            textRegConfirmarContrasenia = new TextBox();
            labelContacto = new Label();
            textContacto = new TextBox();
            labelCuil = new Label();
            textCuil = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // botonConfirmarReg
            // 
            botonConfirmarReg.Location = new Point(191, 476);
            botonConfirmarReg.Name = "botonConfirmarReg";
            botonConfirmarReg.Size = new Size(75, 23);
            botonConfirmarReg.TabIndex = 9;
            botonConfirmarReg.Text = "Confirmar";
            botonConfirmarReg.UseVisualStyleBackColor = true;
            botonConfirmarReg.Click += botonConfirmarReg_Click;
            // 
            // botonCancelarReg
            // 
            botonCancelarReg.Location = new Point(339, 476);
            botonCancelarReg.Name = "botonCancelarReg";
            botonCancelarReg.Size = new Size(75, 23);
            botonCancelarReg.TabIndex = 10;
            botonCancelarReg.Text = "Cancelar";
            botonCancelarReg.UseVisualStyleBackColor = true;
            botonCancelarReg.Click += botonCancelarReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(152, 20);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 2;
            label1.Text = "Registro de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(190, 102);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(190, 160);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(190, 218);
            label4.Name = "label4";
            label4.Size = new Size(181, 21);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña:";
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(190, 126);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.PlaceholderText = "Escribe tu nombre de usuario";
            textRegUsuario.Size = new Size(224, 23);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(190, 184);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.PasswordChar = '*';
            textRegContrasenia.PlaceholderText = "Escribe tu contraseña";
            textRegContrasenia.Size = new Size(224, 23);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(190, 242);
            textRegConfirmarContrasenia.Name = "textRegConfirmarContrasenia";
            textRegConfirmarContrasenia.PasswordChar = '*';
            textRegConfirmarContrasenia.PlaceholderText = "Confirma tu contraseña";
            textRegConfirmarContrasenia.Size = new Size(224, 23);
            textRegConfirmarContrasenia.TabIndex = 2;
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContacto.ForeColor = SystemColors.Control;
            labelContacto.Location = new Point(190, 278);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(178, 21);
            labelContacto.TabIndex = 11;
            labelContacto.Text = "Contacto (WhatsApp):";
            // 
            // textContacto
            // 
            textContacto.Location = new Point(190, 302);
            textContacto.Name = "textContacto";
            textContacto.PlaceholderText = "ej: 3644123456 (solo números)";
            textContacto.Size = new Size(224, 23);
            textContacto.TabIndex = 3;
            // 
            // labelCuil
            // 
            labelCuil.AutoSize = true;
            labelCuil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCuil.ForeColor = SystemColors.Control;
            labelCuil.Location = new Point(190, 338);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(168, 21);
            labelCuil.TabIndex = 13;
            labelCuil.Text = "CUIL (solo números):";
            // 
            // textCuil
            // 
            textCuil.Location = new Point(190, 362);
            textCuil.Name = "textCuil";
            textCuil.PlaceholderText = "ej: 20123456789";
            textCuil.Size = new Size(224, 23);
            textCuil.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 410);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(190, 387);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(231, 444);
            label6.Name = "label6";
            label6.Size = new Size(144, 17);
            label6.TabIndex = 16;
            label6.Text = "Espere un momento...";
            label6.Visible = false;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(584, 511);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(textRegConfirmarContrasenia);
            Controls.Add(textRegContrasenia);
            Controls.Add(textRegUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonCancelarReg);
            Controls.Add(botonConfirmarReg);
            Controls.Add(labelContacto);
            Controls.Add(textContacto);
            Controls.Add(labelCuil);
            Controls.Add(textCuil);
            Name = "FormRegistrar";
            Text = "Registro de Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Button botonConfirmarReg;
        private Button botonCancelarReg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textRegUsuario;
        private TextBox textRegContrasenia;
        private TextBox textRegConfirmarContrasenia;
        // --- INICIO DE MODIFICACIÓN (Declaración final) ---
        private Label labelContacto;
        private TextBox textContacto;
        private Label labelCuil;
        private TextBox textCuil;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        // --- FIN DE MODIFICACIÓN ---
    }
}