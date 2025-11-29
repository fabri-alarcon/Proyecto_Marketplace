namespace Proyecto_Marketplace.forms
{
    partial class Verificación
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
            btnVerificar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = Color.Black;
            btnVerificar.Location = new Point(269, 206);
            btnVerificar.Margin = new Padding(3, 2, 3, 2);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(103, 33);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(238, 158);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(163, 29);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(147, 108);
            label1.Name = "label1";
            label1.Size = new Size(373, 23);
            label1.TabIndex = 2;
            label1.Text = "Revise su Mail e ingrese código de verificación";
            // 
            // Verificación
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(656, 338);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(btnVerificar);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "Verificación";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox txtCodigo;
        private Label label1;
    }
}