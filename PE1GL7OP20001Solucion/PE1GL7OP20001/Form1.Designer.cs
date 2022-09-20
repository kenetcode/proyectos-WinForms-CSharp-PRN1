namespace PE1GL7OP20001
{
    // Autor: Kenet Arnulfo Ortiz Pineda
    // Carnet: OP20001
    // GT: 1
    // GL: 7
    // Evaluado: 1
    // Fecha: 6/09/2022
    // Docente: Ing. Patricia Carolina Mejia Contreras

    // Programa que recibe los datos del empleado y calcula su nuevo salario teniendo en cuenta lo siguiente
    // si el salario del empleado es menor de $475 el aumento es del 5.5%, si el salario está
    // en el rango de $475 y $850 el aumento será aumento del 7.75% y si el salario es superior a
    // $850 el aumento será de 9.5%. El nuevo salario no puede excederse de los $2,500.
    // Luego imprime sus datos y su nuevo salario.
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
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalarioActual = new System.Windows.Forms.TextBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.cmbAreaDeTrabajo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblNuevoSalario = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAreaDeTrabajo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDui = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(108, 202);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(200, 39);
            this.txtCarnet.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(424, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 39);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSalarioActual
            // 
            this.txtSalarioActual.Location = new System.Drawing.Point(108, 337);
            this.txtSalarioActual.Name = "txtSalarioActual";
            this.txtSalarioActual.Size = new System.Drawing.Size(200, 39);
            this.txtSalarioActual.TabIndex = 2;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(424, 341);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(154, 36);
            this.rdbMasculino.TabIndex = 3;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(614, 341);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(152, 36);
            this.rdbFemenino.TabIndex = 4;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(108, 468);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(200, 39);
            this.txtDui.TabIndex = 5;
            // 
            // cmbAreaDeTrabajo
            // 
            this.cmbAreaDeTrabajo.FormattingEnabled = true;
            this.cmbAreaDeTrabajo.Items.AddRange(new object[] {
            "Administración",
            "Desarrollo",
            "Soporte Técnico",
            "Recursos Humanos",
            "Atención al cliente"});
            this.cmbAreaDeTrabajo.Location = new System.Drawing.Point(424, 467);
            this.cmbAreaDeTrabajo.Name = "cmbAreaDeTrabajo";
            this.cmbAreaDeTrabajo.Size = new System.Drawing.Size(242, 40);
            this.cmbAreaDeTrabajo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salario Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "DUI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Area de Trabajo";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblNuevoSalario);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.lblAreaDeTrabajo);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.lblDui);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.lblGenero);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.lblCarnet);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Location = new System.Drawing.Point(108, 666);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(670, 422);
            this.grpDatos.TabIndex = 13;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblNuevoSalario
            // 
            this.lblNuevoSalario.AutoSize = true;
            this.lblNuevoSalario.Location = new System.Drawing.Point(223, 337);
            this.lblNuevoSalario.Name = "lblNuevoSalario";
            this.lblNuevoSalario.Size = new System.Drawing.Size(0, 32);
            this.lblNuevoSalario.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nuevo Salario:";
            // 
            // lblAreaDeTrabajo
            // 
            this.lblAreaDeTrabajo.AutoSize = true;
            this.lblAreaDeTrabajo.Location = new System.Drawing.Point(240, 263);
            this.lblAreaDeTrabajo.Name = "lblAreaDeTrabajo";
            this.lblAreaDeTrabajo.Size = new System.Drawing.Size(0, 32);
            this.lblAreaDeTrabajo.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 32);
            this.label11.TabIndex = 14;
            this.label11.Text = "Area de Trabajo:";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Location = new System.Drawing.Point(109, 209);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(0, 32);
            this.lblDui.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "DUI:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(152, 158);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 32);
            this.lblGenero.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Género:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(144, 108);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(0, 32);
            this.lblCarnet.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Carnet:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(152, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 32);
            this.lblNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(167, 565);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 46);
            this.btnProcesar.TabIndex = 14;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(424, 565);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 46);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(108, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(631, 100);
            this.label13.TabIndex = 16;
            this.label13.Text = "Ingrese los datos del empleado para\r\ncalcular su nuevo salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 1137);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAreaDeTrabajo);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.txtSalarioActual);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCarnet;
        private TextBox txtNombre;
        private TextBox txtSalarioActual;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private TextBox txtDui;
        private ComboBox cmbAreaDeTrabajo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox grpDatos;
        private Button btnProcesar;
        private Button btnLimpiar;
        private Label lblNuevoSalario;
        private Label label12;
        private Label lblAreaDeTrabajo;
        private Label label11;
        private Label lblDui;
        private Label label10;
        private Label lblGenero;
        private Label label9;
        private Label lblCarnet;
        private Label label8;
        private Label lblNombre;
        private Label label7;
        private Label label13;
    }
}