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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void ComboOpc_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
            double Numero1 = double.Parse(TxtNum1.Text);
            double Numero2 = double.Parse(TxtNum2.Text);

            if (ComboOpc.SelectedIndex == 0)
            {
                double Suma = 0;

                Suma = Numero1 + Numero2;

                TxtResultado.Text = Suma.ToString();


            }else if(ComboOpc.SelectedIndex == 1)
            {
                double Resta = 0;

                Resta = Numero1 - Numero2;

                TxtResultado.Text = Resta.ToString();


            }
            else if (ComboOpc.SelectedIndex == 2)
            {
                double Multiplicacion = 0;
                Multiplicacion = Numero1 * Numero2;


                TxtResultado.Text = Multiplicacion.ToString();


            }
            else if (ComboOpc.SelectedIndex == 3)
            {
                double Division = 0;

                Division = Numero1 / Numero2;

                TxtResultado.Text = Division.ToString();


            }

            }

             catch (Exception)
             {
                MessageBox.Show("Por favor rellena todos los datos");


             throw;
             }

        }
           
    }
}
