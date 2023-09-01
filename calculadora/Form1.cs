using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creado por: Genesis Abigail García Flores, Evi Giselle Esquivel Gonzáles, José Remberto Pérez Aquino y Rodrigo Fernando Córdova Domínguez
        /// Fecha 8/28/2023
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        //Declaracion de variables 

        double Numero1 =0, Numero2=0;
        string operador = "";



        private void btnClear_Click(object sender, EventArgs e)
        {

            txtShow.Text = "0";
            Numero1 = 0;
            Numero2 = 0;
            operador = "";
        }
        private void btn1by1_Click(object sender, EventArgs e)
        {

            if (txtShow.TextLength == 1) txtShow.Text = "0";
            else txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1);

        }

        private void ObtenerValor(string operador)
        {

            Numero1 = Convert.ToDouble(txtShow.Text);
            lblHistorial.Text = txtShow.Text + operador;
            txtShow.Text = "0";
        
        
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "1";
        }

       

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "2";
        }

        

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "3";
        }

        

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "4";
        }

       

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "9";
        }

       
        private void btn0_Click(object sender, EventArgs e)
        {

            txtShow.Text = txtShow.Text + "0";

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        
        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double porcentaje = Convert.ToDouble(txtShow.Text) / 100;
            txtShow.Text = porcentaje.ToString();
            ObtenerValor(operador);
        }

        // ...

        private bool resultadoMostrado = false;

        private void btnDE_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                txtShow.Text = "0";
                resultadoMostrado = false;
            }
            else
            {
                if (txtShow.Text.Length > 1)
                {
                    txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1);
                }
                else
                {
                    txtShow.Text = "0";
                }
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtShow.Text);

            switch (operador)
            {
                case "+":
                    txtShow.Text = $"{Numero1 + Numero2}";
                    break;
                case "-":
                    txtShow.Text = $"{Numero1 - Numero2}";
                    break;
                case "*":
                    txtShow.Text = $"{Numero1 * Numero2}";
                    break;
                case "/":
                    txtShow.Text = $"{Numero1 / Numero2}";
                    break;
            }

            // Actualizar historial con la operación realizada
            lblHistorial.Text += Numero2 + " " + "=" + " " + txtShow.Text + "\n";

            // Limpiar variables después de la operación
            Numero1 = 0;
            Numero2 = 0;
            operador = "";
            resultadoMostrado = true;
        }

        // ...



    }

}
