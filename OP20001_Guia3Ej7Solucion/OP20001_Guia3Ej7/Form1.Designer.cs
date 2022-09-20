namespace OP20001_Guia3Ej7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBNumeroHoras = new System.Windows.Forms.TextBox();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBNumeroHoras
            // 
            this.txtBNumeroHoras.Location = new System.Drawing.Point(74, 222);
            this.txtBNumeroHoras.Name = "txtBNumeroHoras";
            this.txtBNumeroHoras.Size = new System.Drawing.Size(200, 39);
            this.txtBNumeroHoras.TabIndex = 0;
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(74, 168);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(200, 32);
            this.lblIndicacion.TabIndex = 1;
            this.lblIndicacion.Text = "Horas Trabajadas ";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(426, 222);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 46);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(74, 378);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(0, 32);
            this.lblPago.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(426, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 46);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(74, 527);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 32);
            this.lblError.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(74, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 32);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Calcule su salario semanal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 619);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.txtBNumeroHoras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBNumeroHoras;
        private Label lblIndicacion;
        private Button btnProcesar;
        private Label lblPago;
        private Button btnLimpiar;
        private Label lblError;
        private Label lblTitulo;
    }
}