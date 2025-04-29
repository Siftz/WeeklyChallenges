using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n; //didn't pass test fully (re trying with '(' after 1)---
            //int nextNumber = startNumber + 1;
            //while (nextNumber % n != 0)
           // {
           //     nextNumber++;
            //}
            //return startNumber; still didnt pass test --
            
            //return startNumber + (n - (startNumber % n)); // finally passed but noticed a typo on first try 
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null) return;
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false; // fixed a typo for '>' passed test after fix
            }
            return true; // passed after fixing
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum; // passed 
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return ""; // returns empty string if words, null or an empty array
            List<string> filteredWords = new List<string>(); // create a list
            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word)) // checks if word is empty or only spaces
                {
                    filteredWords.Add(word.Trim()); // removes extra spaces
                }
            }
            if (filteredWords.Count == 0) return "";
            return string.Join(" ", filteredWords) + "."; //passed 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4) return new double[] { };
            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4) // starts index at 3
            {
                result.Add(elements[i]);
            }
            return result.ToArray(); // passed after making into an array for return
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2) return false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) // Ensure different elements are checked
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false; // passed
        }
    }
}
