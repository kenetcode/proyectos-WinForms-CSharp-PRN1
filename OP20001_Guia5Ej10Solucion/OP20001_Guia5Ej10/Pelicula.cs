using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP20001_Guia5Ej10
{
    internal class Pelicula
    {
        private string nombre;
        private string enlaceTrailer;
        private string duracion;
        private string genero;
        private string anioExhibicion;

        public Pelicula()
        {
            nombre = "";
            enlaceTrailer = "";
            duracion = "";
            genero = "";
            anioExhibicion = "";
        }

        public Pelicula(string nombre, string enlaceTrailer, string duracion, string genero, string anioExhibicion)
        {
            this.nombre = nombre;
            this.enlaceTrailer = enlaceTrailer;
            this.duracion = duracion;
            this.genero = genero;
            this.anioExhibicion = anioExhibicion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string EnlaceTrailer
        {
            get { return enlaceTrailer; }
            set { enlaceTrailer = value; }
        }
        public string Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string AnioExhibicion
        {
            get { return anioExhibicion; }
            set { anioExhibicion = value; }
        }
    }
}
