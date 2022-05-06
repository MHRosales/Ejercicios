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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label8.Visible = false; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nuevaventana = new Form1();
            nuevaventana.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salariomes = Convert.ToDouble(textBox1.Text);
            double C1 = Convert.ToDouble(textBox2.Text);
            double C2 = Convert.ToDouble(textBox3.Text);
            double C3 = Convert.ToDouble(textBox4.Text);

            double totalcomision = (C1 + C2 + C3);
            double porcentajecomision = totalcomision * 0.10;
            double salariototal = porcentajecomision + salariomes;

            this.label8.Text = salariototal.ToString();
            label8.Visible=true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
