using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using CodingChallenges;

RunExercise9();

static void RunExercise2()
{
    var result = SplitFullName.SplitName("Ada Lovelace");

    Console.WriteLine(result.firstName);
    Console.WriteLine(result.lastName);
}

static void RunExercise3()
{
    var result = CharFrequency.Count("hello");

    foreach (var item in result)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}


static void RunExercise9()
{
    var result = Palindrome.IsPalindrome("racecar");

    Console.WriteLine(result);
}
