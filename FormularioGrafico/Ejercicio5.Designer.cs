
namespace FormularioGrafico
{
    partial class Ejercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cdias = new System.Windows.Forms.TextBox();
            this.DataTemperaturas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PorcOk = new System.Windows.Forms.TextBox();
            this.PorcError = new System.Windows.Forms.TextBox();
            this.TotalOk = new System.Windows.Forms.TextBox();
            this.TotalError = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tmax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tmin = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTemperaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Estacion Climatica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Universidad ECCI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Digita la cantidad de dias a medir:";
            // 
            // Cdias
            // 
            this.Cdias.Location = new System.Drawing.Point(212, 81);
            this.Cdias.Name = "Cdias";
            this.Cdias.Size = new System.Drawing.Size(100, 20);
            this.Cdias.TabIndex = 30;
            // 
            // DataTemperaturas
            // 
            this.DataTemperaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTemperaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataTemperaturas.Location = new System.Drawing.Point(455, 44);
            this.DataTemperaturas.Name = "DataTemperaturas";
            this.DataTemperaturas.Size = new System.Drawing.Size(243, 247);
            this.DataTemperaturas.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TempMax";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TempMin";
            this.Column2.Name = "Column2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Temperaturas con errores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Temperatura Valida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "% Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "% Validas";
            // 
            // PorcOk
            // 
            this.PorcOk.Location = new System.Drawing.Point(598, 384);
            this.PorcOk.Name = "PorcOk";
            this.PorcOk.Size = new System.Drawing.Size(100, 20);
            this.PorcOk.TabIndex = 36;
            // 
            // PorcError
            // 
            this.PorcError.Location = new System.Drawing.Point(598, 362);
            this.PorcError.Name = "PorcError";
            this.PorcError.Size = new System.Drawing.Size(100, 20);
            this.PorcError.TabIndex = 37;
            // 
            // TotalOk
            // 
            this.TotalOk.Location = new System.Drawing.Point(598, 340);
            this.TotalOk.Name = "TotalOk";
            this.TotalOk.Size = new System.Drawing.Size(100, 20);
            this.TotalOk.TabIndex = 38;
            // 
            // TotalError
            // 
            this.TotalError.Location = new System.Drawing.Point(598, 315);
            this.TotalError.Name = "TotalError";
            this.TotalError.Size = new System.Drawing.Size(100, 20);
            this.TotalError.TabIndex = 39;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(131, 191);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 40;
            this.BtnCalcular.Text = "Generar";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cual es la temperatura max:";
            // 
            // Tmax
            // 
            this.Tmax.Location = new System.Drawing.Point(212, 105);
            this.Tmax.Name = "Tmax";
            this.Tmax.Size = new System.Drawing.Size(100, 20);
            this.Tmax.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cual es la temperatura min: ";
            // 
            // Tmin
            // 
            this.Tmin.Location = new System.Drawing.Point(212, 130);
            this.Tmin.Name = "Tmin";
            this.Tmin.Size = new System.Drawing.Size(100, 20);
            this.Tmin.TabIndex = 44;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(43, 312);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(110, 23);
            this.Volver.TabIndex = 45;
            this.Volver.Text = "Volver al menu";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Tmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tmax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TotalError);
            this.Controls.Add(this.TotalOk);
            this.Controls.Add(this.PorcError);
            this.Controls.Add(this.PorcOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataTemperaturas);
            this.Controls.Add(this.Cdias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            ((System.ComponentModel.ISupportInitialize)(this.DataTemperaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cdias;
        private System.Windows.Forms.DataGridView DataTemperaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PorcOk;
        private System.Windows.Forms.TextBox PorcError;
        private System.Windows.Forms.TextBox TotalOk;
        private System.Windows.Forms.TextBox TotalError;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tmax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Volver;
    }
}