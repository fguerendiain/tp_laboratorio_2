﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleado;

namespace Clase08WF
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.mtxtLegajo.Clear();
            this.cmbPuesto.SelectedText = "";
            this.mtxtSalario.Clear();
            this.rtxtConsola.Clear();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
