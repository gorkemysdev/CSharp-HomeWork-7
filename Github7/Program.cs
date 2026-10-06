using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter 3 digit number: ");
        int n = int.Parse(Console.ReadLine());

        int yn = n / 100;

        Console.WriteLine(yn);

        int on = (n / 10) % 10;

        Console.WriteLine(on);


        int bn = (n / 1) % 10;

        Console.WriteLine(bn);
    }

}