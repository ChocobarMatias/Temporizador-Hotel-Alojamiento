using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TEMPORIZADOR : Form
    {
        public TEMPORIZADOR()
        {
            InitializeComponent();
        }
        // Variables globales contadoras
        int hora = 0;
        int minuto = 0;
        int segundo = 0;
        string min;
        string seg;
        string hor;
        // Funcion que se ejecuta en cada ciclo del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo -= 1;
            hor = hora.ToString();
            min = minuto.ToString();
            seg = segundo.ToString();

            if (hora < 10)
            {
                hor ="0" + hora.ToString();// coloca el 0 antes del 10 en los horas
            }

            if (minuto < 10)
            {
                min = "0" + minuto.ToString();// coloca el 0 antes del 10 en los minutos
            }
            if (segundo < 10)
            {
                seg = "0" + segundo.ToString();
            }

            if (hora > 0 && minuto == 0 && segundo == 0)
            {
                segundo = 60;
                hora -= 1;
                minuto = 59;
               // MessageBox.Show("entre 1");
            }

            if (segundo == 0 && minuto > 0)
            {
                minuto -= 1;
                segundo = 60;
                //MessageBox.Show("entre 2");
            }
            if (hora == 0 && minuto == 10 && segundo == 59)
            {
                MessageBox.Show(" Informar que en 10 minutos se cumple el Tiempo en la Habitacion", "Aviso de tiempo por cumplir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // MessageBox.Show("entre 3");


            if (minuto == 0 && segundo == 0 && hora == 0)
            {
                timer1.Stop();
                MessageBox.Show(" Tiempo Cumplido", "Tiempo 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                label1.Text = Convert.ToString(hor + ":" + min + ":" + seg); // Actualizamos el valor de la Etiqueta

        }
        // Funcion que se ejecuta al dar click en iniciar el timer
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (button1.Text == "INICIAR")
                {
                    if (radioButton1.Checked == true)
                    {
                        timer1.Start(); // Funcion iniciar Timer
                        button1.ForeColor = Color.Firebrick;
                        hora = 1;
                        minuto = 0;
                        segundo = 1;
                        button1.Text = "Restablecer";
                        button1.Enabled = true;
                }
                    if (radioButton2.Checked == true)
                    {
                        timer1.Start(); // Funcion iniciar Timer
                        button1.ForeColor = Color.Firebrick;
                        hora = 2;
                        minuto = 0;
                        segundo = 1;
                        button1.Text = "Restablecer";
                        button1.Enabled = true;
                    }
                }
                else
                {
                    timer1.Stop();
                    hora = 0;
                    minuto = 0;
                    segundo = 0;
                    label1.Text = "00:00:00";
                    button1.ForeColor = Color.ForestGreen;
                    button2.Enabled = false;
                    button2.ForeColor = Color.RoyalBlue;
                    button2.Text = "Parar";
                    button1.Text = "Iniciar";
                }
         
        }
        // Funcion que se ejecuta al dar click al boton detener
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text== "DETENER")
            {
                timer1.Stop(); // Funcion detener Timer
                button2.ForeColor = Color.DarkOrange;
                button2.Text = "REANUDAR";
            }
            else
            {
                timer1.Start(); // Funcion detener Timer
                button2.ForeColor = Color.OrangeRed;
                button2.Text = "DETENER";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
