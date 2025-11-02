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
            // --- INICIO DE MODIFICACIÓN (Nuevas Declaraciones) ---
            labelContacto = new Label();
            textContacto = new TextBox();
            labelCuil = new Label();
            textCuil = new TextBox();
            // --- FIN DE MODIFICACIÓN ---
            SuspendLayout();
            // 
            // botonConfirmarReg
            // 
            botonConfirmarReg.Location = new Point(190, 440); // Ajustamos posición Y
            botonConfirmarReg.Name = "botonConfirmarReg";
            botonConfirmarReg.Size = new Size(75, 23);
            botonConfirmarReg.TabIndex = 9; // Actualizamos TabIndex
            botonConfirmarReg.Text = "Confirmar";
            botonConfirmarReg.UseVisualStyleBackColor = true;
            botonConfirmarReg.Click += botonConfirmarReg_Click;
            // 
            // botonCancelarReg
            // 
            botonCancelarReg.Location = new Point(339, 440); // Ajustamos posición Y
            botonCancelarReg.Name = "botonCancelarReg";
            botonCancelarReg.Size = new Size(75, 23);
            botonCancelarReg.TabIndex = 10; // Actualizamos TabIndex
            botonCancelarReg.Text = "Cancelar";
            botonCancelarReg.UseVisualStyleBackColor = true;
            botonCancelarReg.Click += botonCancelarReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(190, 21);
            label1.Name = "label1";
            label1.Size = new Size(224, 65);
            label1.TabIndex = 2;
            label1.Text = "Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(190, 114);
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
            label3.Location = new Point(190, 172);
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
            label4.Location = new Point(190, 230);
            label4.Name = "label4";
            label4.Size = new Size(178, 21);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña:";
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(190, 138);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.PlaceholderText = "Escribe tu nombre de usuario";
            textRegUsuario.Size = new Size(224, 23);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(190, 196);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.PasswordChar = '*';
            textRegContrasenia.PlaceholderText = "Escribe tu contraseña";
            textRegContrasenia.Size = new Size(224, 23);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(190, 254);
            textRegConfirmarContrasenia.Name = "textRegConfirmarContrasenia";
            textRegConfirmarContrasenia.PasswordChar = '*';
            textRegConfirmarContrasenia.PlaceholderText = "Confirma tu contraseña";
            textRegConfirmarContrasenia.Size = new Size(224, 23);
            textRegConfirmarContrasenia.TabIndex = 2;
            // 
            // --- INICIO DE MODIFICACIÓN (Nuevos Controles) ---
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContacto.ForeColor = SystemColors.Control;
            labelContacto.Location = new Point(190, 290);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(174, 21);
            labelContacto.TabIndex = 11;
            labelContacto.Text = "Contacto (WhatsApp):";
            // 
            // textContacto
            // 
            textContacto.Location = new Point(190, 314);
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
            labelCuil.Location = new Point(190, 350);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(160, 21);
            labelCuil.TabIndex = 13;
            labelCuil.Text = "CUIL (solo números):";
            // 
            // textCuil
            // 
            textCuil.Location = new Point(190, 374);
            textCuil.Name = "textCuil";
            textCuil.PlaceholderText = "ej: 20123456789";
            textCuil.Size = new Size(224, 23);
            textCuil.TabIndex = 4;
            // 
            // --- FIN DE MODIFICACIÓN ---
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(584, 511); // Tamaño de ventana actualizado
            Controls.Add(textRegConfirmarContrasenia);
            Controls.Add(textRegContrasenia);
            Controls.Add(textRegUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonCancelarReg);
            Controls.Add(botonConfirmarReg);
            // --- INICIO DE MODIFICACIÓN (Añadir controles al formulario) ---
            Controls.Add(labelContacto);
            Controls.Add(textContacto);
            Controls.Add(labelCuil);
            Controls.Add(textCuil);
            // --- FIN DE MODIFICACIÓN ---
            Name = "FormRegistrar";
            Text = "FormRegistrar";
            ResumeLayout(false);
            PerformLayout();
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
        // --- FIN DE MODIFICACIÓN ---
    }
}