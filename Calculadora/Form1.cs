using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        private void btnResta_Click(object sender, EventArgs e)
        {
            bool n1 = ValidarNumero1(txtNum1.Text);
            bool n2 = ValidarNumero2(txtNum2.Text);

            if (n1 == true && n2 == true)
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = 0;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            bool n1 = ValidarNumero1(txtNum1.Text);
            bool n2 = ValidarNumero2(txtNum2.Text);

            if (n1 == true && n2 == true)
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = 0;
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            bool n1 = ValidarNumero1(txtNum1.Text);
            bool n2 = ValidarNumero2(txtNum2.Text);

            if (n1 == true && n2 == true)
            {
                if (num2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero\nIngrese otro numero", "Error al dividir");
                    lblNum2.Text = "Ingrese otro numero!";
                }
                else
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString();
                    lblNum2.Text = string.Empty;
                }
            }
            else
            {
                resultado = 0;
                txtResultado.Text = resultado.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            bool n1 = ValidarNumero1(txtNum1.Text);
            bool n2 = ValidarNumero2(txtNum2.Text);

            if (n1 == true && n2 == true)
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                resultado = 0;
                txtResultado.Text = resultado.ToString();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            bool n1 = ValidarNumero1(txtNum1.Text);

            if (n1 == true)
            {
                resultado = Math.Sqrt(num1);
                txtResultado.Text = resultado.ToString();
                lblRaiz.Text = "Raiz cuadrada del primer numero";
            }
            else
            {
                resultado = 0;
                txtResultado.Text = resultado.ToString();
                lblRaiz.Text = string.Empty;
            }
        }

        //BOTON LIMPIAR
        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtResultado.Text = string.Empty;
            lblNum1.Text = string.Empty;
            lblNum2.Text = string.Empty;
            lblRaiz.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarNumero1(string n) {
            try
            {
                num1 = double.Parse(n);
                lblNum1.Text = string.Empty;
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: No debe ingresar texto", "Error en el primer numero");
                //lblNum1.Text = error.Message;
                lblNum1.Text = "Ingrese otro numero!";
                return false;
            }
        }
        private bool ValidarNumero2(string n)
        {
            try
            {
                num2 = double.Parse(n);
                lblNum2.Text = string.Empty;
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: No debe ingresar texto", "Error en el segundo numero");
                lblNum2.Text = "Ingrese otro numero!";
                return false;
            }
        }
    }
}
