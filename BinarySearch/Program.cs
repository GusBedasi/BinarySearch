using System;
using System.Diagnostics;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberRangeToGuess = new int[1000000];
            
            for (int i = 0; i <= 999999; i++)
            {
                numberRangeToGuess[i] = i;
            }

            int answer = GuessANumber(numberRangeToGuess, 999994);
            //int answer = Array.BinarySearch(numberRangeToGuess, 999994);
            
            Console.WriteLine(answer);
        }
        
        static int GuessANumber(int[] numberRangeToGuess, int target)
        {
            var start = 0;
            var end = numberRangeToGuess.Length - 1;
            
            while(start <= end)
            {
                var middle = (start + end) / 2;

                if (numberRangeToGuess[middle] == target)
                {
                    return numberRangeToGuess[middle];
                }else if (numberRangeToGuess[middle] < target)
                {
                    start = middle + 1;
                }else if (numberRangeToGuess[middle] > target)
                {
                    end = middle - 1;
                }
            }
            
            return -1;
        }
    }
}