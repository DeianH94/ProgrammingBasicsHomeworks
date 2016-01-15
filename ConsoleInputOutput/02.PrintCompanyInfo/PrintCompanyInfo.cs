using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Tel. " + phone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}