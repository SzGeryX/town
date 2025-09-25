using ConsoleApp1;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;

internal class Program
{

    static List<Town> towns = new List<Town>();
    static List<int> path = new([ 1,0 ]);

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

    public static bool traverseable(double maxFuel, List<int> path, List<Town> towns)
    {
        double remFuel = maxFuel;

        for (int currentPosId = 0; currentPosId < towns.Count - 1; currentPosId ++)
        {
            if (towns[currentPosId].DistanceToTown(towns[currentPosId + 1]) > remFuel)
            {
                return false;
            }
            
            if (towns[currentPosId].charging)
            {
                remFuel = maxFuel;
                continue;
            }

            remFuel -= towns[currentPosId].DistanceToTown(towns[currentPosId - 1]);
            
        }

        return true;
    }

    static void Main(string[] args)
    {
        read();

        Console.WriteLine(traverseable(5, path, towns));
    }
}
