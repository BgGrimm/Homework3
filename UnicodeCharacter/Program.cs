using System;

class UnicodeCharacter
{

    static void Main()
    {
        int code = 72;
        Console.WriteLine("The hexadecimal representation of code 72 is: {0:X}", code);
        char symbol = '\u002A';
        Console.WriteLine("The symbol is: {0}", symbol);
    }
}
