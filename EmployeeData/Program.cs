using System;

class EmployeeData
{

    static void Main()
    {
        string firstName = "Pesho";
        string lastName = "Peshov";
        sbyte age = 24;
        char geneder = 'm';
        long idNumber = 9199112233;
        int empNumber = 27500000;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", firstName, lastName, age, geneder, idNumber, empNumber);
    }
}