using ConsoleApp1;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;

internal class Program
{ 
    
    private static void Main(string[] args)
    {
        Town test = new Town("town;123;1;2;3");

        Console.WriteLine(test.Stringify());
    }
}
