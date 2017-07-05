using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesoDatos;

namespace WindowsForms
{
    public partial class ABM : Form
    {
        #region Atributo
        private Persona _persona;
        #endregion

        #region Propiedad (sólo lectura)
        public Persona PersonaDelFormulario
        {
            get { return _persona; }
        }
        #endregion

        #region Constructores
        public ABM()
        {
            InitializeComponent();
        }

        public ABM(Persona p):this()
        {
            this._persona = p;
            this.txtApellido.Text = this._persona.Apellido;
            this.txtNombre.Text = this._persona.Nombre;
            this.txtEdad.Text = this._persona.Edad.ToString();
        }
        #endregion

        #region Métodos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idPersona = this._persona != null ? this._persona.ID : 0;
                
            this._persona = new Persona(idPersona, this.txtApellido.Text, this.txtNombre.Text, int.Parse(this.txtEdad.Text));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion
    }
}
