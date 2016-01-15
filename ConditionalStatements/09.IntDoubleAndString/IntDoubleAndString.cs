using System;

class IntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte choose = byte.Parse(Console.ReadLine());
        switch(choose)
        {
            case 1:
                Console.WriteLine("Please enter a int:");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNum + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                Console.WriteLine("Not a valid choise");
                break;
        }
    }
}