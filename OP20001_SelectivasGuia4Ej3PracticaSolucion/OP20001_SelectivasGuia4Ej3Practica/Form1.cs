namespace OP20001_SelectivasGuia4Ej3Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int numCamisas = Convert.ToInt32(txtCantidadCamisas.Text);

            double precioPorCamisa = Convert.ToDouble(txtPrecioCamisa.Text);
            double precioDescuento, descuentoTotal = 0;

            if (numCamisas >= 3)
            {
                precioDescuento = (precioPorCamisa * numCamisas) - (precioPorCamisa * numCamisas * 0.20);
            }
            else
            {
                precioDescuento = (precioPorCamisa * numCamisas) - (precioPorCamisa * numCamisas * 0.10);
            }

            if (cmbCamisas.SelectedIndex == 0)
            {
                descuentoTotal = precioDescuento;
            }
            else if (cmbCamisas.SelectedIndex == 1)
            {
                descuentoTotal = precioDescuento + 0.10;
            }
            else if (cmbCamisas.SelectedIndex == 2)
            {
                descuentoTotal = precioDescuento + 0.20;
            }
            else if (cmbCamisas.SelectedIndex == 3)
            {
                descuentoTotal = precioDescuento + 0.40;
            }
            else if (cmbCamisas.SelectedIndex == 4)
            {
                descuentoTotal = precioDescuento + 0.40;
            }
            else if (cmbCamisas.SelectedIndex == 5)
            {
                descuentoTotal = precioDescuento + 0.50;
            }
            else if (cmbCamisas.SelectedIndex == 6)
            {
                descuentoTotal = precioDescuento + 0.60;
            }
            else if (cmbCamisas.SelectedIndex == 7)
            {
                descuentoTotal = precioDescuento + 0.70;
            }
            else if (cmbCamisas.SelectedIndex == 8)
            {
                descuentoTotal = precioDescuento + 0.80;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un color");
                lblTotalPagar.Text = "";
                cmbCamisas.Focus();
            }
            lblTotalPagar.Text = "$" + descuentoTotal.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblTotalPagar.Text = "";
            txtCantidadCamisas.Clear();
            txtPrecioCamisa.Clear();
            txtCantidadCamisas.Focus();
            cmbCamisas.SelectedIndex = -1;
        }
    }
}