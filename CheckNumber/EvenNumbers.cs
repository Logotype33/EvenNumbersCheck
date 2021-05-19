using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumber
{
    public class EvenNumbers
    {
        public bool CheckForEvenNumber(int number) => number % 2 == 0 ? true : false;
        public int[] GetEvenNumbers(int[] numbers)=> numbers.Where(x => x % 2 == 0).ToArray();
    }
}
