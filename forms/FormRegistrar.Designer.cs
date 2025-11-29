
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
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
            botonConfirmarReg.Location = new Point(218, 635);
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
            botonCancelarReg.Location = new Point(387, 635);
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
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(174, 27);
            label1.Name = "label1";
            label1.Size = new Size(380, 50);
            label1.TabIndex = 2;
            label1.Text = "Registro de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(217, 136);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(217, 213);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(217, 291);
            label4.Name = "label4";
            label4.Size = new Size(224, 28);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña:";
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(217, 168);
            textRegUsuario.Margin = new Padding(3, 4, 3, 4);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.PlaceholderText = "Escribe tu nombre de usuario";
            textRegUsuario.Size = new Size(255, 27);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(217, 245);
            textRegContrasenia.Margin = new Padding(3, 4, 3, 4);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.PasswordChar = '*';
            textRegContrasenia.PlaceholderText = "Escribe tu contraseña";
            textRegContrasenia.Size = new Size(255, 27);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(217, 323);
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
            labelContacto.ForeColor = SystemColors.Control;
            labelContacto.Location = new Point(217, 371);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(220, 28);
            labelContacto.TabIndex = 11;
            labelContacto.Text = "Contacto (WhatsApp):";
            // 
            // textContacto
            // 
            textContacto.Location = new Point(217, 403);
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
            labelCuil.ForeColor = SystemColors.Control;
            labelCuil.Location = new Point(217, 451);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(206, 28);
            labelCuil.TabIndex = 13;
            labelCuil.Text = "CUIL (solo números):";
            // 
            // textCuil
            // 
            textCuil.Location = new Point(217, 483);
            textCuil.Margin = new Padding(3, 4, 3, 4);
            textCuil.Name = "textCuil";
            textCuil.PlaceholderText = "ej: 20123456789";
            textCuil.Size = new Size(255, 27);
            textCuil.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 547);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 27);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(217, 516);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(264, 592);
            label6.Name = "label6";
            label6.Size = new Size(185, 23);
            label6.TabIndex = 16;
            label6.Text = "Espere un momento...";
            label6.Visible = false;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(697, 681);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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