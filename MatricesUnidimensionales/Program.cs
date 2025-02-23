using System;

namespace MatricesUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAlumnos;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            double[] calificaciones = new double[numAlumnos];

            for (int i = 0; i < numAlumnos; i++)
            {
                Console.Write("Ingresa la calificación: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificaciones[i];
            }

            promedio = sumaCalif / numAlumnos;

            for (int i = 0; i < numAlumnos; i++)
            {
                if (calificaciones[i] < califMin)
                {
                    califMin = calificaciones[i];
                }
            }

            for (int i = 0; i < numAlumnos; i++)
            {
                if (calificaciones[i] > califMax)
                {
                    califMax = calificaciones[i];
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", califMin);
            Console.WriteLine("La calificación máxima es: {0}", califMax);
        }
    }
}
