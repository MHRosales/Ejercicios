using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form

    {
        public Form1()
        {

            InitializeComponent();
            label5.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nuevaventana = new Form2();
            nuevaventana.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S = Convert.ToDouble(textBox1.Text);
            double S1 = Convert.ToDouble(textBox2.Text);
            double meses = 12;
            double añosameses = meses * S;
            double suma = añosameses + S1;
            this.label5.Text = suma.ToString();
            label5.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validar.SoloNumeros(e);
           

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Validar.SoloNumeros(e);
           
        }
    }
}
