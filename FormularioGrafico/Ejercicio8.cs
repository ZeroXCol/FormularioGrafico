using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGrafico
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num_gallinas=0, num_dias=0, num_huevos=0, num_total_huevos=0, num_producción=0;
            num_gallinas = int.Parse(textBox1.Text);
            num_dias = int.Parse(textBox2.Text);
            num_huevos = int.Parse(textBox3.Text);

            num_total_huevos = num_gallinas * num_huevos;
            num_producción = num_total_huevos * num_dias;
            String texto = "La producción de huevos para los " + num_dias + "dias indicados es igual a: " + num_producción+ " huevos";
            label_res.Text = texto;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            label_res.Text = String.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu Mn = new Menu();
            Mn.Visible = true;
        }
    }
}
