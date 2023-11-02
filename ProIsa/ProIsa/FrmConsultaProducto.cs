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
    public partial class FrmConsultaProducto : Form
    {
        public FrmConsultaProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProducto_Load(object sender, EventArgs e)
        {
            string sql = "select * from producto";
            DataTable tbproducto = Db.Select(sql);
            dgvGrilla.DataSource = tbproducto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          //  Producto pro = new Producto();
            //string nombre = txtNombre.Text;
            //DataTable tb = pro.Buscar(nombre);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //FrmProducto frm = new FrmProducto();
          //  frm.Show();
        }

        private void txtBarras_TextChanged(object sender, EventArgs e)
        {
          //  string codigo = txtBarras.Text;
          //  Producto pro = new Producto();
            //DataTable tabla = pro.BuscarBarras(codigo);
        }
    }
}
