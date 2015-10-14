using System;
using System.Text;

class IsoscelesTriangle
{
    // Не излиза правилно символът, не знам къде греша!
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyRight);
    }
}