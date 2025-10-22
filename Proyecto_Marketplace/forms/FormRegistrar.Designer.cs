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
            textRegUsuario = new TextBox();
            textRegContrasenia = new TextBox();
            textRegConfirmarContrasenia = new TextBox();
            botonConfirmarReg = new Button();
            botonCancelarReg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(116, 111);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.Size = new Size(185, 23);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(116, 175);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.Size = new Size(185, 23);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(116, 254);
            textRegConfirmarContrasenia.Name = "textRegConfirmarContrasenia";
            textRegConfirmarContrasenia.Size = new Size(185, 23);
            textRegConfirmarContrasenia.TabIndex = 2;
            // 
            // botonConfirmarReg
            // 
            botonConfirmarReg.Location = new Point(116, 304);
            botonConfirmarReg.Name = "botonConfirmarReg";
            botonConfirmarReg.Size = new Size(75, 23);
            botonConfirmarReg.TabIndex = 3;
            botonConfirmarReg.Text = "Confirmar";
            botonConfirmarReg.UseVisualStyleBackColor = true;
            botonConfirmarReg.Click += botonConfirmarReg_Click;
            // 
            // botonCancelarReg
            // 
            botonCancelarReg.Location = new Point(226, 304);
            botonCancelarReg.Name = "botonCancelarReg";
            botonCancelarReg.Size = new Size(75, 23);
            botonCancelarReg.TabIndex = 4;
            botonCancelarReg.Text = "Cancelar";
            botonCancelarReg.UseVisualStyleBackColor = true;
            botonCancelarReg.Click += botonCancelarReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(116, 93);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese un Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(116, 157);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 6;
            label2.Text = "Ingrese una contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(116, 236);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirme contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(41, 29);
            label4.Name = "label4";
            label4.Size = new Size(357, 21);
            label4.TabIndex = 8;
            label4.Text = "GRACIAS POR REGISTRARSE EN NUESTRA APP";
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(434, 361);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonCancelarReg);
            Controls.Add(botonConfirmarReg);
            Controls.Add(textRegConfirmarContrasenia);
            Controls.Add(textRegContrasenia);
            Controls.Add(textRegUsuario);
            Name = "FormRegistrar";
            Text = "Registro de Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRegUsuario;
        private TextBox textRegContrasenia;
        private TextBox textRegConfirmarContrasenia;
        private Button botonConfirmarReg;
        private Button botonCancelarReg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}