using System;

namespace ArrayParameters.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {





        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
            



        }
    }
}
