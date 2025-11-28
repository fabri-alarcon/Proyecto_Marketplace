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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            botonBuscar = new Button();
            textBoxBusqueda = new TextBox();
            botonPerfil = new Button();
            botonPublicar = new Button();
            pictureBox2 = new PictureBox();
            botonCerrarSesion = new Button();
            botonVolverLogin = new Button();
            comboCategoriaFiltro = new ComboBox();
            botonModerar = new Button();
            adminContextMenu = new ContextMenuStrip(components);
            aprobarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            adminContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(645, 31);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 0;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(283, 31);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(356, 23);
            textBoxBusqueda.TabIndex = 1;
            // 
            // botonPerfil
            // 
            botonPerfil.Location = new Point(23, 98);
            botonPerfil.Name = "botonPerfil";
            botonPerfil.Size = new Size(92, 23);
            botonPerfil.TabIndex = 2;
            botonPerfil.Text = "Perfil";
            botonPerfil.UseVisualStyleBackColor = true;
            botonPerfil.Click += botonPerfil_Click;
            // 
            // botonPublicar
            // 
            botonPublicar.Location = new Point(23, 125);
            botonPublicar.Name = "botonPublicar";
            botonPublicar.Size = new Size(92, 24);
            botonPublicar.TabIndex = 3;
            botonPublicar.Text = "Publicar";
            botonPublicar.UseVisualStyleBackColor = true;
            botonPublicar.Click += botonPublicar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // botonCerrarSesion
            // 
            botonCerrarSesion.Location = new Point(11, 525);
            botonCerrarSesion.Name = "botonCerrarSesion";
            botonCerrarSesion.Size = new Size(90, 24);
            botonCerrarSesion.TabIndex = 6;
            botonCerrarSesion.Text = "cerrar sesion";
            botonCerrarSesion.UseVisualStyleBackColor = true;
            botonCerrarSesion.Click += botonCerrarSesion_Click;
            // 
            // botonVolverLogin
            // 
            botonVolverLogin.Location = new Point(11, 526);
            botonVolverLogin.Name = "botonVolverLogin";
            botonVolverLogin.Size = new Size(89, 23);
            botonVolverLogin.TabIndex = 7;
            botonVolverLogin.Text = "volver";
            botonVolverLogin.UseVisualStyleBackColor = true;
            botonVolverLogin.Click += botonVolverLogin_Click;
            // 
            // comboCategoriaFiltro
            // 
            comboCategoriaFiltro.FormattingEnabled = true;
            comboCategoriaFiltro.Location = new Point(175, 30);
            comboCategoriaFiltro.Margin = new Padding(3, 2, 3, 2);
            comboCategoriaFiltro.Name = "comboCategoriaFiltro";
            comboCategoriaFiltro.Size = new Size(104, 23);
            comboCategoriaFiltro.TabIndex = 8;
            comboCategoriaFiltro.Text = "Categoría";
            // 
            // botonModerar
            // 
            botonModerar.Location = new Point(23, 126);
            botonModerar.Margin = new Padding(3, 2, 3, 2);
            botonModerar.Name = "botonModerar";
            botonModerar.Size = new Size(92, 24);
            botonModerar.TabIndex = 9;
            botonModerar.Text = "Moderar";
            botonModerar.UseVisualStyleBackColor = true;
            // 
            // adminContextMenu
            // 
            adminContextMenu.ImageScalingSize = new Size(20, 20);
            adminContextMenu.Items.AddRange(new ToolStripItem[] { aprobarToolStripMenuItem, eliminarToolStripMenuItem, infoToolStripMenuItem });
            adminContextMenu.Name = "adminContextMenu";
            adminContextMenu.Size = new Size(140, 70);
            // 
            // aprobarToolStripMenuItem
            // 
            aprobarToolStripMenuItem.Name = "aprobarToolStripMenuItem";
            aprobarToolStripMenuItem.Size = new Size(139, 22);
            aprobarToolStripMenuItem.Text = "Aprobar";
            aprobarToolStripMenuItem.Click += aprobarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(139, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(139, 22);
            infoToolStripMenuItem.Text = "Información";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(784, 526);
            Controls.Add(botonModerar);
            Controls.Add(comboCategoriaFiltro);
            Controls.Add(botonVolverLogin);
            Controls.Add(botonCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(botonPublicar);
            Controls.Add(botonPerfil);
            Controls.Add(textBoxBusqueda);
            Controls.Add(botonBuscar);
            Name = "FormApp";
            Text = "Services and Products";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            adminContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonBuscar;
        private TextBox textBoxBusqueda;
        private Button botonPerfil;
        private Button botonPublicar;
        private PictureBox pictureBox2;
        private Button botonCerrarSesion;
        private Button botonVolverLogin;
        private ComboBox comboCategoriaFiltro;
        private Button botonModerar;
        private ContextMenuStrip adminContextMenu;
        private ToolStripMenuItem aprobarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}