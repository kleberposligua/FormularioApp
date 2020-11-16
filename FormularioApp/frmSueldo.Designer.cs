namespace FormularioApp
{
    partial class frmSueldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHorasTrab = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtTotalIng = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAsoTrab = new System.Windows.Forms.TextBox();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtCuentaxPagar = new System.Windows.Forms.TextBox();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo del trabajador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalIng);
            this.groupBox1.Controls.Add(this.txtBono);
            this.groupBox1.Controls.Add(this.txtValorHora);
            this.groupBox1.Controls.Add(this.txtHorasTrab);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalEgresos);
            this.groupBox2.Controls.Add(this.txtCuentaxPagar);
            this.groupBox2.Controls.Add(this.txtBar);
            this.groupBox2.Controls.Add(this.txtAsoTrab);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(434, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del trabajador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 78);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(447, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Horas trabajadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor por hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bono de responsabilidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "TOTAL DE INGRESOS";
            // 
            // txtHorasTrab
            // 
            this.txtHorasTrab.Location = new System.Drawing.Point(242, 41);
            this.txtHorasTrab.Name = "txtHorasTrab";
            this.txtHorasTrab.Size = new System.Drawing.Size(112, 26);
            this.txtHorasTrab.TabIndex = 4;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(242, 97);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(112, 26);
            this.txtValorHora.TabIndex = 5;
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(242, 153);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(112, 26);
            this.txtBono.TabIndex = 6;
            // 
            // txtTotalIng
            // 
            this.txtTotalIng.Location = new System.Drawing.Point(242, 221);
            this.txtTotalIng.Name = "txtTotalIng";
            this.txtTotalIng.ReadOnly = true;
            this.txtTotalIng.Size = new System.Drawing.Size(112, 26);
            this.txtTotalIng.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aso. de Trabajadores";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cuenta por pagar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "TOTAL DE EGRESOS";
            // 
            // txtAsoTrab
            // 
            this.txtAsoTrab.Location = new System.Drawing.Point(242, 47);
            this.txtAsoTrab.Name = "txtAsoTrab";
            this.txtAsoTrab.Size = new System.Drawing.Size(123, 26);
            this.txtAsoTrab.TabIndex = 4;
            // 
            // txtBar
            // 
            this.txtBar.Location = new System.Drawing.Point(242, 97);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(123, 26);
            this.txtBar.TabIndex = 5;
            // 
            // txtCuentaxPagar
            // 
            this.txtCuentaxPagar.Location = new System.Drawing.Point(242, 153);
            this.txtCuentaxPagar.Name = "txtCuentaxPagar";
            this.txtCuentaxPagar.Size = new System.Drawing.Size(123, 26);
            this.txtCuentaxPagar.TabIndex = 6;
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Location = new System.Drawing.Point(242, 214);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.ReadOnly = true;
            this.txtTotalEgresos.Size = new System.Drawing.Size(123, 26);
            this.txtTotalEgresos.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(29, 402);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(119, 20);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Líquido a recibir";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(306, 451);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(434, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSueldo";
            this.Text = "Cálculo del sueldo de un trabajador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalIng;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtHorasTrab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.TextBox txtCuentaxPagar;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtAsoTrab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}