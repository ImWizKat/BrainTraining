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

        static int segundos = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Dificultad_ValueChanged(object sender, EventArgs e)
        {

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
            if (segundos == 0)
            {
                timer1.Enabled = false;
                contador.BackColor = Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            segundos = 30;
            timer1.Enabled = true;
            Random aleatorio = new Random();
            num1.Text = Convert.ToString(aleatorio.Next(1,10));
            num2.Text = Convert.ToString(aleatorio.Next(1, 10));

            int opera = aleatorio.Next(1, 4);

            switch (opera) {
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

        private void respuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cuando presione enter que cambien cosas?¿?¡
            if (e.KeyChar.Equals(Keys.Enter))
            {
                MessageBox.Show("Enter pressed");
            }
            

        }
    }
}
