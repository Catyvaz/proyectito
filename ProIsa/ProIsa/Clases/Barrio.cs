using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProIsa.Clases
{
    public class Barrio
    {
        public void Insertar(string nombre)
        {
            string sql = "insert into Barrio (nombre)";
            sql = sql + "values (" + "'" + nombre + "'";
            sql = sql + ")";
            Db.Guardar(sql);
        }
    }
}
