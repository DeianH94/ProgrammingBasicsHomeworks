using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object i = hello + " " + world;
        string helloWorld = (string) i;
        Console.WriteLine(helloWorld);
    }
}
