using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainTraining
{
    public partial class Form1 : Form
    {
        static Random aleatorio = new Random();
        static int segundos = 30;
        static int op1 = 0;
        static int op2 = 0;
        static int opera = 0;
        static int puntos=0;
        static int diff = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dificultad_ValueChanged(object sender, EventArgs e)
        {
            diff= ((int)Dificultad.Value);
        }

        private void contador_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            contador.Text = Convert.ToString(segundos);
            if (segundos == 20)
            {
                contador.BackColor = Color.Yellow;
            }
            if (segundos == 10)
            {
                contador.BackColor = Color.Orange;
            }
            if (segundos <= 0)
            {
                fin();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void respuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                int numUsuario = Convert.ToInt32(respuesta.Text);
                if (numUsuario == calculaResultado())
                {
                    puntos++;
                    labelPuntos.Text = Convert.ToString(puntos);
                }
                else {
                    puntos--;
                    labelPuntos.Text = Convert.ToString(puntos);
            }
                reset();
            }           

        }

        private void respuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void fin() {
            timer1.Enabled = false;
            contador.BackColor = Color.Red;
            button1.Enabled = false;
            respuesta.Enabled = false;
        }

        private void reset() {
            respuesta.ResetText();
            timer1.Enabled = true;
            switch (diff) {
                case 1: diff1();
                    break;
                case 2: diff2();
                    break;
                case 3: diff3();
                    break;
            }

            num1.Text = Convert.ToString(op1);
            num2.Text = Convert.ToString(op2);

            opera = aleatorio.Next(1, 4);

            switch (opera)
            {
                case 1:
                    operador.Text = "+";
                    break;
                case 2:
                    operador.Text = "-";
                    break;
                case 3:
                    operador.Text = "*";
                    break;
            }
        }

        private int calculaResultado() {
            int resultado = 0;
            switch (opera)
            {
                case 1:
                    resultado = op1 + op2;
                    break;
                case 2:
                    resultado = op1 - op2;
                    break;
                case 3:
                    resultado = op1 * op2;
                    break;
            }
            return resultado;
        }

        private void diff1()
        {
            op1 = aleatorio.Next(1, 6);
            op2 = aleatorio.Next(1, 6);
        }

        private void diff2()
        {
            op1 = aleatorio.Next(1, 10);
            op2 = aleatorio.Next(1, 10);
        }

        private void diff3()
        {
            op1 = aleatorio.Next(1, 20);
            op2 = aleatorio.Next(1, 20);
        }















    }

  

}
