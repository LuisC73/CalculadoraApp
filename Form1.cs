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
        double numero1 = 0, numero2 = 0;
        char operador;  

        public Form1()
        {
            InitializeComponent();
        }



        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtResultadoFinal.Text == "0")
                txtResultadoFinal.Text = "";

            txtResultadoFinal.Text += boton.Text;

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultadoFinal.Text);

            if(operador == '+')
            {
                txtResultadoFinal.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtResultadoFinal.Text);
                
            }else if(operador == '-')
            {
                txtResultadoFinal.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            }else if(operador == 'X')
            {
                txtResultadoFinal.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            }else if(operador == '÷')
            {
                txtResultadoFinal.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            }else if(operador == '%')
            {
                txtResultadoFinal.Text = (numero1 % numero2).ToString();
                numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            }

            txtResultadoAnterior.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtResultadoFinal.Text.Length > 1)
            {
                txtResultadoFinal.Text = txtResultadoFinal.Text.Substring(0, txtResultadoFinal.Text.Length - 1);
            }
            else
            {
                txtResultadoFinal.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtResultadoFinal.Text = "0";
            txtResultadoAnterior.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultadoFinal.Text.Contains("."))
            {
                txtResultadoFinal.Text += ".";
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            numero1 *= -1;
            txtResultadoFinal.Text = numero1.ToString();
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultadoFinal.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                txtResultadoFinal.Text = numero1.ToString();
            }
            else if(operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                txtResultadoFinal.Text = numero1.ToString();
            }
            else
            {
                txtResultadoAnterior.Text = txtResultadoFinal.Text + " " + operador;
                txtResultadoFinal.Text = "0";
            }

            
        }

    }
}
