using System;
using System.Threading;

namespace Class_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 21;
            int M = 43;
            int Count = 0;
            double sum = 0;

            for (int i = N; i < M; i++)
            {
                if (i % 21 == 0)

                    {
                        sum += i;
                        Count++;

                    }
            }

            if (Count == 0)

            {

                Console.WriteLine("Eded yoxdur");
            }

            else

            {
                Console.WriteLine(sum / Count);
            }







        }







        }



    }

