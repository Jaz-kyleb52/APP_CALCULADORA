using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operadores;
        public Form1()
        {
            InitializeComponent();
        }

        ClsSuma ClsSuma = new ClsSuma();
        ClsResta ClsResta = new ClsResta();
        ClsMult ClsMult = new ClsMult();
        ClsDiv ClsDiv = new ClsDiv();


        #region tecladoNumerico
        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "3";
        }

        //el nombre del boton 4 no se guardo como btnN4
        private void button4_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxPantalla.Text = tbxPantalla.Text + ".";
        }
        #endregion 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region BotonesOperadores
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operadores = "+";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operadores = "-";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operadores = "*";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operadores = "/";
            primero = double.Parse(tbxPantalla.Text);
            tbxPantalla.Clear();
        }

        #endregion


        #region BotonIgual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxPantalla.Text);

            double Sum;
            double Rest;
            double Mult;
            double Div;

            switch (operadores)
            {
                case "+":
                    Sum = ClsSuma.Sumar((primero), (segundo));
                    tbxPantalla.Text = Sum.ToString();
                    break;

                case "-":
                    Rest = ClsResta.Restar((primero), (segundo));
                    tbxPantalla.Text = Rest.ToString();
                    break;

                case "*":
                    Mult = ClsMult.Multiplicar((primero), (segundo));
                    tbxPantalla.Text = Mult.ToString();
                    break;

                case "/":
                    Div = ClsDiv.Dividir((primero), (segundo));
                    tbxPantalla.Text = Div.ToString();
                    break;
            }
        }
        #endregion



        private void btnCE_Click(object sender, EventArgs e)
        {
            tbxPantalla.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxPantalla.Text.Length == 1)
                tbxPantalla.Text = "";
            else
                tbxPantalla.Text = tbxPantalla.Text.Substring(0, tbxPantalla.Text.Length - 1);
        }
    }
}
