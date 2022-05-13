using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ejercicios
{
    public class estudiantesD
    {
        public static int AgregarUsuario(string usuario, string encriptada)
        {
            {
                int retorno = 0;
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuario (Nombre_Usuario, Contraseña) values('{0}', '{1}')",

                usuario, encriptada), Datos.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                if (retorno != 0)
                {
                    MessageBox.Show("Usuario ingresado exitosamente");
                }
                return retorno;
            }
        }
}
}
