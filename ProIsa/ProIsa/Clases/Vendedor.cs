using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProIsa.Clases
{
    public class Vendedor
    {
        public void Insertar(string Nombre, string Apellido, double Legajo, double Documento)
        {
            string sql = "insert into Vendedor (nombre, apellido, legajo, documento)";
            sql = sql + "values (" + "'" + Nombre + "'";
            sql = sql + "," + "'" + Apellido + "'";
            sql = sql + "," + "'" + Legajo + "'";
            sql = sql + "," + "'" + Documento + "'";
            sql = sql + ")";
            Db.Guardar(sql);
        }
    }
}
