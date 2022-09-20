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


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double salario, nuevoSalario = 0;
            //string nuevoSalarioTex;

            salario = Convert.ToDouble(txtSalarioActual.Text);

            if(salario < 475)
            {
                nuevoSalario = salario + (salario * 0.055);
            }
            else if(salario >= 475 && salario <= 850)
            {
                nuevoSalario = salario + (salario * 0.0775);
            }
            else if (salario > 850 && salario < 2500)
            {
                nuevoSalario = salario + (salario * 0.095);

                if(nuevoSalario > 2500)
                {
                    nuevoSalario = salario + (2500 - salario);
                } 
            }
            else if(salario >= 2500)
            {
                nuevoSalario = salario;
            }

            //Asignando los datos ingresados a la parte donde se imprimiran los resultados.

            lblNombre.Text = txtNombre.Text;
            lblCarnet.Text = txtCarnet.Text;
            
            if(rdbFemenino.Checked)
            {
                lblGenero.Text = "Femenino";
            }
            if(rdbMasculino.Checked)
            {
                lblGenero.Text = "Masculino";
            }

            lblDui.Text = txtDui.Text;

            if(cmbAreaDeTrabajo.SelectedIndex == 0)
            {
                lblAreaDeTrabajo.Text = "Administración";
            }
            else if(cmbAreaDeTrabajo.SelectedIndex == 1)
            {
                lblAreaDeTrabajo.Text = "Desarrollo";
            }
            else if (cmbAreaDeTrabajo.SelectedIndex == 2)
            {
                lblAreaDeTrabajo.Text = "Soporte Técnico";
            }
            else if (cmbAreaDeTrabajo.SelectedIndex == 3)
            {
                lblAreaDeTrabajo.Text = "Recursos Humanos";
            }
            else if (cmbAreaDeTrabajo.SelectedIndex == 4)
            {
                lblAreaDeTrabajo.Text = "Atención al cliente";
            }
            else
            {
                MessageBox.Show("Seleccione un area de trabajo");
                cmbAreaDeTrabajo.Focus();
            }

            lblNuevoSalario.Text = "$"+Convert.ToString(nuevoSalario);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtDui.Clear();
            txtSalarioActual.Clear();
            cmbAreaDeTrabajo.SelectedIndex = -1;
            lblNombre.Text = "";
            lblCarnet.Text = "";
            lblGenero.Text = "";
            lblDui.Text = "";
            lblAreaDeTrabajo.Text = "";
            lblNuevoSalario.Text = "";
            txtCarnet.Focus();
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
        }
    }
}