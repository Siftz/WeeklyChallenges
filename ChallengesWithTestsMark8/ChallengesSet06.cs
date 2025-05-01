using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null) return false;
            foreach (string w in words)
            {
                if (ignoreCase)
                {
                    if (w != null && w.ToLower() == word.ToLower())
                        return true;
                }
                else
                {
                    if (w == word)
                        return true;
                }
            }

            return false; // checks if a word in the collection exists and ignores case

        }

        public bool IsPrimeNumber(int num)
        {
            // checking for prime numbers
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)// loop to check divisibility
            {
                if (num % i == 0) return false; // returns false if divisible by any number
                
            }

            return true; // returns true if otherwise, passed
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            /*if (string.IsNullOrEmpty(str)) return -1;
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else charCounts[c] = 1;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCounts[str[i]] == 1)
                    return i;
            }

            return -1; // uses dictionary to track, then loops back to find unique letters but we haven't used dictionary will try other code*/
            if (string.IsNullOrEmpty(str)) return -1;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                bool isUnique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[i] == str[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique) return i;
            }

            return -1; // starts right from left to find unique letter
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
           
            int maxCount = 1, currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                    currentCount++;
                else
                    currentCount = 1;
                maxCount = Math.Max(maxCount, currentCount);
            }

            return maxCount; // iterates the array count consec numbers, tracks highest consec streak
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) return new double[0];

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
            //if elements is null returns empty array
            //returns empty array if n <= 0 to cancel negatives
            // iterates every nth index and increments n each time
            //stores then returns, passed tests
        }
    }
}
