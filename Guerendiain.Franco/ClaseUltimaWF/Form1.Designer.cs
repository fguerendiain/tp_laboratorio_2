namespace ClaseUltimaWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbElejir = new System.Windows.Forms.ComboBox();
            this.btnTirar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbElejir
            // 
            this.cmbElejir.FormattingEnabled = true;
            this.cmbElejir.Location = new System.Drawing.Point(0, 0);
            this.cmbElejir.Name = "cmbElejir";
            this.cmbElejir.Size = new System.Drawing.Size(233, 21);
            this.cmbElejir.TabIndex = 0;
            // 
            // btnTirar
            // 
            this.btnTirar.Location = new System.Drawing.Point(12, 27);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(75, 23);
            this.btnTirar.TabIndex = 1;
            this.btnTirar.Text = "Tirar";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(148, 32);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 59);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.cmbElejir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElejir;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.Label lblResultado;
    }
}

