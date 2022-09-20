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

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}