using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            Stopwatch stopWatch = new Stopwatch();

            //StopWatch stopWatch = new StopWatch();

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor Ingrese una opcion:\n");
                Console.WriteLine("1-Empezar Cronometro\n");
                Console.WriteLine("2-Parar Cronometro\n");
                Console.WriteLine("3-Salir\n");

                bool resultado = int.TryParse(Console.ReadLine(), out opcion);

                if (resultado)
                {

                    switch (opcion)
                    {
                        case 1:


                            //stopWatch.Arrancar();

                            stopWatch.Start();
                            Console.WriteLine("Cronometro en marcha...");
                            Thread.Sleep(new Random(Guid.NewGuid().GetHashCode()).Next(10000, 50000));


                            break;

                        case 2:


                            stopWatch.Stop();

                            TimeSpan ts = stopWatch.Elapsed;
                            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);

                            Console.WriteLine("Tiempo: " + elapsedTime);

                            Console.ReadLine();

                            stopWatch.Reset();

                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Que tenga un buen dia"); break;



                        default:
                            Console.WriteLine("Ingrese un Numero valido");
                            break;















                    }











                }
                else
                {

                    Console.WriteLine("Ingrese un valor valido");

                }






            } while (opcion != 3);


        }
    }
}
