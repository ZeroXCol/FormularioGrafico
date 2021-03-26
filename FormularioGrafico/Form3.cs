using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionGrafica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_correctas = 0, num_incorrectas = 0, num_blanco = 0;
            int total_correcta=0, total_incorrecta=0, total_blancos=0;
            num_correctas = int.Parse(textBox1.Text);
            num_incorrectas = int.Parse(textBox2.Text);
            num_blanco = int.Parse(textBox3.Text);

            total_correcta = num_correctas * 4;
            total_incorrecta = num_incorrectas * -1;
            total_blancos = num_blanco * 0;

            label5.Text = "El puntaje del numero de respuestas correctas es :"+ total_correcta+ "\nEl puntaje del numero de respuestas incorrectas es :"+ total_incorrecta+ "\nEl puntaje del numero de respuestas en blanco es: "+ total_blancos;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String RES = "Respuesta:";
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            label5.Text = RES;
        }
    }
}
