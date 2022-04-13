namespace Proyecto_de_Prueba
{
    partial class Formulario1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.n1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clean = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.operaciones = new System.Windows.Forms.ComboBox();
            this.Calculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(78, 61);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(53, 13);
            this.n1.TabIndex = 0;
            this.n1.Text = "Numero 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(17, 27);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "Sumar";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(78, 85);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(53, 13);
            this.n2.TabIndex = 3;
            this.n2.Text = "Numero 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(78, 118);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(55, 13);
            this.r.TabIndex = 5;
            this.r.Text = "Resultado";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(135, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(73, 156);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 7;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(136, 25);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(75, 23);
            this.resta.TabIndex = 8;
            this.resta.Text = "Restar";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(17, 100);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 23);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "Multiplicacion";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(136, 100);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 23);
            this.dividir.TabIndex = 10;
            this.dividir.Text = "Dividicion";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Suma);
            this.groupBox1.Controls.Add(this.clean);
            this.groupBox1.Controls.Add(this.dividir);
            this.groupBox1.Controls.Add(this.resta);
            this.groupBox1.Controls.Add(this.multiplicar);
            this.groupBox1.Location = new System.Drawing.Point(555, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 179);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // operaciones
            // 
            this.operaciones.FormattingEnabled = true;
            this.operaciones.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar",
            "Dividir"});
            this.operaciones.Location = new System.Drawing.Point(135, 252);
            this.operaciones.Name = "operaciones";
            this.operaciones.Size = new System.Drawing.Size(121, 21);
            this.operaciones.TabIndex = 12;
            // 
            // Calculo
            // 
            this.Calculo.Location = new System.Drawing.Point(304, 249);
            this.Calculo.Name = "Calculo";
            this.Calculo.Size = new System.Drawing.Size(75, 23);
            this.Calculo.TabIndex = 13;
            this.Calculo.Text = "Calcular";
            this.Calculo.UseVisualStyleBackColor = true;
            this.Calculo.Click += new System.EventHandler(this.Calculo_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculo);
            this.Controls.Add(this.operaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.r);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.n1);
            this.Name = "Formulario1";
            this.Text = "Formulario Operaciones con Numeros";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox operaciones;
        private System.Windows.Forms.Button Calculo;
    }
}

