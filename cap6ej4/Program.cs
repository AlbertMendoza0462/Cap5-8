using System;
using System.Collections.Generic;
using System.Text;
namespace AplicacionBase
{
    class Program
    {
        // Esta es la función principal del programa
        // Aquí inicia la aplicacion
        public static void capturarInformacion(ref int salones, ref int cantidad, ref string valor, ref float[,] calif)
        {
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon {0}", n);
                for (int m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calif[n, m] = Convert.ToSingle(valor);
                }
            }
        }

        public static void encontrarPromedio(ref int salones, ref int cantidad, ref float[,] calif, ref float suma, ref float promedio)
        {
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    suma += calif[n, m];
                }
            }
            promedio = suma / (cantidad * salones);
        }

        public static void calificacionMenor(ref int salones, ref int cantidad, ref float[,] calif, ref float minima)
        {
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] < minima)
                        minima = calif[n, m];//8098666222
                }
            }
        }

        public static void calificacionMayor(ref int salones, ref int cantidad, ref float[,] calif, ref float maxima)
        {
            for (int n = 0; n < salones; n++) // Ciclo salones
            {
                for (int m = 0; m < cantidad; m++) // Ciclo alumnos
                {
                    if (calif[n, m] > maxima)
                        maxima = calif[n, m];
                }
            }
        }

        static void Main(string[] args)
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos
            string valor = "";
            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima
            // Pedimos la cantidad de salones
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
            // Pedimos la cantidad de alumnos
            Console.WriteLine("Dame la cantidad de alumnos por salon");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            // Creamos el arreglo
            float[,] calif = new float[salones, cantidad];
            // Capturamos la información
            capturarInformacion(ref salones, ref cantidad, ref valor, ref calif);
            // Encontramos el promedio
            encontrarPromedio(ref salones, ref cantidad, ref calif, ref suma, ref promedio);
            // Encontramos la calificación mínima
            calificacionMenor(ref salones, ref cantidad, ref calif, ref minima);
            // Encontramos la calificación maxima
            calificacionMayor(ref salones, ref cantidad, ref calif, ref maxima);
            // Desplegamos los resultados
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación maxima es {0}", maxima);
        } // Cierre de main
    }
}