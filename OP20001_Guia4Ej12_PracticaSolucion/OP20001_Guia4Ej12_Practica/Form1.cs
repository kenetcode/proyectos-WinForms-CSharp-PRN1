namespace OP20001_Guia4Ej12_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            long numeroIngresado = Convert.ToInt64(txtNumeroIngresado.Text);

            lstSecuenciaNumeros.Items.Add(numeroIngresado);

            while (numeroIngresado > 1)
            {
                if (numeroIngresado % 2 == 0)
                {
                    numeroIngresado = numeroIngresado / 2;
                    lstSecuenciaNumeros.Items.Add(numeroIngresado);
                }
                else
                {
                    numeroIngresado = (numeroIngresado * 3) + 1;
                    lstSecuenciaNumeros.Items.Add(numeroIngresado);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstSecuenciaNumeros.Items.Clear();
            txtNumeroIngresado.Clear();
            txtNumeroIngresado.Focus();
        }
    }
}