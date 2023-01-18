using System;

namespace Metod2
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}



        public int Sum(int N)
        {
            int n = N;
            int sum ;


            if (n<=0) ;
            sum = 0;
            while (n>0)
            {
                sum = sum + n % 10;
                n = n / 10;

            }
            return sum;
        }


    }
}
