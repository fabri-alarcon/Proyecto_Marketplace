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
            botonBuscar.Location = new Point(681, 31);
            botonBuscar.Margin = new Padding(3, 4, 3, 4);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(86, 31);
            botonBuscar.TabIndex = 0;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(268, 31);
            textBoxBusqueda.Margin = new Padding(3, 4, 3, 4);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(406, 27);
            textBoxBusqueda.TabIndex = 1;
            // 
            // botonPerfil
            // 
            botonPerfil.Location = new Point(21, 109);
            botonPerfil.Margin = new Padding(3, 4, 3, 4);
            botonPerfil.Name = "botonPerfil";
            botonPerfil.Size = new Size(86, 31);
            botonPerfil.TabIndex = 2;
            botonPerfil.Text = "Perfil";
            botonPerfil.UseVisualStyleBackColor = true;
            botonPerfil.Click += botonPerfil_Click;
            // 
            // botonPublicar
            // 
            botonPublicar.Location = new Point(21, 148);
            botonPublicar.Margin = new Padding(3, 4, 3, 4);
            botonPublicar.Name = "botonPublicar";
            botonPublicar.Size = new Size(86, 31);
            botonPublicar.TabIndex = 3;
            botonPublicar.Text = "Publicar";
            botonPublicar.UseVisualStyleBackColor = true;
            botonPublicar.Click += botonPublicar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.perfilPredeterminado;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = Properties.Resources.perfilPredeterminado;
            pictureBox2.Location = new Point(21, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // botonCerrarSesion
            // 
            botonCerrarSesion.Location = new Point(13, 700);
            botonCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            botonCerrarSesion.Name = "botonCerrarSesion";
            botonCerrarSesion.Size = new Size(103, 32);
            botonCerrarSesion.TabIndex = 6;
            botonCerrarSesion.Text = "cerrar sesion";
            botonCerrarSesion.UseVisualStyleBackColor = true;
            botonCerrarSesion.Click += botonCerrarSesion_Click;
            // 
            // botonVolverLogin
            // 
            botonVolverLogin.Location = new Point(13, 701);
            botonVolverLogin.Margin = new Padding(3, 4, 3, 4);
            botonVolverLogin.Name = "botonVolverLogin";
            botonVolverLogin.Size = new Size(102, 31);
            botonVolverLogin.TabIndex = 7;
            botonVolverLogin.Text = "volver";
            botonVolverLogin.UseVisualStyleBackColor = true;
            botonVolverLogin.Click += botonVolverLogin_Click;
            // 
            // comboCategoriaFiltro
            // 
            comboCategoriaFiltro.FormattingEnabled = true;
            comboCategoriaFiltro.Location = new Point(123, 30);
            comboCategoriaFiltro.Name = "comboCategoriaFiltro";
            comboCategoriaFiltro.Size = new Size(139, 28);
            comboCategoriaFiltro.TabIndex = 8;
            comboCategoriaFiltro.Text = "Categoría";
            // 
            // botonModerar
            // 
            botonModerar.Location = new Point(21, 186);
            botonModerar.Name = "botonModerar";
            botonModerar.Size = new Size(86, 29);
            botonModerar.TabIndex = 9;
            botonModerar.Text = "Moderar";
            botonModerar.UseVisualStyleBackColor = true;
            // 
            // adminContextMenu
            // 
            adminContextMenu.ImageScalingSize = new Size(20, 20);
            adminContextMenu.Items.AddRange(new ToolStripItem[] { aprobarToolStripMenuItem, eliminarToolStripMenuItem, infoToolStripMenuItem });
            adminContextMenu.Name = "adminContextMenu";
            adminContextMenu.Size = new Size(211, 104);
            // 
            // aprobarToolStripMenuItem
            // 
            aprobarToolStripMenuItem.Name = "aprobarToolStripMenuItem";
            aprobarToolStripMenuItem.Size = new Size(210, 24);
            aprobarToolStripMenuItem.Text = "Aprobar";
            aprobarToolStripMenuItem.Click += aprobarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(210, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(210, 24);
            infoToolStripMenuItem.Text = "Información";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(896, 748);
            Controls.Add(botonModerar);
            Controls.Add(comboCategoriaFiltro);
            Controls.Add(botonVolverLogin);
            Controls.Add(botonCerrarSesion);
            Controls.Add(pictureBox2);
            Controls.Add(botonPublicar);
            Controls.Add(botonPerfil);
            Controls.Add(textBoxBusqueda);
            Controls.Add(botonBuscar);
            Margin = new Padding(3, 4, 3, 4);
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