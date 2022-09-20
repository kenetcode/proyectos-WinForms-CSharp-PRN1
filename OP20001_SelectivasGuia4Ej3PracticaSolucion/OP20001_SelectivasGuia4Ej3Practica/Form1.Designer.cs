namespace OP20001_SelectivasGuia4Ej3Practica
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
            this.cmbCamisas = new System.Windows.Forms.ComboBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCantidadCamisas = new System.Windows.Forms.TextBox();
            this.txtPrecioCamisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCamisas
            // 
            this.cmbCamisas.FormattingEnabled = true;
            this.cmbCamisas.Items.AddRange(new object[] {
            "blanco",
            "azul",
            "verde",
            "amarillo",
            "rosa",
            "negro",
            "rojo",
            "naranja",
            "otros"});
            this.cmbCamisas.Location = new System.Drawing.Point(605, 69);
            this.cmbCamisas.Name = "cmbCamisas";
            this.cmbCamisas.Size = new System.Drawing.Size(242, 40);
            this.cmbCamisas.TabIndex = 0;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(386, 65);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 46);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(386, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 46);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCantidadCamisas
            // 
            this.txtCantidadCamisas.Location = new System.Drawing.Point(111, 65);
            this.txtCantidadCamisas.Name = "txtCantidadCamisas";
            this.txtCantidadCamisas.Size = new System.Drawing.Size(200, 39);
            this.txtCantidadCamisas.TabIndex = 3;
            // 
            // txtPrecioCamisa
            // 
            this.txtPrecioCamisa.Location = new System.Drawing.Point(111, 180);
            this.txtPrecioCamisa.Name = "txtPrecioCamisa";
            this.txtPrecioCamisa.Size = new System.Drawing.Size(200, 39);
            this.txtPrecioCamisa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total a pagar: ";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(280, 356);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 32);
            this.lblTotalPagar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero de camisas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio por camisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccione un color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioCamisa);
            this.Controls.Add(this.txtCantidadCamisas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.cmbCamisas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCamisas;
        private Button btnProcesar;
        private Button btnLimpiar;
        private TextBox txtCantidadCamisas;
        private TextBox txtPrecioCamisa;
        private Label label1;
        private Label lblTotalPagar;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}