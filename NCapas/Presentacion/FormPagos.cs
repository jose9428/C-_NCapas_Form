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
    public partial class FormPagos : Form
    {
        public static string idAlumno;
        public static string nomAlu;

        private NPago objPago;

        public FormPagos()
        {
            InitializeComponent();
            this.CenterToScreen();

            CargarDatos();
        }

        public void CargarDatos()
        {
            txtCodigo.Text = idAlumno;
            txtNombre.Text = nomAlu;

            double total = 0;

            objPago = new NPago();

            GridTable.Rows.Clear();
            foreach (Pagos a in objPago.ListarPagoPorAlumno(idAlumno))
            {
                total += (double)a.monto;
                GridTable.Rows.Add(a.cuota, a.ciclo, a.monto, a.fecha.ToString("dd/MM/yyyy"));
            }

            txtTotal.Text = total.ToString();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
