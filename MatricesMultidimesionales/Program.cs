using System;

namespace MatricesMultidimesionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAlumnos, salones;
            double sumaCalif = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese el número de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            double[,] calificaciones = new double[salones, numAlumnos];

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón: {0}", i);
                for (int j = 0; j < numAlumnos; j++)
                {
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i, j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i, j];
                }
            }

            promedio = sumaCalif / (numAlumnos * salones);

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < numAlumnos; j++)
                {
                    if (calificaciones[i, j] < califMin)
                    {
                        califMin = calificaciones[i, j];
                    }

                    if (calificaciones[i, j] > califMax)
                    {
                        califMax = calificaciones[i, j];
                    }
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", califMin);
            Console.WriteLine("La calificación máxima es: {0}", califMax);
        }
    }
}
