using System;

class NullValuesAritmetic
{
    static void Main()
    {
        int? randomInt = null;
        int? experiment;
        double? randomDouble = null;
        Console.WriteLine("Null int: " + randomInt);
        Console.WriteLine("Null double: " + randomDouble);
        experiment = randomInt + null;
        Console.WriteLine("Null int + null: " + experiment);
        experiment = randomInt + 42;
        Console.WriteLine("Null int + 42: " + experiment);
    }
}
