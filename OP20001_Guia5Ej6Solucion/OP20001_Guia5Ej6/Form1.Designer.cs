namespace OP20001_Guia5Ej6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.dgvDatosdeEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salariobase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salariofinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblSalarioFinal = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVentaIngresada = new System.Windows.Forms.TextBox();
            this.btnAceptarIngresarVentas = new System.Windows.Forms.Button();
            this.lblIndicativodeVentas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosdeEmpleados)).BeginInit();
            this.grpDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(76, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(76, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(428, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(428, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(199, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 39);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(199, 284);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 39);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(551, 220);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(200, 39);
            this.txtDui.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(551, 281);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(200, 39);
            this.txtEdad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(428, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salario base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(575, 340);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(176, 39);
            this.txtSalarioBase.TabIndex = 9;
            // 
            // dgvDatosdeEmpleados
            // 
            this.dgvDatosdeEmpleados.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDatosdeEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosdeEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Salariobase,
            this.Salariofinal,
            this.Edad,
            this.Dui});
            this.dgvDatosdeEmpleados.Location = new System.Drawing.Point(62, 635);
            this.dgvDatosdeEmpleados.Name = "dgvDatosdeEmpleados";
            this.dgvDatosdeEmpleados.RowHeadersWidth = 82;
            this.dgvDatosdeEmpleados.RowTemplate.Height = 41;
            this.dgvDatosdeEmpleados.Size = new System.Drawing.Size(1284, 350);
            this.dgvDatosdeEmpleados.TabIndex = 10;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 10;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 200;
            // 
            // Salariobase
            // 
            this.Salariobase.HeaderText = "Salario base";
            this.Salariobase.MinimumWidth = 10;
            this.Salariobase.Name = "Salariobase";
            this.Salariobase.Width = 200;
            // 
            // Salariofinal
            // 
            this.Salariofinal.HeaderText = "Salario final";
            this.Salariofinal.MinimumWidth = 10;
            this.Salariofinal.Name = "Salariofinal";
            this.Salariofinal.Width = 200;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 10;
            this.Edad.Name = "Edad";
            this.Edad.Width = 200;
            // 
            // Dui
            // 
            this.Dui.HeaderText = "DUI";
            this.Dui.MinimumWidth = 10;
            this.Dui.Name = "Dui";
            this.Dui.Width = 200;
            // 
            // grpDatosEmpleado
            // 
            this.grpDatosEmpleado.Controls.Add(this.lblSalarioFinal);
            this.grpDatosEmpleado.Controls.Add(this.lblEdad);
            this.grpDatosEmpleado.Controls.Add(this.lblDui);
            this.grpDatosEmpleado.Controls.Add(this.lblApellido);
            this.grpDatosEmpleado.Controls.Add(this.lblNombre);
            this.grpDatosEmpleado.Controls.Add(this.label6);
            this.grpDatosEmpleado.Controls.Add(this.label10);
            this.grpDatosEmpleado.Controls.Add(this.label7);
            this.grpDatosEmpleado.Controls.Add(this.label9);
            this.grpDatosEmpleado.Controls.Add(this.label8);
            this.grpDatosEmpleado.Location = new System.Drawing.Point(830, 206);
            this.grpDatosEmpleado.Name = "grpDatosEmpleado";
            this.grpDatosEmpleado.Size = new System.Drawing.Size(516, 359);
            this.grpDatosEmpleado.TabIndex = 11;
            this.grpDatosEmpleado.TabStop = false;
            this.grpDatosEmpleado.Text = "Datos del empleado";
            // 
            // lblSalarioFinal
            // 
            this.lblSalarioFinal.AutoSize = true;
            this.lblSalarioFinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalarioFinal.Location = new System.Drawing.Point(211, 269);
            this.lblSalarioFinal.Name = "lblSalarioFinal";
            this.lblSalarioFinal.Size = new System.Drawing.Size(0, 32);
            this.lblSalarioFinal.TabIndex = 21;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEdad.Location = new System.Drawing.Point(139, 222);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 32);
            this.lblEdad.TabIndex = 20;
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDui.Location = new System.Drawing.Point(139, 174);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(0, 32);
            this.lblDui.TabIndex = 19;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(175, 123);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(0, 32);
            this.lblApellido.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(175, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 32);
            this.lblNombre.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(62, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salario final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(62, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(62, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(62, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(62, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "DUI:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(601, 442);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 46);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(601, 538);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 46);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(76, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(417, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ingresar Ganancia Por Venta Realizada";
            // 
            // txtVentaIngresada
            // 
            this.txtVentaIngresada.Location = new System.Drawing.Point(76, 446);
            this.txtVentaIngresada.Name = "txtVentaIngresada";
            this.txtVentaIngresada.Size = new System.Drawing.Size(200, 39);
            this.txtVentaIngresada.TabIndex = 17;
            // 
            // btnAceptarIngresarVentas
            // 
            this.btnAceptarIngresarVentas.Location = new System.Drawing.Point(343, 442);
            this.btnAceptarIngresarVentas.Name = "btnAceptarIngresarVentas";
            this.btnAceptarIngresarVentas.Size = new System.Drawing.Size(150, 46);
            this.btnAceptarIngresarVentas.TabIndex = 18;
            this.btnAceptarIngresarVentas.Text = "Aceptar";
            this.btnAceptarIngresarVentas.UseVisualStyleBackColor = true;
            this.btnAceptarIngresarVentas.Click += new System.EventHandler(this.btnAceptarIngresarVentas_Click);
            // 
            // lblIndicativodeVentas
            // 
            this.lblIndicativodeVentas.AutoSize = true;
            this.lblIndicativodeVentas.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIndicativodeVentas.Location = new System.Drawing.Point(76, 499);
            this.lblIndicativodeVentas.Name = "lblIndicativodeVentas";
            this.lblIndicativodeVentas.Size = new System.Drawing.Size(0, 32);
            this.lblIndicativodeVentas.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Georgia", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(12, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1393, 98);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ingrese los datos del empleado para poder calcular su salario\r\nen base a las vent" +
    "as que realizo durante el mes.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1414, 1035);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblIndicativodeVentas);
            this.Controls.Add(this.btnAceptarIngresarVentas);
            this.Controls.Add(this.txtVentaIngresada);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpDatosEmpleado);
            this.Controls.Add(this.dgvDatosdeEmpleados);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosdeEmpleados)).EndInit();
            this.grpDatosEmpleado.ResumeLayout(false);
            this.grpDatosEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDui;
        private TextBox txtEdad;
        private Label label5;
        private TextBox txtSalarioBase;
        private DataGridView dgvDatosdeEmpleados;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Salariobase;
        private DataGridViewTextBoxColumn Salariofinal;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Dui;
        private GroupBox grpDatosEmpleado;
        private Label label6;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label8;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblSalarioFinal;
        private Label lblEdad;
        private Label lblDui;
        private Label lblApellido;
        private Label lblNombre;
        private Label label12;
        private TextBox txtVentaIngresada;
        private Button btnAceptarIngresarVentas;
        private Label lblIndicativodeVentas;
        private Label label11;
    }
}