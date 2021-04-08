namespace FormularioGrafico
{
    partial class Ejercicio2
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
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboOpc = new System.Windows.Forms.ComboBox();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(318, 96);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 20);
            this.TxtResultado.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona Operacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Base";
            // 
            // ComboOpc
            // 
            this.ComboOpc.FormattingEnabled = true;
            this.ComboOpc.Items.AddRange(new object[] {
            "Raiz",
            "Seno ",
            "Coseno",
            "Tangente",
            "Valor Absoluto ",
            "Arcotangente",
            "Coseno Hiperbolico",
            "Logaritmo",
            "Logaritmo Base 10",
            "Elevado a la 2"});
            this.ComboOpc.Location = new System.Drawing.Point(177, 96);
            this.ComboOpc.Name = "ComboOpc";
            this.ComboOpc.Size = new System.Drawing.Size(121, 21);
            this.ComboOpc.TabIndex = 11;
            this.ComboOpc.SelectedIndexChanged += new System.EventHandler(this.ComboOpc_SelectedIndexChanged);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(46, 97);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(100, 20);
            this.TxtNum1.TabIndex = 10;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 172);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboOpc);
            this.Controls.Add(this.TxtNum1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboOpc;
        private System.Windows.Forms.TextBox TxtNum1;
    }
}