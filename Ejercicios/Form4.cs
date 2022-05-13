using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Ejercicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nuevaventana = new Form5();
            nuevaventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contra; //declaramos variables
            usuario = txtUsuario.Text;//capturamos lo ingresado en el texto
            contra = Encriptar(txtContra1.Text);//Capturamos la contraseña ya encriptada
            int valor = estudiantesD.Login(usuario, contra);//llamamos la clase estudiantes y el método Login
            if (valor != 0)
            {
                this.Hide();
                Form6 ss = new Form6();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Error - Usuario y/o contraseña no existen");
            }

        }
        string key = "DonBoscoAmigo";
        public string Encriptar(string texto)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
