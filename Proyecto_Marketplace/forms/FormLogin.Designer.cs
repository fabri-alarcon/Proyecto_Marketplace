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
            botonIniciarSesion = new Button();
            botonRegistrarse = new Button();
            botonContinuarInvitado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Location = new Point(208, 120);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(159, 32);
            botonIniciarSesion.TabIndex = 0;
            botonIniciarSesion.Text = "iniciar sesion";
            botonIniciarSesion.UseVisualStyleBackColor = true;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // botonRegistrarse
            // 
            botonRegistrarse.Location = new Point(208, 158);
            botonRegistrarse.Name = "botonRegistrarse";
            botonRegistrarse.Size = new Size(159, 32);
            botonRegistrarse.TabIndex = 1;
            botonRegistrarse.Text = "registrarse";
            botonRegistrarse.UseVisualStyleBackColor = true;
            botonRegistrarse.Click += botonRegistrarse_Click;
            // 
            // botonContinuarInvitado
            // 
            botonContinuarInvitado.Location = new Point(208, 227);
            botonContinuarInvitado.Name = "botonContinuarInvitado";
            botonContinuarInvitado.Size = new Size(159, 32);
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
            label1.Location = new Point(106, 37);
            label1.Name = "label1";
            label1.Size = new Size(375, 41);
            label1.TabIndex = 3;
            label1.Text = "Services and Products";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(584, 361);
            Controls.Add(label1);
            Controls.Add(botonContinuarInvitado);
            Controls.Add(botonRegistrarse);
            Controls.Add(botonIniciarSesion);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonIniciarSesion;
        private Button botonRegistrarse;
        private Button botonContinuarInvitado;
        private Label label1;
    }
}
