using System.Drawing.Text;

namespace OP20001_Guia4Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cont = int.Parse(lblIndicativo.Text);
            lblIndicativo.Text = (cont + 1).ToString();
            if (cont >= 0) lblInfoNumero.Text = "Ingreso el dato";

            lstDatosIngresados.Items.Add(txtDatoIngresado.Text);
            txtDatoIngresado.Clear();
            txtDatoIngresado.Focus();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            TipoDato tipo = new TipoDato();

            for (int i = 0; i < lstDatosIngresados.Items.Count; i++)
            {
                tipo.Numero = int.Parse((string)lstDatosIngresados.Items[i]);

                if (tipo.Numero < 0)
                {
                    tipo.ContadorNegativos++;
                }
            }

            for (int i = 0; i < lstDatosIngresados.Items.Count; i++)
            {
                tipo.Numero = int.Parse((string)lstDatosIngresados.Items[i]);

                if (tipo.Numero > 0)
                {
                    tipo.ContadorPositivos++;
                }
            }

            for (int i = 0; i < lstDatosIngresados.Items.Count; i++)
            {
                tipo.Numero = int.Parse((string)lstDatosIngresados.Items[i]);

                if (tipo.Numero % 15 == 0)
                {
                    tipo.ContadorMultiplos++;
                }
            }

            for (int i = 0; i < lstDatosIngresados.Items.Count; i++)
            {
                tipo.Numero = int.Parse((string)lstDatosIngresados.Items[i]);

                if (tipo.Numero % 2 == 0)
                {
                    tipo.NumParesAcumulados += tipo.Numero;
                }
            }

            dgvDatos.Rows.Add(tipo.ContadorNegativos, tipo.ContadorPositivos, tipo.ContadorMultiplos, tipo.NumParesAcumulados);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblInfoNumero.Text = "";
            lblIndicativo.Text = "0";
            dgvDatos.Rows.Clear();
            lstDatosIngresados.Items.Clear();
            txtDatoIngresado.Clear();
            txtDatoIngresado.Focus();
        }
    }
}