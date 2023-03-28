using System;

namespace ArrayParameters.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 8, 16 };
            double averageResult = GetAverage(studentsGrades);

            Console.WriteLine("The average is: {0}", averageResult);




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
