using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
        double uno;
        double dos;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            uno = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            uno = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            uno = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            dos = double.Parse(Pantalla.Text);

            switch(operacion){
             case "+":
                    resultado = uno + dos;
                    Pantalla.Text = resultado.ToString();
                break;
             case "-":
                resultado = uno - dos;
                Pantalla.Text = resultado.ToString();
                break;
             case "*":
                resultado = uno * dos;
                Pantalla.Text = resultado.ToString();
                break;
              case "/":
                resultado = uno / dos;
                Pantalla.Text = resultado.ToString();
                break;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            uno = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}
