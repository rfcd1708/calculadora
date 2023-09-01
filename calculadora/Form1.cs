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
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    

        //Declaracion de variables 

        double Numero1 =0, Numero2=0;
        string operador = "";


        //el boton elimina todo los digitos que se encuentre en el txtShow

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtShow.Text = "0";
            Numero1 = 0;
            Numero2 = 0;
            operador = "";
        }

        // el boton elimina digito por digito, lo que se encuentre en el txtShow
        private void btn1by1_Click(object sender, EventArgs e)
        {

            if (txtShow.TextLength == 1) txtShow.Text = "0";
            else txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1);

        }

        // la funcion almacena el valor actual y el operador seleccionado
        private void ObtenerValor(string operador)
        {

            Numero1 = Convert.ToDouble(txtShow.Text);
            lblHistorial.Text = txtShow.Text + operador;
            txtShow.Text = "0";
        
        
        }

        // maneja el evento de dar clic en el boton 1 y agrega el digito al txtShow
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "1";
        }


        // maneja el evento de dar clic en el boton 2 y agrega el digito al txtShow

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "2";
        }


        // maneja el evento de dar clic en el boton 3 y agrega el digito al txtShow

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "3";
        }


        // maneja el evento de dar clic en el boton 4 y agrega el digito al txtShow

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "4";
        }


        // maneja el evento de dar clic en el boton 5 y agrega el digito al txtShow

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "5";
        }

        // maneja el evento de dar clic en el boton 6 y agrega el digito al txtShow

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "6";
        }

        // maneja el evento de dar clic en el boton 7 y agrega el digito al txtShow

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "7";
        }


        // maneja el evento de dar clic en el boton 8 y agrega el digito al txtShow

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "8";
        }

        // maneja el evento de dar clic en el boton 9 y agrega el digito al txtShow

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0") txtShow.Text = "";
            txtShow.Text = txtShow.Text + "9";
        }

        // maneja el evento de dar clic en el boton 0 y agrega el digito al txtShow

        private void btn0_Click(object sender, EventArgs e)
        {

            txtShow.Text = txtShow.Text + "0";

        }

        //Maneja el evento cuando se le da clic al boton de suma y realiza la operacion con los números asignados

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }


        //Maneja el evento cuando se le da clic al boton de resta y realiza la operacion con los números asignados

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        //Maneja el evento cuando se le da clic al boton de multiplicación y realiza la operacion con los números asignados

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }

        //Maneja el evento cuando se le da clic al boton de division y realiza la operacion con los números asignados

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            Numero1 = Convert.ToDouble(txtShow.Text);
            ObtenerValor(operador);
        }


        //Maneja el evento cuando se le da clic al boton de porcentaje y realiza la operacion con los números asignados

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double porcentaje = Convert.ToDouble(txtShow.Text) / 100;
            txtShow.Text = porcentaje.ToString();
            ObtenerValor(operador);
        }

        // ...

        private bool resultadoMostrado = false;

        //Maneja el evento cuando se preciona el boton DE, cambiando de signo el digito que se encuentre en el txtShow 

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



        //Cambia el signo del digito ya sea positivo o negativo
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShow.Text))

            {
                double num = double.Parse(txtShow.Text);
                num = -num;
                txtShow.Text = num.ToString();
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Agrega el punto al txtShow
            txtShow.Text += ".";

        }

        //Maneja el evento cuando se hace clic en el boton de igual y muestra el resultado en el txtShow

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
