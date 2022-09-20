namespace OP20001_Guia3Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int horasTrabajadas = Convert.ToInt32(txtBNumeroHoras.Text);
            int horasExtra = 0;
            Double pago;

            if (horasTrabajadas >= 8 && horasTrabajadas <= 40)
            {
                pago = horasTrabajadas * 16.00;

                lblPago.Text = "Su pago de la semana es: $" + pago.ToString();
            }

            //Limité las horas extra hasta 12 horas más suponiendo que el obrero trabaja sabado
            //y domingo hasta medio dia en algunos casos.
            else if (horasTrabajadas > 40 && horasTrabajadas <= 52)
            {
                for (int i = 1; i < horasTrabajadas; i++)
                {
                    if (i >= 40)
                    {
                        horasExtra += 1;
                    }
                }

                pago = (40 * 16) + (horasExtra * 20);

                lblPago.Text = "Su pago de la semana es: $" + pago.ToString() + " Incluyendo sus horas extra.";
            }
            else
            {
                lblError.Text = "Ingreso un dato incorrecto, por favor intente nuevamente";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBNumeroHoras.Clear();
            lblPago.Text = "";
            lblError.Text = "";
        }
    }
}