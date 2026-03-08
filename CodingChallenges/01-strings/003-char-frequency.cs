/*
Exercise 003 — Character Frequency

Goal:
Count how many times each character appears in a string.

Practice:
- Iteration
- Dictionaries

Steps:
//1. Create a dictionary
//2. Loop through each character
//3. If character already exists, increase count
//4. Otherwise add it with value 1
//5. Return dictionary
*/


namespace CodingChallenges
{
    public class CharFrequency
    {
        public static Dictionary<char, int> Count(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            return counts;
        }
    }
}