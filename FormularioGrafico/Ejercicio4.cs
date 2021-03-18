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
    public partial class Ejercicio4 : Form
    {
        double Base;
        double Porcentaje;
        double Calculo_Salario;
        double Bonificacion;
        double Salario_Total;
        int Lunes;
        int Martes;
        int Miercoles;
        int Jueves;
        int Viernes;
        int Sabado;
        int Cantidad_acumulada;
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Lunes = int.Parse(TextLunes.Text);
            Martes = int.Parse(TextMartes.Text);
            Miercoles = int.Parse(TextMiercoles.Text);
            Jueves = int.Parse(TextJueves.Text);
            Viernes = int.Parse(TextViernes.Text);
            Sabado = int.Parse(TextSabado.Text);

            Cantidad_acumulada = Lunes + Martes + Miercoles + Jueves + Viernes + Sabado;

            if (Cantidad_acumulada > 100 && Cantidad_acumulada < 200)
            {
                Base = 2;
                Porcentaje = 10;
                Calculo_Salario = Base * Cantidad_acumulada;
                Bonificacion = Calculo_Salario * 0.10;                
                Salario_Total = Calculo_Salario + Bonificacion;

                Bbase.Text = Base.ToString();
                Bporcentual.Text = Porcentaje.ToString();
                Tproduccion.Text = Cantidad_acumulada.ToString();
                Bproducto.Text = Calculo_Salario.ToString();
                Bsalario.Text = Bonificacion.ToString();
                Stotal.Text = Salario_Total.ToString();
                





            }
            else if (Cantidad_acumulada > 200 && Cantidad_acumulada < 300)
            {
                Base = 2.5;
                Porcentaje = 12;
                Calculo_Salario = Base * Cantidad_acumulada;
                Bonificacion = Calculo_Salario * 0.12;
                Salario_Total = Calculo_Salario + Bonificacion;

                Bbase.Text = Base.ToString();
                Bporcentual.Text = Porcentaje.ToString();
                Tproduccion.Text = Cantidad_acumulada.ToString();
                Bproducto.Text = Calculo_Salario.ToString();
                Bsalario.Text = Bonificacion.ToString();
                Stotal.Text = Salario_Total.ToString();


                


            }
            else if (Cantidad_acumulada >= 300 && Cantidad_acumulada < 400)
            {

                Base = 3;
                Porcentaje = 14;
                Calculo_Salario = Base * Cantidad_acumulada;
                Bonificacion = Calculo_Salario * 0.14;
                Salario_Total = Calculo_Salario + Bonificacion;

                Bbase.Text = Base.ToString();
                Bporcentual.Text = Porcentaje.ToString();
                Tproduccion.Text = Cantidad_acumulada.ToString();
                Bproducto.Text = Calculo_Salario.ToString();
                Bsalario.Text = Bonificacion.ToString();
                Stotal.Text = Salario_Total.ToString();
                

            }
            else if (Cantidad_acumulada > 400)
            {

                Base = 3.5;
                Porcentaje = 16;
                Calculo_Salario = Base * Cantidad_acumulada;
                Bonificacion = Calculo_Salario * 0.16;
                Salario_Total = Calculo_Salario + Bonificacion;

                Bbase.Text = Base.ToString();
                Bporcentual.Text = Porcentaje.ToString();
                Tproduccion.Text = Cantidad_acumulada.ToString();
                Bproducto.Text = Calculo_Salario.ToString();
                Bsalario.Text = Bonificacion.ToString();
                Stotal.Text = Salario_Total.ToString();
                


            }
            else if (Cantidad_acumulada < 100 && Cantidad_acumulada > 0)
            {
                Base = 2;
                Porcentaje = 0;
                Calculo_Salario = Base * Cantidad_acumulada;
                Bonificacion = Calculo_Salario * 0;
                Salario_Total = Calculo_Salario + Bonificacion;

                Bbase.Text = Base.ToString();
                Bporcentual.Text = Porcentaje.ToString();
                Tproduccion.Text = Cantidad_acumulada.ToString();
                Bproducto.Text = Calculo_Salario.ToString();
                Bsalario.Text = Bonificacion.ToString();
                Stotal.Text = Salario_Total.ToString();

                
            }


        }
    }
}
