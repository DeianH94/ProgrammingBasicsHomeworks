using System;

class QuotesInStrings
{
    static void Main()
    {
        string varOne = "The \"use\" of quotations causes difficulties.";
        string varTwo = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(varOne);
        Console.WriteLine(varTwo);
    }
}
