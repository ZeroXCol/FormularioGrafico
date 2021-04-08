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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ComboOpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double Numero = double.Parse(TxtNum1.Text);
                

                if (ComboOpc.SelectedIndex == 0)
                {
                    double Raiz = 0;

                    Raiz = Math.Sqrt(Numero);

                    TxtResultado.Text = Raiz.ToString();


                }
                else if (ComboOpc.SelectedIndex == 1)
                {
                    double Seno = 0;

                    Seno = Math.Sin(Numero);

                    TxtResultado.Text = Seno.ToString();


                }
                else if (ComboOpc.SelectedIndex == 2)
                {
                    double Coseno = 0;

                    Coseno = Math.Cos(Numero);


                    TxtResultado.Text = Coseno.ToString();


                }
                else if (ComboOpc.SelectedIndex == 3)
                {
                    double Tangente = 0;

                    Tangente = Math.Tan(Numero);

                    TxtResultado.Text = Tangente.ToString();

                }
                else if (ComboOpc.SelectedIndex == 4)
                {
                    double ValorAbs = 0;

                    ValorAbs = Math.Abs(Numero);

                    TxtResultado.Text = ValorAbs.ToString();

                }
                else if (ComboOpc.SelectedIndex == 5)
                {
                    double Arcotangente = 0;

                    Arcotangente = Math.Atan(Numero);

                    TxtResultado.Text = Arcotangente.ToString();

                }
                else if (ComboOpc.SelectedIndex == 6)
                {
                    double RaizCub = 0;

                    RaizCub = Math.Cosh(Numero);

                    TxtResultado.Text = RaizCub.ToString();

                }
                else if (ComboOpc.SelectedIndex == 7)
                {
                    double Logaritmo = 0;

                    Logaritmo = Math.Log(Numero);

                    TxtResultado.Text = Logaritmo.ToString();

                }
                else if (ComboOpc.SelectedIndex == 8)
                {
                    double LogaritmoB10 = 0;

                    LogaritmoB10 = Math.Log10(Numero);

                    TxtResultado.Text = LogaritmoB10.ToString();

                }
                else if (ComboOpc.SelectedIndex == 9)
                {
                    double Cuadrado = 0;

                    Cuadrado = Math.Pow(Numero, 2);

                    TxtResultado.Text = Cuadrado.ToString();

                }


            }

            catch (Exception)
            {
                MessageBox.Show("Por favor rellena todos los datos");


                throw;
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu Mn = new Menu();
            Mn.Visible = true;
        }
    }
}
