using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class Town
    {
        string name;
        int population;
        bool charging;
        Vector2 cords;

        public Town(string line)
        {
            string[] data = line.Split(';');

            this.name = data[0];
            this.population = int.Parse(data[1]);
            this.charging = Convert.ToBoolean(int.Parse(data[2]));
            this.cords = new Vector2(float.Parse(data[3]), float.Parse(data[4]));

        }
    }
}
