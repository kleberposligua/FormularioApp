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
            this.btnSalir.Size = new System.Drawing.Size(230, 88);
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
            this.label1.Location = new System.Drawing.Point(172, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 528);
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
    }
}