using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{

    public partial class FormCrudAlumno : Form
    {
        private NEspecialidad objEsp;
        private NAlumno objAlu;

        private BindingSource bindingEsp;

        private string idAlumno;

        public FormCrudAlumno()
        {
            InitializeComponent();
            this.CenterToScreen();

            objEsp = new NEspecialidad();
            objAlu = new NAlumno();

            bindingEsp = new BindingSource();
            CargarPorEspBind();
            CargarAlumnos();

            Ocultar(true);
        }

        public void Ocultar(bool estado)
        {
            btnAgregar.Enabled = estado;
            btnModificar.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }

        public void CargarPorEspBind()
        {
            cbEspecialidad.DataSource = null;
            cbEspecialidad.DataSource = objEsp.ListarTodos();

            cbEspecialidad.DisplayMember = "nom_esp";
            cbEspecialidad.ValueMember = "id_esp";
        }

        public void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;

            dataGridAlumno.ClearSelection();
        }

        public void CargarAlumnos()
        {
            string code = cbEspecialidad.SelectedValue.ToString();
            dataGridAlumno.Rows.Clear();
            foreach (Alumno a in objAlu.ListarPorEspecialidad(code))
            {
                dataGridAlumno.Rows.Add(a.id_alumno, a.nombre, a.apellido, a.procedencia);
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void cbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Ocultar(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.nombre = txtNombre.Text.Trim();
            a.apellido = txtApellido.Text.Trim();
            a.procedencia = ""+cbProcedencia.SelectedItem.ToString()[0];
            a.id_esp = cbEspecialidad.SelectedValue.ToString();

            int res = objAlu.AgregarAlumno(a);

            if (res >0)
            {
                MessageBox.Show("Alumno registrado correctamente");
                CargarAlumnos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar alumno");
            }
        }

        private void dataGridAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dataGridAlumno.CurrentRow.Index;
            idAlumno = dataGridAlumno.Rows[indice].Cells[0].Value.ToString();

            Alumno a = objAlu.BuscarPorId(idAlumno);
            cbEspecialidad.SelectedItem = a.id_esp;
            cbProcedencia.SelectedItem = a.procedencia == "P" ? "Particular" : "Nacional";
            txtApellido.Text = a.apellido;
            txtNombre.Text = a.nombre;
            //cbProcedencia.S

            Ocultar(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.id_alumno = idAlumno;
            a.nombre = txtNombre.Text.Trim();
            a.apellido = txtApellido.Text.Trim();
            a.procedencia = "" + cbProcedencia.SelectedItem.ToString()[0];
            a.id_esp = cbEspecialidad.SelectedValue.ToString();

            int res = objAlu.ModificarAlumno(a);

            if (res > 0)
            {
                MessageBox.Show("Alumno modificado correctamente");
                CargarAlumnos();
                Limpiar();
                Ocultar(true);
            }
            else
            {
                MessageBox.Show("No se ha podido modificar alumno");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (MessageBox.Show("¿Esta seguro que desea eliminar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //do something
                res = objAlu.EliminarAlumno(idAlumno);


                if (res > 0)
                {
                    MessageBox.Show("Alumno eliminado correctamente");
                    CargarAlumnos();
                    Limpiar();
                    Ocultar(true);
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar datos del alumno");
                }
            }
        }
    }
}
