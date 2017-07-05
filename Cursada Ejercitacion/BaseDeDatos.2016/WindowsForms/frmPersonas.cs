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
    public partial class frmPersonas : Form
    {
        #region Atributos
        private List<Persona> _personas;
        private DataTable _tabla;
        private AccesoDatos.AccesoDatos _objAcceso;
        #endregion

        #region Constructor
        public frmPersonas()
        {
            InitializeComponent();

            this._objAcceso = new AccesoDatos.AccesoDatos();
            this._personas = this._objAcceso.ObtenerListaPersonas();
            this._tabla = this._objAcceso.ObtenerTablaPersonas();

        }
        #endregion

        #region Métodos

        #region Carga del Form
        private void frmPersonas_Load(object sender, EventArgs e)
        {
            this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            #region Uso DataTable
            //this.dgvGrilla.DataSource = this._tabla;
            #endregion

            #region Uso List<Persona>
            this.dgvGrilla.DataSource = this._personas;
            #endregion
        }
        #endregion

        #region Alta
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ABM frm = new ABM();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!this._objAcceso.InsertarPersona(frm.PersonaDelFormulario))
                {
                    MessageBox.Show("ERROR", "Error al INSERTAR la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #region Uso DataTable
                //DataRow fila = this._tabla.NewRow();
                //fila["apellido"] = frm.PersonaDelFormulario.Apellido;
                //fila["nombre"] = frm.PersonaDelFormulario.Nombre;
                //fila["edad"] = frm.PersonaDelFormulario.Edad;
                //this._tabla.Rows.Add(fila);
                #endregion

                #region Uso List<Persona>
                this._personas = this._objAcceso.ObtenerListaPersonas();
                this.dgvGrilla.DataSource = this._personas;
                #endregion

            }
        }
        #endregion

        #region Baja
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;

            #region Uso DataTable
            //DataRow fila = this._tabla.Rows[i];

            //Persona p = new Persona(int.Parse(fila[0].ToString()), fila["apellido"].ToString(), 
            //                        fila[2].ToString(), int.Parse(fila[3].ToString()));
            #endregion

            #region Uso List<Persona>
            Persona p = this._personas[i];
            #endregion

            ABM frm = new ABM(p);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!this._objAcceso.EliminarPersona(p))
                {
                    MessageBox.Show("ERROR", "Error al ELIMINAR a la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #region Uso DataTable
                //this._tabla.Rows.RemoveAt(i);
                #endregion

                #region Uso List<Persona>
                this._personas = this._objAcceso.ObtenerListaPersonas();
                this.dgvGrilla.DataSource = this._personas;
                #endregion

            }

        }
        #endregion

        #region Modificación
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int i = this.dgvGrilla.SelectedRows[0].Index;

            #region Uso DataTable
            //DataRow fila = this._tabla.Rows[i];

            //Persona p = new Persona(int.Parse(fila[0].ToString()), fila["apellido"].ToString(),
            //                        fila[2].ToString(), int.Parse(fila[3].ToString()));
            #endregion

            #region Uso List<Persona>
            Persona p = this._personas[i];
            #endregion

            ABM frm = new ABM(p);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!this._objAcceso.ModificarPersona(frm.PersonaDelFormulario))
                {
                    MessageBox.Show("ERROR", "Error al MODIFICAR a la persona", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #region Uso DataTable
                //DataRow f = this._tabla.NewRow();
                //f["apellido"] = frm.PersonaDelFormulario.Apellido;
                //f["nombre"] = frm.PersonaDelFormulario.Nombre;
                //f["edad"] = frm.PersonaDelFormulario.Edad;

                //this._tabla.Rows.RemoveAt(i);
                //this._tabla.Rows.Add(f);
                #endregion

                #region Uso List<Persona>
                this._personas = this._objAcceso.ObtenerListaPersonas();
                this.dgvGrilla.DataSource = this._personas;
                #endregion

            }
        }
        #endregion

        #region Cierre
        private void frmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de SALIR?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #endregion
    }
}
