namespace OP20001_Guia4Ej6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDatoIngresado = new System.Windows.Forms.TextBox();
            this.lblIndicativo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lstDatosIngresados = new System.Windows.Forms.ListBox();
            this.lblInfoNumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(303, 277);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDatoIngresado
            // 
            this.txtDatoIngresado.Location = new System.Drawing.Point(39, 277);
            this.txtDatoIngresado.Name = "txtDatoIngresado";
            this.txtDatoIngresado.Size = new System.Drawing.Size(200, 39);
            this.txtDatoIngresado.TabIndex = 1;
            // 
            // lblIndicativo
            // 
            this.lblIndicativo.AutoSize = true;
            this.lblIndicativo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblIndicativo.Location = new System.Drawing.Point(212, 226);
            this.lblIndicativo.Name = "lblIndicativo";
            this.lblIndicativo.Size = new System.Drawing.Size(27, 32);
            this.lblIndicativo.TabIndex = 2;
            this.lblIndicativo.Text = "0";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Navy;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDatos.Location = new System.Drawing.Point(30, 367);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 82;
            this.dgvDatos.RowTemplate.Height = 41;
            this.dgvDatos.Size = new System.Drawing.Size(884, 313);
            this.dgvDatos.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad de Negativos";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad de Positivos";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Multiplos de 15";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Acumulado de numeros par";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1205, 102);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(534, 277);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 46);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lstDatosIngresados
            // 
            this.lstDatosIngresados.FormattingEnabled = true;
            this.lstDatosIngresados.ItemHeight = 32;
            this.lstDatosIngresados.Location = new System.Drawing.Point(991, 367);
            this.lstDatosIngresados.Name = "lstDatosIngresados";
            this.lstDatosIngresados.Size = new System.Drawing.Size(211, 388);
            this.lstDatosIngresados.TabIndex = 7;
            // 
            // lblInfoNumero
            // 
            this.lblInfoNumero.AutoSize = true;
            this.lblInfoNumero.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblInfoNumero.Location = new System.Drawing.Point(39, 226);
            this.lblInfoNumero.Name = "lblInfoNumero";
            this.lblInfoNumero.Size = new System.Drawing.Size(0, 32);
            this.lblInfoNumero.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(991, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos Ingresados";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(764, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 46);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1258, 850);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfoNumero);
            this.Controls.Add(this.lstDatosIngresados);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblIndicativo);
            this.Controls.Add(this.txtDatoIngresado);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAceptar;
        private TextBox txtDatoIngresado;
        private Label lblIndicativo;
        private DataGridView dgvDatos;
        private Label label1;
        private Button btnProcesar;
        private ListBox lstDatosIngresados;
        private Label lblInfoNumero;
        private Label label2;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}