namespace OP20001_Guia5Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleado empleado = new Empleado();
        List<double> gananciaVentas = new List<double>();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            empleado.SalarioBase = Convert.ToDouble(txtSalarioBase.Text);
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Dui = txtDui.Text;
            empleado.Edad = txtEdad.Text;

            for (int i = 0; i < gananciaVentas.Count; i++)
            {
                empleado.VentasTotales += gananciaVentas[i];
            }

            if (empleado.NumVentas < 1)
            {
                empleado.SalarioFinal = empleado.SalarioBase;
            }

            else if (empleado.NumVentas >= 1 && empleado.NumVentas < 10 && empleado.VentasTotales <= 400)
            {
                empleado.CalculoSalarial(1.10);
            }
            else if (empleado.NumVentas >= 10 && empleado.NumVentas < 20 && empleado.VentasTotales <= 400)
            {
                empleado.CalculoSalarial(1.15); //puse %115 en lugar de %125 porque no
                //tendria sentido poner %125 en ambas condiciones, ademas el problema
                //esta mal redactado, hice lo que crei mejor
            }
            else if (empleado.NumVentas >= 20 || empleado.VentasTotales > 400)
            {
                empleado.CalculoSalarial(1.25);
            }

            lblNombre.Text = empleado.Nombre;
            lblApellido.Text = empleado.Apellido;
            lblDui.Text = empleado.Dui;
            lblEdad.Text = empleado.Edad;
            lblSalarioFinal.Text = Convert.ToString(empleado.SalarioFinal);

            dgvDatosdeEmpleados.Rows.Add(empleado.Nombre, empleado.Apellido,
                "$" + empleado.SalarioBase, "$" + empleado.SalarioFinal, empleado.Edad, empleado.Dui);


            empleado.SalarioBase = 0;
            empleado.VentasTotales = 0;
            empleado.SalarioFinal = 0;
            empleado.NumVentas = 0;
            empleado.Nombre = "";
            empleado.Apellido = "";
            empleado.Dui = "";
            empleado.Edad = "";

        }

        private void btnAceptarIngresarVentas_Click(object sender, EventArgs e)
        {
            empleado.NumVentas += 1;

            if (empleado.NumVentas <= 1)
            {
                lblIndicativodeVentas.Text = "Usted ingreso " + empleado.NumVentas + " venta";
                //gananciaVentas.Add(Convert.ToDouble(txtVentaIngresada.Text));
            }
            else
            {
                lblIndicativodeVentas.Text = "Usted ingreso " + empleado.NumVentas + " ventas";
            }

            gananciaVentas.Add(Convert.ToDouble(txtVentaIngresada.Text));

            txtVentaIngresada.Clear();
            txtVentaIngresada.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtApellido.Clear();
            txtNombre.Clear();
            txtDui.Clear();
            txtEdad.Clear();
            txtSalarioBase.Clear();

            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDui.Text = "";
            lblEdad.Text = "";
            lblSalarioFinal.Text = "";
            lblIndicativodeVentas.Text = "";

            empleado.SalarioBase = 0;
            empleado.VentasTotales = 0;
            empleado.SalarioFinal = 0;
            empleado.NumVentas = 0;
            empleado.Nombre = "";
            empleado.Apellido = "";
            empleado.Dui = "";
            empleado.Edad = "";
        }
    }
}