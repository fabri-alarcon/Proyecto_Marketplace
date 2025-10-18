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
            SuspendLayout();
            // 
            // textRegUsuario
            // 
            textRegUsuario.Location = new Point(113, 72);
            textRegUsuario.Name = "textRegUsuario";
            textRegUsuario.Size = new Size(185, 23);
            textRegUsuario.TabIndex = 0;
            // 
            // textRegContrasenia
            // 
            textRegContrasenia.Location = new Point(113, 113);
            textRegContrasenia.Name = "textRegContrasenia";
            textRegContrasenia.Size = new Size(185, 23);
            textRegContrasenia.TabIndex = 1;
            // 
            // textRegConfirmarContrasenia
            // 
            textRegConfirmarContrasenia.Location = new Point(113, 164);
            textRegConfirmarContrasenia.Name = "textRegConfirmarContrasenia";
            textRegConfirmarContrasenia.Size = new Size(185, 23);
            textRegConfirmarContrasenia.TabIndex = 2;
            // 
            // botonConfirmarReg
            // 
            botonConfirmarReg.Location = new Point(113, 214);
            botonConfirmarReg.Name = "botonConfirmarReg";
            botonConfirmarReg.Size = new Size(75, 23);
            botonConfirmarReg.TabIndex = 3;
            botonConfirmarReg.Text = "Confirmar";
            botonConfirmarReg.UseVisualStyleBackColor = true;
            botonConfirmarReg.Click += botonConfirmarReg_Click;
            // 
            // botonCancelarReg
            // 
            botonCancelarReg.Location = new Point(223, 214);
            botonCancelarReg.Name = "botonCancelarReg";
            botonCancelarReg.Size = new Size(75, 23);
            botonCancelarReg.TabIndex = 4;
            botonCancelarReg.Text = "Cancelar";
            botonCancelarReg.UseVisualStyleBackColor = true;
            //botonCancelarReg.Click += botonCancelarReg_Click;
            this.botonCancelarReg.Click += new System.EventHandler(this.botonCancelarReg_Click);

            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(botonCancelarReg);
            Controls.Add(botonConfirmarReg);
            Controls.Add(textRegConfirmarContrasenia);
            Controls.Add(textRegContrasenia);
            Controls.Add(textRegUsuario);
            Name = "FormRegistrar";
            Text = "FormRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRegUsuario;
        private TextBox textRegContrasenia;
        private TextBox textRegConfirmarContrasenia;
        private Button botonConfirmarReg;
        private Button botonCancelarReg;
    }
}