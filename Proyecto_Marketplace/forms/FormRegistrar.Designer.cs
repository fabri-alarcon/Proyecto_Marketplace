
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
            SuspendLayout();
            // 
            // botonConfirmarReg
            // 
            botonConfirmarReg.Location = new Point(217, 614);
            botonConfirmarReg.Margin = new Padding(3, 4, 3, 4);
            botonConfirmarReg.Name = "botonConfirmarReg";
            botonConfirmarReg.Size = new Size(86, 31);
            botonConfirmarReg.TabIndex = 9;
            botonConfirmarReg.Text = "Confirmar";
            botonConfirmarReg.UseVisualStyleBackColor = true;
            botonConfirmarReg.Click += botonConfirmarReg_Click;
            // 
            // botonCancelarReg
            // 
            botonCancelarReg.Location = new Point(386, 614);
            botonCancelarReg.Margin = new Padding(3, 4, 3, 4);
            botonCancelarReg.Name = "botonCancelarReg";
            botonCancelarReg.Size = new Size(86, 31);
            botonCancelarReg.TabIndex = 10;
            botonCancelarReg.Text = "Cancelar";
            botonCancelarReg.UseVisualStyleBackColor = true;
            botonCancelarReg.Click += botonCancelarReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(217, 28);
            label1.Name = "label1";
            label1.Size = new Size(269, 81);
            label1.TabIndex = 2;
            label1.Text = "Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(217, 152);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(217, 229);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(217, 307);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña:";
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(217, 184);
            textRegUsuario.Margin = new Padding(3, 4, 3, 4);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.PlaceholderText = "Escribe tu nombre de usuario";
            textRegUsuario.Size = new Size(255, 27);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(217, 261);
            textRegContrasenia.Margin = new Padding(3, 4, 3, 4);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.PasswordChar = '*';
            textRegContrasenia.PlaceholderText = "Escribe tu contraseña";
            textRegContrasenia.Size = new Size(255, 27);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(217, 339);
            textRegConfirmarContrasenia.Margin = new Padding(3, 4, 3, 4);
            textRegConfirmarContrasenia.Name = "textRegConfirmarContrasenia";
            textRegConfirmarContrasenia.PasswordChar = '*';
            textRegConfirmarContrasenia.PlaceholderText = "Confirma tu contraseña";
            textRegConfirmarContrasenia.Size = new Size(255, 27);
            textRegConfirmarContrasenia.TabIndex = 2;
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContacto.ForeColor = Color.Black;
            labelContacto.Location = new Point(217, 387);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(220, 28);
            labelContacto.TabIndex = 11;
            labelContacto.Text = "Contacto (WhatsApp):";
            // 
            // textContacto
            // 
            textContacto.Location = new Point(217, 419);
            textContacto.Margin = new Padding(3, 4, 3, 4);
            textContacto.Name = "textContacto";
            textContacto.PlaceholderText = "ej: 3644123456 (solo números)";
            textContacto.Size = new Size(255, 27);
            textContacto.TabIndex = 3;
            // 
            // labelCuil
            // 
            labelCuil.AutoSize = true;
            labelCuil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCuil.ForeColor = SystemColors.ActiveCaptionText;
            labelCuil.Location = new Point(217, 467);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(206, 28);
            labelCuil.TabIndex = 13;
            labelCuil.Text = "CUIL (solo números):";
            // 
            // textCuil
            // 
            textCuil.Location = new Point(217, 499);
            textCuil.Margin = new Padding(3, 4, 3, 4);
            textCuil.Name = "textCuil";
            textCuil.PlaceholderText = "ej: 20123456789";
            textCuil.Size = new Size(255, 27);
            textCuil.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 563);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 27);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(217, 532);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(667, 681);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistrar";
            Text = "FormRegistrar";
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
        // --- FIN DE MODIFICACIÓN ---
    }
}