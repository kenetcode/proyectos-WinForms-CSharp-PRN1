using System.Diagnostics;
using System.Windows.Forms;

namespace OP20001_Guia5Ej10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Tratar de arreglar que los link redirijan a las paginas que se indican 

        //private void lklblPelicula1Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    lklblPelicula1Link.LinkVisited = true;

        //    System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PKEimNXpuQo");
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula1 = new Pelicula();
            Pelicula pelicula2 = new Pelicula();
            Pelicula pelicula3 = new Pelicula();

            pelicula1.Nombre = lblPelicula1Nombre.Text;
            pelicula1.Duracion = lblPelicula1Duracion.Text;
            pelicula1.Genero = lblPelicula1Genero.Text;
            pelicula1.AnioExhibicion = lblPelicula1AnioExhibicion.Text;

            pelicula2.Nombre = lblPelicula2Nombre.Text;
            pelicula2.Duracion = lblPelicula2Duracion.Text;
            pelicula2.Genero = lblPelicula2Genero.Text;
            pelicula2.AnioExhibicion = lblPelicula2AnioExhibicion.Text;

            pelicula3.Nombre = lblPelicula3Nombre.Text;
            pelicula3.Duracion = lblPelicula3Duracion.Text;
            pelicula3.Genero = lblPelicula3Genero.Text;
            pelicula3.AnioExhibicion = lblPelicula3AnioExhibicion.Text;

            if(chkboxPelicula1.Checked == true)
            {
                dgvSeleccionPeliculas.Rows.Add(pelicula1.Nombre, pelicula1.Duracion, 
                    pelicula1.Genero, pelicula1.AnioExhibicion);
            }
            if (chkboxPelicula2.Checked == true)
            {
                dgvSeleccionPeliculas.Rows.Add(pelicula2.Nombre, pelicula2.Duracion, 
                    pelicula2.Genero, pelicula2.AnioExhibicion);
            }
            if (chkboxPelicula3.Checked == true)
            {
                dgvSeleccionPeliculas.Rows.Add(pelicula3.Nombre, pelicula3.Duracion, 
                    pelicula3.Genero, pelicula3.AnioExhibicion);
            }
            if(chkboxPelicula1.Checked != true && chkboxPelicula2.Checked != true && chkboxPelicula3.Checked != true)
            {
                MessageBox.Show("Debe seleccionar almenos una pelicula");
            }

            chkboxPelicula1.Checked = false;
            chkboxPelicula2.Checked = false;
            chkboxPelicula3.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chkboxPelicula1.Checked = false;
            chkboxPelicula2.Checked = false;
            chkboxPelicula3.Checked = false;
            dgvSeleccionPeliculas.Rows.Clear();
        }

        
    }
}