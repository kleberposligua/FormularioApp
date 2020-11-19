namespace FormularioApp
{
    partial class frmNumEnBinario
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el número a transformar";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(371, 53);
            this.txtNumero.MaxLength = 3;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(161, 26);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk8);
            this.groupBox1.Controls.Add(this.chk7);
            this.groupBox1.Controls.Add(this.chk6);
            this.groupBox1.Controls.Add(this.chk5);
            this.groupBox1.Controls.Add(this.chk4);
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Location = new System.Drawing.Point(56, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivalente en Binario";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(15, 40);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(22, 21);
            this.chk1.TabIndex = 0;
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(65, 40);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(22, 21);
            this.chk2.TabIndex = 1;
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(123, 40);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(22, 21);
            this.chk3.TabIndex = 2;
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(178, 40);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(22, 21);
            this.chk4.TabIndex = 3;
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(232, 40);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(22, 21);
            this.chk5.TabIndex = 4;
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(292, 40);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(22, 21);
            this.chk6.TabIndex = 5;
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(349, 40);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(22, 21);
            this.chk7.TabIndex = 6;
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(412, 40);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(22, 21);
            this.chk8.TabIndex = 7;
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(371, 85);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 36);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmNumEnBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmNumEnBinario";
            this.Text = "Transformar número entero en binario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btnCalcular;
    }
}