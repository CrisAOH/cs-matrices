using System;

namespace Tarea6_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numAlumnos, salones;
            double sumaCalif = 0, sumaCalifSalon, totalAlumnos = 0, promedio, califMin = 10, califMax = 0;

            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calificaciones = new double[salones][];

            Console.WriteLine();

            for (int i = 0; i < salones; i++)
            {
                Console.Write("Ingrese el número de alumnos para el salón {0}: ", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                totalAlumnos += numAlumnos;

                calificaciones[i] = new double[numAlumnos];
            }

            Console.WriteLine();

            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double[salones];

            for (int i = 0; i < salones; i++)
            {
                sumaCalifSalon = 0;
                califMax = 0;
                califMin = 10;
                Console.WriteLine("Salón: {0}", i);
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.Write("Ingresa la calificación del alumno {0}: ", j);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCalif += calificaciones[i][j];
                    sumaCalifSalon += calificaciones[i][j];

                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];  
                    }

                    califMinSalon[i] = califMin;

                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }

                    califMaxSalon[i] = califMax;
                }
                promedioSalon[i] = sumaCalifSalon / calificaciones[i].Length;
            }

            promedio = sumaCalif / totalAlumnos;

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

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DATOS DE LA ESCUELA");

            Console.WriteLine();

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salón: {0}", i);
                for (int j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} de calificación.", j, calificaciones[i][j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACIÓN DEL SALON {0}", i);
                Console.WriteLine("Calificación máxima: {0}, calificación mínima: {1}", califMaxSalon[i], califMinSalon[i]);
                Console.WriteLine("Promedio: {0}", promedioSalon[i]);
            }

            Console.WriteLine();

            Console.WriteLine("El promedio de la escuela es: {0}", promedio);
            Console.WriteLine("La calificación mínima de la escuela es: {0}", califMin);
            Console.WriteLine("La calificación máxima de la escuela es: {0}", califMax);
        }
    }
}
