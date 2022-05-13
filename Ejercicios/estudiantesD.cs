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
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios (Nombre_Usuario, Password) values('{0}', '{1}')",

                usuario, encriptada), Datos.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                if (retorno != 0)
                {
                    MessageBox.Show("Usuario ingresado exitosamente");
                }
                return retorno;
            }
        }
        public static int Login(string usuario, string contra)//aquí están los parámetros enviados desde el formulario Login
        {
        int valor = 0;//recuerdan que en el botón ingresar esperamos un cero o uno...
        MySqlConnection conexion = Datos.ObtenerConexion(); //Abrimos la conexión creada.
        MySqlCommand cmd = new MySqlCommand("SELECT id_usuario FROM usuario WHERE nombre_usuario = '" + usuario + "' AND Contraseña = '" + contra + "' ", conexion);//Realizamos una selección de la tabla usuarios.
        valor = Convert.ToInt32(cmd.ExecuteScalar());//regresa valor diferente de 0 si hay valorv que coincida

         conexion.Close();//Cierra la conexión de la BD
         return valor;//recuerdan que esperamos un valor para validar..taran....
}
}
}
