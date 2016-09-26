namespace Clase08WF
{
    partial class frmEmpresa
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
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.Ganancias = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtGanancias = new System.Windows.Forms.MaskedTextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 16);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 0;
            this.lblRazonSocial.Text = "Razon Social";
            this.lblRazonSocial.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 53);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // Ganancias
            // 
            this.Ganancias.AutoSize = true;
            this.Ganancias.Location = new System.Drawing.Point(12, 94);
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.Size = new System.Drawing.Size(58, 13);
            this.Ganancias.TabIndex = 2;
            this.Ganancias.Text = "Ganancias";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(119, 16);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(223, 20);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(119, 53);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(223, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // mtxtGanancias
            // 
            this.mtxtGanancias.Location = new System.Drawing.Point(119, 91);
            this.mtxtGanancias.Name = "mtxtGanancias";
            this.mtxtGanancias.Size = new System.Drawing.Size(114, 20);
            this.mtxtGanancias.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(267, 106);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 42);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 160);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mtxtGanancias);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.Ganancias);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRazonSocial);
            this.Name = "Form2";
            this.Text = "Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label Ganancias;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtGanancias;
        private System.Windows.Forms.Button btnAceptar;
    }
}