using System;

namespace ConditionalBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            int porchLumens = 800;
            int moonLumens = 1200;
            int neighborsPorch = 900;
            //string flightPath = porchLumens > neighborsPorch ? "Head to porch" : neighborsPorch > moonLumens ? "visit neighbors" : "Fly to moon";

/*                if (porchLumens > moonLumens)
            {
                flightPath = "Head to porch";
                porchLumens = 0;
            }
            else if (neighborsPorch > moonLumens)
            {
                flightPath = "Vist neighbors";
                neighborsPorch = 0;
            }
            else
                flightPath = "Fly to moon"; */

            Console.WriteLine(porchLumens > neighborsPorch ? "Head to porch" : neighborsPorch > moonLumens ? "visit neighbors" : "Fly to moon");
        }
    }
}