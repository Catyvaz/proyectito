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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
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
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingresar telefono");
                return;
            }
            string Nombre = "";
            string Apellido = "";
            double Documento = 0;
            double Telefono = 0;
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Documento = Convert.ToDouble(txtDocumento.Text);
            Telefono = Convert.ToDouble(txtTelefono.Text);
            string msj = "";
            Cliente cli = new Cliente();
            cli.Insertar(Nombre, Apellido, Documento, Telefono);
            msj = "Cliente " + "'" + Nombre.ToString() + " " + Apellido.ToString() + "'" + " guardado correctamente";
            MessageBox.Show(msj);

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
        }

        private void gbxCliente_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void cbxBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
