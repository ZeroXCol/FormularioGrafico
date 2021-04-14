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
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedula, nombre;
            int codigo, salario, auxilio = 0, dias, sueldo, hed, hen, hef, horas_nocturnas;
            int salud, pension, prestamos, fondo_solidaridad = 0, total_deducido, neto_pagado;
            int vhed, vhen, vhef, recargo, total_devengado;
            codigo = int.Parse(textBox1.Text);
            nombre = textBox2.Text;
            cedula = textBox3.Text;
            salario = int.Parse(textBox4.Text);
            dias = int.Parse(textBox5.Text);
            hed = int.Parse(textBox6.Text);
            hen = int.Parse(textBox7.Text);
            hef = int.Parse(textBox8.Text);
            horas_nocturnas = int.Parse(textBox9.Text);

            if (salario <= 1817052)
            {
                auxilio = 106454 / 30 * dias;
            }
            textBox10.Text = auxilio.ToString();
            textBox10.Enabled = false;
            sueldo = salario / 30 * dias;
            textBox11.Text = sueldo.ToString();
            textBox11.Enabled = false;
            vhed = Convert.ToInt32(salario / 240 * hed * 1.25);
            textBox12.Text = vhed.ToString();
            textBox12.Enabled = false;
            vhen = Convert.ToInt32(salario / 240 * hed * 1.75);
            textBox13.Text = vhen.ToString();
            textBox13.Enabled = false;
            vhef = Convert.ToInt32(salario / 240 * hed * 2);
            textBox14.Text = vhef.ToString();
            textBox14.Enabled = false;
            recargo = Convert.ToInt32(salario / 240 * horas_nocturnas * 0.35);
            textBox15.Text = recargo.ToString();
            textBox15.Enabled = false;
            total_devengado = auxilio + sueldo + vhed + vhen + vhef + recargo;
            textBox16.Text = total_devengado.ToString();
            textBox16.Enabled = false;
            salud = (total_devengado - auxilio) * 4 / 100;
            textBox17.Text = salud.ToString();
            textBox17.Enabled = false;
            pension = (total_devengado - auxilio) * 4 / 100;
            textBox18.Text = pension.ToString();
            textBox18.Enabled = false;
            prestamos = Convert.ToInt32(sueldo * 0.12);
            textBox19.Text = prestamos.ToString();
            textBox19.Enabled = false;
            if (salario >= 3365704)
            {
                fondo_solidaridad = Convert.ToInt32(salario * 0.01);
            }
            textBox20.Text = fondo_solidaridad.ToString();
            textBox20.Enabled = false;
            total_deducido = salud + pension + prestamos + fondo_solidaridad;
            textBox21.Text = total_deducido.ToString();
            textBox21.Enabled = false;
            neto_pagado = total_devengado - total_deducido;
            textBox22.Text = neto_pagado.ToString();
            textBox22.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
            textBox11.Text = String.Empty;
            textBox12.Text = String.Empty;
            textBox13.Text = String.Empty;
            textBox14.Text = String.Empty;
            textBox15.Text = String.Empty;
            textBox16.Text = String.Empty;
            textBox17.Text = String.Empty;
            textBox18.Text = String.Empty;
            textBox19.Text = String.Empty;
            textBox20.Text = String.Empty;
            textBox21.Text = String.Empty;
            textBox22.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu Mn = new Menu();
            Mn.Visible = true;
        }
    }
}
