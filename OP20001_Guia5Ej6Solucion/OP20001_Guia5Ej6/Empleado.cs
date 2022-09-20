using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP20001_Guia5Ej6
{
    internal class Empleado
    {
        private string nombre;
        private string apellido;
        private string dui;
        private string edad;

        private double salarioBase = 0;
        private int numVentas = 0; //Numero de ventas realizadas
        private double salarioFinal;
        private double ventasTotales = 0; //Es la ganancia en $ de las ventas totales
        //private double aumentoSalario; //% de aumento en el salario

        public Empleado() { }

        public Empleado(string nombre, string apellido, string dui, string edad,
            double salarioBase, int numVentas, double salarioFinal,
            double aumentoSalario, double ventasTotales)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dui = dui;
            this.edad = edad;
            this.salarioBase = salarioBase;
            this.numVentas = numVentas;
            this.salarioFinal = salarioFinal;
            this.ventasTotales = ventasTotales;
            //this.aumentoSalario = aumentoSalario;
        }


        public double VentasTotales
        {
            get { return ventasTotales; }
            set { ventasTotales = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public int NumVentas
        {
            get { return numVentas; }
            set { numVentas = value; }
        }
        public double SalarioFinal
        {
            get { return salarioFinal; }
            set { salarioFinal = value; }
        }

        public double CalculoSalarial(double aumentoSalario)
        {

            salarioFinal = Math.Round(salarioBase * aumentoSalario, 2);

            return salarioFinal;
        }

    }
}
