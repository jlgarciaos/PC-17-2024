using System;

namespace SecuenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int prevPrev = 0;
            int prev = 1;
            int current = 1;
            int n = 0;
            Console.Write("Ingresa un número mayor a 0 ");
            
            while (n <= 0)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.Write("Ingresa otro número ");
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Ingresa un número entero ");
                }
            }

            Console.WriteLine("Secuencia de Fibonacci hasta " + n + ":");

            Console.Write(current + " ");
            while (current <= n)
            {
                current = prev + prevPrev;
                prevPrev = prev;
                prev = current;
                Console.Write(current + " ");
            }
            Console.WriteLine();
        }
    }
}