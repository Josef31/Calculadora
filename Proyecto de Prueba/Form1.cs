using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Prueba
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        public string operacion(int operador)
        {
            double a, b, result;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (operador == '+')
            {
                result = a + b;
                return textBox3.Text = result.ToString();
            }


            else if (operador == '-')
            {

                result = a - b;
                return textBox3.Text = result.ToString();
            }

            else if (operador == '*')
            {
                result = a * b;
                return textBox3.Text = result.ToString();
            }

            else if (operador == '/')
            {
                result = a / b;
                return textBox3.Text = result.ToString();
            }

            return "";

        }

        private void suma_Click(object sender, EventArgs e)
        {
            this.operacion('+');

        }

        private void clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void resta_Click(object sender, EventArgs e)
        {
            this.operacion('-');
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            this.operacion('*');
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            this.operacion('/');
        }

        private void Calculo_Click(object sender, EventArgs e)
        {
            if(operaciones.Text == "Sumar")
            {
                this.operacion('+');
            }

            else if (operaciones.Text == "Restar")
            {
                this.operacion('-');
            }

            else if (operaciones.Text == "Multiplicar")
            {
                this.operacion('*');
            }

            else if (operaciones.Text == "Dividir")
            {
                this.operacion('/');
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede introducir numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47)) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede introducir numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
