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
    public partial class FrmBarrio : Form
    {
        public FrmBarrio()
        {
            InitializeComponent();
        }

        private void FrmBarrio_Load(object sender, EventArgs e)
        {
            string sql = "select * from producto";
            DataTable tbBarrio = Db.Select(sql);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             if (txtNombre.Text == "")
             {
                 MessageBox.Show("Ingresar un nombre");
                 return;
             }
            string Nombre = "";
            Nombre = txtNombre.Text;
            string msj = "";
            Barrio pro = new Barrio();
            pro.Insertar(Nombre);
            msj = "Producto guardado";
            MessageBox.Show(msj);

            txtNombre.Text = "";
        }
    }
}
