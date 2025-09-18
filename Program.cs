using ConsoleApp1;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;

internal class Program
{

    static List<Town> towns = new List<Town>();

    public static void read()
    {

        StreamReader sr = new StreamReader("town.csv");
        string temp;
        temp = sr.ReadLine();
        string row;

        while ((row = sr.ReadLine()) != null)
        {
            towns.Add(new Town(row));
        }
    }

    static void Main(string[] args)
    {
        read();
        foreach (var item in towns)
        {
            Console.WriteLine(item);
        }
    }
}
