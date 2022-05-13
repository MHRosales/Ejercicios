using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Datos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=rosales20120208; Uid =root; pwd =info2022; ");
            conectar.Open();
            return conectar;
        }
    }
}
