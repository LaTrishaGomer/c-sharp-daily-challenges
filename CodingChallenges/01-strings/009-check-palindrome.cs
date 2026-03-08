/*
Exercise 009 — Palindrome Check

Goal:
Determine whether a string reads the same forwards and backwards.

Practice:
- String comparison
- Index-based iteration
*/

namespace CodingChallenges
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while(left < right)
            {
                if(word[left] != word[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}