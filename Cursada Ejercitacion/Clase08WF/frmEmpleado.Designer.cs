namespace Clase08WF
{
    partial class frmEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnLimpiarFrom = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.rtxtConsola = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 38);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(12, 72);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(12, 108);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(13, 142);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(16, 172);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(75, 40);
            this.btnEmpresa.TabIndex = 5;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnLimpiarFrom
            // 
            this.btnLimpiarFrom.Location = new System.Drawing.Point(128, 172);
            this.btnLimpiarFrom.Name = "btnLimpiarFrom";
            this.btnLimpiarFrom.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiarFrom.TabIndex = 6;
            this.btnLimpiarFrom.Text = "Limpiar";
            this.btnLimpiarFrom.UseVisualStyleBackColor = true;
            this.btnLimpiarFrom.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(209, 172);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 40);
            this.btnAgregarItem.TabIndex = 7;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(181, 20);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // mtxtLegajo
            // 
            this.mtxtLegajo.Location = new System.Drawing.Point(103, 65);
            this.mtxtLegajo.Name = "mtxtLegajo";
            this.mtxtLegajo.Size = new System.Drawing.Size(181, 20);
            this.mtxtLegajo.TabIndex = 10;
            this.mtxtLegajo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(103, 100);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(181, 21);
            this.cmbPuesto.TabIndex = 11;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(103, 135);
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(100, 20);
            this.mtxtSalario.TabIndex = 12;
            // 
            // rtxtConsola
            // 
            this.rtxtConsola.Location = new System.Drawing.Point(1, 218);
            this.rtxtConsola.Name = "rtxtConsola";
            this.rtxtConsola.Size = new System.Drawing.Size(290, 179);
            this.rtxtConsola.TabIndex = 13;
            this.rtxtConsola.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 398);
            this.Controls.Add(this.rtxtConsola);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.mtxtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.btnLimpiarFrom);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Clase08";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnLimpiarFrom;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtLegajo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.MaskedTextBox mtxtSalario;
        private System.Windows.Forms.RichTextBox rtxtConsola;
    }
}

