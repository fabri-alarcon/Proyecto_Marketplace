namespace Proyecto_Marketplace
{
    partial class FormApp
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
            botonBuscar = new Button();
            textBoxBusqueda = new TextBox();
            botonPerfil = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(596, 23);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 0;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(195, 23);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(395, 23);
            textBoxBusqueda.TabIndex = 1;
            // 
            // botonPerfil
            // 
            botonPerfil.Location = new Point(18, 69);
            botonPerfil.Name = "botonPerfil";
            botonPerfil.Size = new Size(75, 23);
            botonPerfil.TabIndex = 2;
            botonPerfil.Text = "Perfil";
            botonPerfil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Publicar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 51);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(732, 390);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(botonPerfil);
            Controls.Add(textBoxBusqueda);
            Controls.Add(botonBuscar);
            Name = "FormApp";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonBuscar;
        private TextBox textBoxBusqueda;
        private Button botonPerfil;
        private Button button1;
        private PictureBox pictureBox1;
    }
}