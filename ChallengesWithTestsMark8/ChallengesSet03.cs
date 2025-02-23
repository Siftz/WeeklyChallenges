using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
                return false;
            foreach (bool val in vals)
            {
                if (!val) // if val returns false 
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers== null)
                return false;
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 != 0) // check if odd
                {
                    sum += num;
                }
            }

            return sum % 2 != 0; //check if sum is odd
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpper = true;
                else if (char.IsLower(c))
                    hasLower = true;
                else if (char.IsNumber(c))
                    hasNumber = true;
                
                if (hasUpper && hasLower && hasNumber)
                    return true; // exit 
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return '\0'; // Return null character (or handle differently as needed)
            }
            return val[0]; //returns first letter
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2) // incrementing by 2 to get odd numbers
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null || words.Length == 0) // if words is null or empty do nothing
                return;
            for (int i = 0; i < words.Length; i++) // loop the array
            {
                words[i] = words[i].ToUpper(); // replace each string with uppercase
            }
        }
    }
}
