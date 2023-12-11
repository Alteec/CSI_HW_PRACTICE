using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Practice13
{
    class Practice
    {
        static void Task1(List<int> numbers) {

            int secondMaxValue = numbers.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
            int secondMaxIndex = numbers.LastIndexOf(secondMaxValue);

            Console.WriteLine($"Position: {secondMaxIndex}, Value: {secondMaxValue}");

            numbers.RemoveAll(x => x % 2 != 0);

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine('\n');

        }

        static void Task2(List<double> numbers) {

            double average = numbers.Average();

            foreach (var number in numbers.Where(x => x > average))
            {
                Console.Write(number + " ");
            }
            Console.WriteLine('\n');

        }

        static void Main()
        {
            Task1(new List<int> { 1,3,6,1,2,3,79,1,23,9 });
            Task2(new List<double> { 1.1, 3.2, 23.3, 1.6, 2.23, 3.6, 79.2});


        }
    }

}