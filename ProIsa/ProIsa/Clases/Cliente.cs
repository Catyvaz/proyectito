using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProIsa.Clases
{
    public class Cliente
    {
        public void Insertar(string Nombre, string Apellido, double Documento, double Telefono)
        {
            string sql = "insert into cliente (nombre, apellido, documento, telefono)";
            sql = sql + "values (" + "'" + Nombre + "'";
            sql = sql + "," + "'" + Apellido + "'";
            sql = sql + "," + "'" + Documento + "'";
            sql = sql + "," + "'" + Telefono + "'";
            sql = sql + ")";
            Db.Guardar(sql);
        }
    }
}
