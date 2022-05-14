using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = float.Parse(textBox1.Text);
            valor2 = float.Parse(textBox2.Text);

            resultado = valor1 + valor2;

            Resultado.Text = resultado.ToString();
        }

        private void btSubtrai_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;

            valor1 = Convert.ToDecimal(textBox1.Text);
            valor2 = Convert.ToDecimal(textBox2.Text);

            resultado = valor1 - valor2;

            Resultado.Text = resultado.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btMulti_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 * valor2;

            Resultado.Text = resultado.ToString();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

           if(valor2 == 0)
            {
                resultado = 0;
            }
           else
            resultado = valor1 / valor2;

            Resultado.Text = resultado.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
