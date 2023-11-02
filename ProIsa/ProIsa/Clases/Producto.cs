using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProIsa.Clases
{
    public class Producto
    {
        public void Insertar(string nombre, double precio)
        {
            string sql = "insert into producto (nombre, precio)";
            sql = sql + "values (" + "'" + nombre + "'";
            sql = sql + "," + precio.ToString();
            sql = sql + ")";
            Db.Guardar(sql);
        }

        public DataTable Buscar (string nombre)
        {
            string sql = "select CodProducto, nombre, precio";
            sql = " from Producto";
            return Db.Select(sql);
        }

        public DataTable BuscarBarras(string codigo)
        {
            string sql = "select CodProducto, nombre, precio";
            sql = " from producto";
            sql = sql + " where codBarra = " + "'" + codigo + "'";
            return Db.Select(sql);
        }

        public DataTable BuscarporID(int CodProducto)
        {
            string sql = "select CodProducto, nombre, precio, CodBarras";
            sql = " from producto";
            sql = sql + " where codProducto = " + "'" + CodProducto + "'";
            return Db.Select(sql);
        }


    }
}
