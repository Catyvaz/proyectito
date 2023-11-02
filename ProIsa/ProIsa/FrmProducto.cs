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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            string sql = "select * from producto";
            DataTable tbproducto = Db.Select(sql);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text == "")
            {
                MessageBox.Show("Ingresar un nombre");
                return;
            }
            if(txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio");
                return;
            }
            string Nombre = "";
            Double Precio = 0;
            Nombre = TxtNombre.Text;
            Precio = Convert.ToDouble(txtPrecio.Text);
            string msj = "";
            Producto pro = new Producto();
            pro.Insertar(Nombre, Precio);
            msj = "Producto guardado";
            MessageBox.Show(msj);
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void gbxProducto_Enter(object sender, EventArgs e)
        {

        }
    }
}
