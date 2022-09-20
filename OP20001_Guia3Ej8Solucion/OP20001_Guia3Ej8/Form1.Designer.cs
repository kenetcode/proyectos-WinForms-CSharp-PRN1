namespace OP20001_Guia3Ej8
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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblDado3 = new System.Windows.Forms.Label();
            this.lblResultadoDado1 = new System.Windows.Forms.Label();
            this.lblResultadoDado2 = new System.Windows.Forms.Label();
            this.lblResultadoDado3 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndicacion.Location = new System.Drawing.Point(1, 42);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(918, 43);
            this.lblIndicacion.TabIndex = 0;
            this.lblIndicacion.Text = "Lance los dados y gane increibles premios";
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.Location = new System.Drawing.Point(369, 126);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(186, 76);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Location = new System.Drawing.Point(165, 262);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(91, 32);
            this.lblDado1.TabIndex = 2;
            this.lblDado1.Text = "Dado 1";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Location = new System.Drawing.Point(426, 262);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(91, 32);
            this.lblDado2.TabIndex = 3;
            this.lblDado2.Text = "Dado 2";
            // 
            // lblDado3
            // 
            this.lblDado3.AutoSize = true;
            this.lblDado3.Location = new System.Drawing.Point(676, 262);
            this.lblDado3.Name = "lblDado3";
            this.lblDado3.Size = new System.Drawing.Size(91, 32);
            this.lblDado3.TabIndex = 4;
            this.lblDado3.Text = "Dado 3";
            // 
            // lblResultadoDado1
            // 
            this.lblResultadoDado1.AutoSize = true;
            this.lblResultadoDado1.Location = new System.Drawing.Point(165, 339);
            this.lblResultadoDado1.Name = "lblResultadoDado1";
            this.lblResultadoDado1.Size = new System.Drawing.Size(0, 32);
            this.lblResultadoDado1.TabIndex = 5;
            // 
            // lblResultadoDado2
            // 
            this.lblResultadoDado2.AutoSize = true;
            this.lblResultadoDado2.Location = new System.Drawing.Point(426, 339);
            this.lblResultadoDado2.Name = "lblResultadoDado2";
            this.lblResultadoDado2.Size = new System.Drawing.Size(0, 32);
            this.lblResultadoDado2.TabIndex = 6;
            // 
            // lblResultadoDado3
            // 
            this.lblResultadoDado3.AutoSize = true;
            this.lblResultadoDado3.Location = new System.Drawing.Point(676, 339);
            this.lblResultadoDado3.Name = "lblResultadoDado3";
            this.lblResultadoDado3.Size = new System.Drawing.Size(0, 32);
            this.lblResultadoDado3.TabIndex = 7;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(346, 455);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 32);
            this.lblMensaje.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 609);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblResultadoDado3);
            this.Controls.Add(this.lblResultadoDado2);
            this.Controls.Add(this.lblResultadoDado1);
            this.Controls.Add(this.lblDado3);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblIndicacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIndicacion;
        private Button btnJugar;
        private Label lblDado1;
        private Label lblDado2;
        private Label lblDado3;
        private Label lblResultadoDado1;
        private Label lblResultadoDado2;
        private Label lblResultadoDado3;
        private Label lblMensaje;
    }
}