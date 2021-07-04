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
    public partial class Form1 : Form
    {
        private NEspecialidad objEsp;
        private NAlumno objAlu;

        private BindingSource bindingEsp;
        private BindingSource bindingAlu;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            objEsp = new NEspecialidad();
            objAlu = new NAlumno();

            bindingEsp = new BindingSource();
            bindingAlu = new BindingSource();
            CargarPorEspBind();
            CargarAlumnos();
        }

        public void CargarPorEspBind()
        {
            cbEspecialidad.DataSource = null;
            cbEspecialidad.DataSource = objEsp.ListarTodos();

            cbEspecialidad.DisplayMember = "nom_esp";
            cbEspecialidad.ValueMember = "id_esp";
        }

        public void CargarEspecialidad()
        {
            cbEspecialidad.Items.Clear();

            List<Especialidad> lista = objEsp.ListarTodos();

            foreach (Especialidad e in lista)
            {
                cbEspecialidad.Items.Add(e.nom_esp);
            }
        }

        public void CargarAlumnos()
        {
            string code = cbEspecialidad.SelectedValue.ToString();

            dataGridAlumno.AutoGenerateColumns = true;
            bindingAlu.DataSource = objAlu.ListarPorEspecialidad(code);
            dataGridAlumno.DataSource = bindingAlu;

            if (dataGridAlumno.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos");
            }
        }

        private void cbEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarAlumnos();

        }

        private void BtnVerPagos_Click(object sender, EventArgs e)
        {
            int indice = dataGridAlumno.CurrentRow.Index;

            if (indice == -1)
            {
                MessageBox.Show("Seleccione un alumno para poder consultar");
            }
            else
            {
                string idAlumno = dataGridAlumno.Rows[indice].Cells[0].Value.ToString();
                string apeAlu = dataGridAlumno.Rows[indice].Cells[1].Value.ToString();
                string nomAlu = dataGridAlumno.Rows[indice].Cells[2].Value.ToString();

                FormPagos.nomAlu = nomAlu + " "+ apeAlu;
                FormPagos.idAlumno = idAlumno;
                FormPagos frm = new FormPagos();
                
                frm.Show();
                this.Close();
            }
        }

        private void btnMantAlumnos_Click(object sender, EventArgs e)
        {
            FormCrudAlumno frm = new FormCrudAlumno();
            frm.Show();
            this.Close();
        }
    }
}
