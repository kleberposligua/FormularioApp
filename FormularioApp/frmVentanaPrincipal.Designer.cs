namespace FormularioApp
{
    partial class frmVentanaPrincipal
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
            this.btnSueldo = new System.Windows.Forms.Button();
            this.btnNumEnBinario = new System.Windows.Forms.Button();
            this.btnOtroForm = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSueldo
            // 
            this.btnSueldo.Location = new System.Drawing.Point(179, 106);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(230, 86);
            this.btnSueldo.TabIndex = 0;
            this.btnSueldo.Text = "Calcular sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            this.btnSueldo.Click += new System.EventHandler(this.btnSueldo_Click);
            // 
            // btnNumEnBinario
            // 
            this.btnNumEnBinario.Location = new System.Drawing.Point(179, 198);
            this.btnNumEnBinario.Name = "btnNumEnBinario";
            this.btnNumEnBinario.Size = new System.Drawing.Size(230, 89);
            this.btnNumEnBinario.TabIndex = 1;
            this.btnNumEnBinario.Text = "Entero en Binario";
            this.btnNumEnBinario.UseVisualStyleBackColor = true;
            this.btnNumEnBinario.Click += new System.EventHandler(this.btnNumEnBinario_Click);
            // 
            // btnOtroForm
            // 
            this.btnOtroForm.Location = new System.Drawing.Point(179, 293);
            this.btnOtroForm.Name = "btnOtroForm";
            this.btnOtroForm.Size = new System.Drawing.Size(230, 89);
            this.btnOtroForm.TabIndex = 2;
            this.btnOtroForm.Text = "Formulario nuevo";
            this.btnOtroForm.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(179, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(490, 88);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(328, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 89);
            this.button1.TabIndex = 7;
            this.button1.Text = "abrir form3";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 89);
            this.button2.TabIndex = 6;
            this.button2.Text = "abrir form2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 86);
            this.button3.TabIndex = 5;
            this.button3.Text = "abrir form1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOtroForm);
            this.Controls.Add(this.btnNumEnBinario);
            this.Controls.Add(this.btnSueldo);
            this.Name = "frmVentanaPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Button btnNumEnBinario;
        private System.Windows.Forms.Button btnOtroForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}