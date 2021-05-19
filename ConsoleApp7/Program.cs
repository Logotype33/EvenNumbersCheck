using CheckNumber;
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers check = new EvenNumbers();
            Console.WriteLine(check.CheckForEvenNumber(5));
            var evenNumbs= check.GetEvenNumbers(new int[] { 1, 2, 3, 5, 6 });
            foreach (var item in evenNumbs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
