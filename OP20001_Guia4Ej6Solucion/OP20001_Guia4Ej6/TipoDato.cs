using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP20001_Guia4Ej6
{
    internal class TipoDato
    {
        private int numero;
        public int Numero { get { return numero; } set { numero = value; } }

        private int contadorNegativos = 0;
        public int ContadorNegativos { get { return contadorNegativos; }set { contadorNegativos = value; } }

        private int contadorPositivos = 0;
        public int ContadorPositivos { get { return contadorPositivos; }set { contadorPositivos = value; } }

        private int contadorMultiplos = 0;
        public int ContadorMultiplos { get { return contadorMultiplos; }set { contadorMultiplos = value; } }

        private int numParesAcumulados = 0;
        public int NumParesAcumulados {get { return numParesAcumulados; }set { numParesAcumulados = value; } }
    }
    
}
