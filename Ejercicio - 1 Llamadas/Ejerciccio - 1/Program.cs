using System;

class Program
{
    static void Main()
    {
        // Definir la tabla de precios por zona
        decimal precioZona12 = 2;
        decimal precioZona15 = 2.2m;
        decimal precioZona18 = 4.5m;
        decimal precioZona19 = 3.5m;
        decimal precioZona23 = 6;

        //defino variable para el bucle while
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Bienvenido a la calculadora de llamadas\n");


            // Solicitar la clave de zona y el número de minutos al usuario
            Console.Write("Ingrese la clave de zona (12, 15, 18, 19, o 23): ");
            int claveZona = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de minutos hablados: ");
            int minutosHablados = Convert.ToInt32(Console.ReadLine());

            // Calcular el costo de la llamada
            decimal costoLlamada = 0;

            switch (claveZona)
            {
                case 12:
                    costoLlamada = minutosHablados * precioZona12;

                    //impresion de resultados
                    Console.WriteLine("Has hablado a América del norte el costo de llamada es $" + costoLlamada );
                    break;
                case 15:
                    costoLlamada = minutosHablados * precioZona15;

                    //impresion de resultados
                    Console.WriteLine("Has hablado a América central el costo de llamada es $" + costoLlamada);

                    break;
                case 18:
                    costoLlamada = minutosHablados * precioZona18;

                    //impresion de resultados
                    Console.WriteLine("Has hablado a América del sur el costo de llamada es $" + costoLlamada);
                    break;
                case 19:
                    costoLlamada = minutosHablados * precioZona19;

                    //impresion de resultados
                    Console.WriteLine("Has hablado a Europa el costo de llamada es $" + costoLlamada);
                    break;
                case 23:
                    costoLlamada = minutosHablados * precioZona23;

                    //impresion de resultados
                    Console.WriteLine("Has hablado a Asia el costo de llamada es $" + costoLlamada);
                    break;
                default:
                    Console.WriteLine("Por favor ingresa una clave de zona válida.");
                    break;

            } //cierre de switc

            //se realiza la pregunta al usuario si desea seguir calculando
            Console.WriteLine("\nDesea realizar salir del sistema de llamada (Si / No): ");
            string respuesta = Console.ReadLine();


            //usamos el la Linea ToLower para convertir los posibles "Si", "SI", "sI", "sí", "Sí", "SÍ", etc... a minusculas 
            continuar = (respuesta.ToLower() == "si" || respuesta.ToLower() == "sí");


        } //Cierre de While


    }
}
