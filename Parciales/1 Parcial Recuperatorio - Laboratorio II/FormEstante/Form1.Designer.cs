namespace FormEstante
{
    partial class FormEstante
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.rtxtSalida = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(0, 3);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(148, 71);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(154, 3);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(137, 71);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // rtxtSalida
            // 
            this.rtxtSalida.Location = new System.Drawing.Point(0, 80);
            this.rtxtSalida.Name = "rtxtSalida";
            this.rtxtSalida.Size = new System.Drawing.Size(291, 424);
            this.rtxtSalida.TabIndex = 2;
            this.rtxtSalida.Text = "";
            // 
            // FormEstante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 503);
            this.Controls.Add(this.rtxtSalida);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "FormEstante";
            this.Text = "FormEstante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox rtxtSalida;
    }
}

