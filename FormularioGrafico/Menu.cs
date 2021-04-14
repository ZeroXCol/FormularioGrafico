using FormularioGrafico;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnEj1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ejercicio1 Ej = new Ejercicio1();
            Ej.Visible = true;



        }

        private void BtnEj2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Ejercicio2 Ej2 = new Ejercicio2();
            Ej2.Visible = true;
        }

        private void Ej3_Click(object sender, EventArgs e)
        {
            this.Close();
            Ejercicio3 Ej3 = new Ejercicio3();
            Ej3.Visible = true;
        }

        private void Ej4_Click(object sender, EventArgs e)
        {
            this.Close();
            Ejercicio4 Ej4 = new Ejercicio4();
            Ej4.Visible = true;
        }

        private void Ej5_Click(object sender, EventArgs e)
        {
            this.Close();
            Ejercicio5 Ej5 = new Ejercicio5();
            Ej5.Visible = true;
        }

        private void Ej6_Click(object sender, EventArgs e)
        {

        }

        private void Ej8_Click(object sender, EventArgs e)
        {
            this.Close();
            Ejercicio8 Ej8 = new Ejercicio8();
            Ej8.Visible = true;
        }

        private void Ej9_Click(object sender, EventArgs e)
        {
            this.Close();
            Ejercicio9 Ej9 = new Ejercicio9();
            Ej9.Visible = true;
        }

        private void Ej10_Click(object sender, EventArgs e)
        {
            this.Close();
             Ejercicio10 Ej10= new Ejercicio10();
             Ej10.Visible = true;
        }
    }
}
