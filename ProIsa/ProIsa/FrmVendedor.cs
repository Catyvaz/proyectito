using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProIsa.Clases;

namespace ProIsa
{
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            string sql = "select * from cliente";
            DataTable tbcliente = Db.Select(sql);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingresar un nombre");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingresar apellido");
                return;
            }
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingresar documento");
                return;
            }
            if (txtLegajo.Text == "")
            {
                MessageBox.Show("Ingresar legajo");
                return;
            }
            string Nombre = "";
            string Apellido = "";
            double Legajo = 0;
            double Documento = 0;
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Legajo = Convert.ToDouble(txtLegajo.Text);
            Documento = Convert.ToDouble(txtDocumento.Text);
            string msj = "";
            Vendedor ven = new Vendedor();
            ven.Insertar(Nombre, Apellido, Legajo, Documento);
            msj = "Vendedor: " + Nombre.ToString() + " " + Apellido.ToString() + ", legajo n°: " + Legajo.ToString() + " guardado con exito";
            MessageBox.Show(msj);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtLegajo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtLegajo.Text = "";
        }
    }
}
