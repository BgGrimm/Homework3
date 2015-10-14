using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Name";
        string middleName = "Middle";
        string lastName = "Last";
        decimal money = 394850.57m;
        string bankName = "BulBank";
        string iban = "BG32 UBBS 7827 1013 6179 05";
        long cardNumber1 = 123456669123509;
        long cardNumber2 = 908765442153456;
        long cardNumber3 = 574836123456789;
        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);

    }
}
