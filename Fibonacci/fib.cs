using System;
using System.IO;
using System.Numerics;

class Fib
{
    static void Main()
    {
        // UI regelen
        Console.Write("Voer nummer in: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = Fibonacci(n);
        Console.WriteLine(result);
        BigInteger lenght = result.ToString().Length;
        using (StreamWriter file = new StreamWriter("./fib.txt"))
        {
            file.Write(result);
            file.Close();
        }
        Console.WriteLine($"{lenght} cijfers geschreven naar bestand \"fib.txt\".");
    }
    static BigInteger Fibonacci(BigInteger n)
    {
        BigInteger a = 0;
        BigInteger b = 1;

        // Als n < 0
        if (n < 0)
        {
            Console.WriteLine("Invalide getal! Voer een positief getal in!");
            return -1;
        }

        // Als n = 0
        else if (n == 0)
        {
            return 0;
        }

        // Als n = 1
        else if (n == 1)
        {
            return b;
        }
        else
        {
            for (BigInteger i = 1; i < n; i++)
            {
                BigInteger c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}