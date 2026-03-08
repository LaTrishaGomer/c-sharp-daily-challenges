using CodingChallenges;

RunExercise3();

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
