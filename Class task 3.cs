using System;
using System.Diagnostics.Tracing;

namespace Class_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yazini daxil edin");
            string word = Console.ReadLine();
            bool haswantedchar = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a') ;
                {
                    haswantedchar = true;
                    break;
                }

            }
            if (haswantedchar == true)
            {
                Console.WriteLine("A herfi var");
            }
            else
            {
                Console.WriteLine("A herfi yoxdur");
            }







        }
    }
}    


