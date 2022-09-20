using System.Security.Cryptography;
using System.Xml;

namespace OP20001_Guia3Ej8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Dado dado = new Dado();

            dado.Dado1 = random.Next(1, 7);
            dado.Dado2 = random.Next(1, 7);
            dado.Dado3 = random.Next(1, 7);

            lblResultadoDado1.Text = dado.Dado1.ToString();
            lblResultadoDado2.Text = dado.Dado2.ToString();
            lblResultadoDado3.Text = dado.Dado3.ToString();

            if (dado.Dado1 == 6 && dado.Dado2 == 6 && dado.Dado3 == 6)
            {
                lblMensaje.Text = "¡¡¡Ganó1,000,000!!!";
            }
            else if (dado.Dado1 == 6 && dado.Dado2 == 6 || dado.Dado2 == 6 && dado.Dado3 == 6 || dado.Dado1 == 6 && dado.Dado3 == 6)
            {
                lblMensaje.Text = "¡Ganó TV!";
            }
            else if ( dado.Dado1 == 6 || dado.Dado2 == 6 || dado.Dado3 == 6)
            {
                lblMensaje.Text = "Continúe intentando";
            }
            else
            {
                lblMensaje.Text = "¡¡¡Pierdetodo!!!";
            }
        }

    }
}