using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanovich";
        decimal accountBalance = 9876.54m;
        string bankName = "Random bank";
        string IBAN = "AB12 CDEF 3456 7890 1234 56";
        ulong cardNumOne = 333333333333333;
        ulong cardNumTwo = 444444444444444;
        ulong cardNumThree = 555555555555555;
        Console.WriteLine("First name: " + firstName + "\nMidle name: " + middleName + "\nLast name: " + lastName + 
            "\nAccount balance: " + accountBalance + "\nBank name: " + "\nIBAN: " + IBAN + "\nFirst card number: " + 
            cardNumOne + "\nSecond card number: " + cardNumTwo + "\nThird card number: " + cardNumThree);
    }
}
