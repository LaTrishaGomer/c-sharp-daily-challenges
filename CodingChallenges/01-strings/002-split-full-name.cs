/*
Exercise 002 — Split Full Name

Goal:
Split a full name into first and last names.

Practice:
- String splitting
- Returning named tuples

Example:
Input: "Ada Lovelace"
Output: ("Ada", "Lovelace")

Steps:
1. Take the full name string
2. Split it using the space character
3. The first part is the first name
4. The second part is the last name
5. Return both values
*/

namespace CodingChallenges;

public class SplitFullName
{
    public static (string firstName, string lastName) SplitName (string fullName)
    {
       var parts = fullName.Split(' ');

       return (parts[0], parts[1]);
    }
}
