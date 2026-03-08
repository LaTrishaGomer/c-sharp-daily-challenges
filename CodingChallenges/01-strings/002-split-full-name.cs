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

// Exercise 2 solution