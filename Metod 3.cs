using System;

namespace Metod_3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}




       public int SumOfAverage(N , M)
        {
            double sum = 0;
            int count = 0;
            for (int i = N; i < M; i++)
            {
                if (i % 21 == 0)
                {
                    sum += 1;
                    count++;
                }

            }
                if (count==0)
                {
                    sum = 0;
                }


            else
            {
                return sum / count;
            }
            
            


        }


    }
}
