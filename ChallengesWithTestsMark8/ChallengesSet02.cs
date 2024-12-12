using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0) //could also work with (num % 2!=0) then use true if and false else
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)//specifies how a collection should behave
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)// compare with greater than and less than
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers) // has null possibility
        {
            if (numbers == null)
            {
                return 0;
            }
            var trueSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                trueSum += numbers[i];
            }
            return trueSum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) // has null possibility 
            {
                return 0;
            }
            var evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            //need return sum;
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
             if (numbers == null) //null possible
             {
                 return false; // returns a bool not int 
             }
             return numbers.Sum() % 2 != 0; 
        }

        public long CountOfPositiveOddsBelowNumber(long number) //need a loop for this
        {
            var count = 0;

            if (number == 1 || number <= 0)
            {
                return 0;
            }

            for (long i = number; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
