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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
       
        Random Rnd = new Random();
        int tempmin ;
        int tempmax ;
        int cantidad_dias;
        int[] temperaturasmax;
        int[] temperaturasmin;
        int cuentaerror = 0;
        int cuentaok = 0;
        double promediook ;
        double promedioerror ;



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
         cantidad_dias = int.Parse(Cdias.Text);

         temperaturasmax = new int[cantidad_dias];
         temperaturasmin = new int[cantidad_dias];

         tempmax = int.Parse(Tmax.Text);
         tempmin = int.Parse(Tmin.Text);



         //   DataTemperaturas.ColumnCount = 2;
         //   DataTemperaturas.RowCount = cantidad_dias;


            for (int i = 0; i < temperaturasmax.Length; i++)
            {

                temperaturasmax[i] = Rnd.Next(tempmin, tempmax);
                temperaturasmin[i] = Rnd.Next(tempmin, temperaturasmax[i] + 1);

                DataTemperaturas.Rows.Add(temperaturasmax[i], temperaturasmin[i]);

                if (temperaturasmax[i] ==9 && temperaturasmin[i] == 9)
                {
                    cuentaerror++;

                }
                else
                {
                    cuentaok++;

                }




            }
                promediook = (cuentaok * 100) / cantidad_dias;
                promedioerror = (cuentaerror * 100) / cantidad_dias;

            TotalError.Text = cuentaerror.ToString();
            TotalOk.Text = cuentaok.ToString();
            PorcError.Text = promedioerror.ToString();
            PorcOk.Text = promediook.ToString();






        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu Mn = new Menu();
            Mn.Visible = true;
        }
    }
}
