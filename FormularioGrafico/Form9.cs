using Microsoft.VisualBasic;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int Materias = 0, Alumnos = 0, i = 0, j = 0;
            
            Alumnos = int.Parse(textBox1.Text);
            Materias = int.Parse(textBox2.Text);

            string[] Materia = new string[Materias];
            string[] Alumno = new string[Alumnos];

            dataGridView1.ColumnCount = Alumnos + 1;
            dataGridView1.RowCount = Materias + 1;

            double[,] Notas = new double[Alumnos, Materias];


            double resultado=0, promedio = 0;
        
            for (i = 0; i < Materias; i++) {
                Materia[i] = Interaction.InputBox("Por favor diguite el nombre de la materia");
                dataGridView1.Rows[i].HeaderCell.Value = Materia[i];
            }
            for (j = 0; j < Alumnos; j++) {
                Alumno[j] = Interaction.InputBox("Por favor diguite el nombre de los estudiantes");
                dataGridView1.Columns[j].HeaderCell.Value = Alumno[j];
            }



            for (i = 0; i < Alumnos; i++)
            {
                for (j = 0; j < Materias; j++)
                {
                    Notas[i, j] = double.Parse(Interaction.InputBox("Por favor diguite la nota del estudiante: " + Alumno[i] + " La materia: " + Materia[j]));
                    dataGridView1.Rows[j].Cells[i].Value = Notas[i, j];
                    resultado = resultado + Notas[i, j]; 
                   } 
                   Console.WriteLine(resultado+ " / "+ Materias );
                   promedio = resultado / Materias;
                   dataGridView1.Rows[j].Cells[i].Value = promedio;
                   promedio = 0;
                   resultado = 0;
                }
                dataGridView1.Rows[j].HeaderCell.Value = "Promedio Alumno";
                dataGridView1.Columns[i].HeaderCell.Value = "Promedio Materia";


            for (j = 0; j < Materias; j++){
                for (i = 0; i < Alumnos; i++) {
                    resultado = resultado + Notas[i, j];
                }
                promedio = resultado / Alumnos;
                dataGridView1.Rows[j].Cells[i].Value = promedio;
                promedio = 0;
                resultado = 0;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }
    }
}
