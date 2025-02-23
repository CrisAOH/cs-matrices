using System;

namespace MatricesEscalonadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAlumnos, salones;
            double sumaCalif = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[salones][];

            for (int i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                sumaAlumnos += numAlumnos;

                calificaciones[i] = new double[numAlumnos];
            }

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón: {0}", i);
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i][j];
                }
            }

            promedio = sumaCalif / sumaAlumnos;

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón: {0}", i);
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} de calificación.", j, calificaciones[i][j]);
                }
            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", califMin);
            Console.WriteLine("La calificación máxima es: {0}", califMax);
        }
    }
}
