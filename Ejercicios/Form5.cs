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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nuevaventana = new Form4();
            nuevaventana.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario, encriptada;
            if (txtUsuario.Text.Trim() != "" && txtContra1.Text == txtContra2.Text)
            {
                usuario = txtUsuario.Text;
                encriptada = Encriptar(txtContra1.Text);
                estudiantesD.AgregarUsuario(usuario, encriptada);
            }
            else
            {
                MessageBox.Show("datos incorrectos, Por favor verificar");
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

            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0,

            Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }
    }
}
