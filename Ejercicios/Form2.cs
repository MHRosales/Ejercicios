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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 nuevaventana = new Form6();
            nuevaventana.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capital = Convert.ToDouble(textBox1.Text);
            double ganancias = capital * 0.025;
            double ganancias12 = ganancias * 12;

            double total = capital + ganancias12;
            this.label4.Text = total.ToString();
            label4.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
