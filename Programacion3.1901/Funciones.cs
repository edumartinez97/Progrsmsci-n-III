using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3._1901
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            //Numero1TextBox.Text = string.Empty;
            Numero2TextBox.Text = "";
            ResultadoLabel.Text = "";
        }

        private int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        private int Restar(int num1, int num2)
        {
            int valorResta = num1 - num2;

            return valorResta;
        }

        private int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        private int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Sumar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Restar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }
    }
}
