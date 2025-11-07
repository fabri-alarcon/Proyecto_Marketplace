namespace Proyecto_Marketplace.forms
{
    partial class FormVerificacion
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
            btnVerificar.Location = new Point(295, 222);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(128, 52);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(271, 164);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(186, 34);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 130);
            label1.Name = "label1";
            label1.Size = new Size(303, 19);
            label1.TabIndex = 2;
            label1.Text = "Revise su Mail e ingrese código de verificación";
            // 
            // FormVerificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(btnVerificar);
            ForeColor = Color.White;
            Name = "FormVerificacion";
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