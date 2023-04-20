using System;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem solarSystem = new SolarSystem($"{Environment.CurrentDirectory}\\Data\\Planets.txt");
            
            Console.Write(solarSystem.ToString());
            Console.WriteLine();

            Console.Write("Update planet's distance from sun. Enter planet name: ");
            #nullable disable
            string planetName = Console.ReadLine();
            #nullable enable
            Console.Write("Enter new distance from sun: ");
            #nullable disable
            string distance = Console.ReadLine();
            #nullable enable

            int km = 0;
            bool isInt = int.TryParse(distance, out km);

            if (isInt)
            {   
                #nullable disable
                if (solarSystem.UpdatePlanet(planetName, km))
                #nullable enable
                {
                    solarSystem.Save();
                    Console.WriteLine();
                    Console.Write(solarSystem.ToString());               
                }
                else
                {
                    Console.WriteLine($"{planetName} is not in the solar system");                  
                }
            }
            else 
            {
                Console.WriteLine($"{distance} is not an integer");
            }
           
        }
    }
}