using System;

namespace LavaderoDeAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Lavadero de KJ!");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar un nuevo cliente");
            Console.WriteLine("2. Realizar un servicio");
            Console.WriteLine("3. Consultar ingresos diarios");
            Console.WriteLine("4. Consultar ingresos mensuales");
            Console.WriteLine("5. Salir");

            string opcionSeleccionada = Console.ReadLine();

            switch (opcionSeleccionada)
            {
                case "1":
                    // Lógica para registrar un nuevo cliente
                    break;

                case "2":
                    // Lógica para registrar un servicio
                    break;

                case "3":
                    // Lógica para consultar ingresos diarios
                    break;

                case "4":
                    // Lógica para consultar ingresos mensuales
                    break;

                case "5":
                    Console.WriteLine("Gracias por utilizar el Lavadero de Autos. ¡Hasta luego!");// Lógica para consultar ingresos mensuales
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor seleccione una opción del 1 al 5.");
                    break;
            }
        }
    }
}
