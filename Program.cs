using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Galaxy

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Galaxies> galaxies = new List<Galaxies>();
            List<Planets> planets = new List<Planets>();
            List<Stars> stars = new List<Stars>();
            List<Moon> moons = new List<Moon>();

            Galaxies gx = new Galaxies();
            Planets plt = new Planets();
            Stars st = new Stars(); 
            Moon mn = new Moon();

            while (true)
            {
                string row = Console.ReadLine();
                string[] input = row.Split(" ");
                if (input[0] == "add")
                {
                    if (input[1] == "galaxy")
                    {
                        Enum.TryParse(input[4], out Galaxy_Type galaxyType);
                        gx = new Galaxies(input[2].Substring(1, input[2].Length - 1) + " " + input[3].Substring(0, input[3].Length - 1), galaxyType, input[5]);
                        galaxies.Add(gx);
                    }
                    else if (input[1] == "star")
                    {
                        st = new Stars(gx, input[4].Substring(1, input[4].Length - 2), Convert.ToDecimal(input[5]), Convert.ToDecimal(input[6]), Convert.ToInt32(input[7]), Convert.ToDecimal(input[8]));
                        stars.Add(st);
                    }
                    else if (input[1] == "planet")
                    {
                        bool habitable;
                        Enum.TryParse(input[4], out Planet_Type planetType);
                        if (input[5] == "yes")
                            habitable = true;
                        else
                            habitable = false;
                        plt = new Planets(st, input[3].Substring(1, input[3].Length - 2), planetType, habitable);
                        planets.Add(plt);
                    }
                    else
                    {
                        mn = new Moon(plt, input[3].Substring(1, input[3].Length - 2));
                        moons.Add(mn);
                    }
                }

                if (row == "stats")
                {
                    Console.WriteLine("--- Stats ---");
                    Console.WriteLine("Galaxies: " + galaxies.Count());
                    Console.WriteLine("Stars: " + stars.Count());
                    Console.WriteLine("Planets: " + planets.Count());
                    Console.WriteLine("Moons: " + moons.Count());
                    Console.WriteLine("--- End of stats ---");
                }

                if (row == "list galaxies")
                {
                    Console.WriteLine("--- List of all researched galaxies ---");
                    foreach (var galaxy in galaxies)
                    {
                        Console.WriteLine(galaxy.Name);
                    }

                    Console.WriteLine("--- End of galaxies list ---");
                }

                if (input[0] == "print")
                {
                    string inpName = input[1].Substring(1, input[1].Length - 1) + " " + input[2].Substring(0, input[2].Length - 1);
                    Console.WriteLine("--- Data for " + inpName + " galaxy ---");
                    foreach (var galaxy in galaxies)
                    {
                        if (galaxy.Name == inpName)
                        {
                            Console.WriteLine("Type: " + galaxy.Type);
                            Console.WriteLine("Age: " + galaxy.Age);
                            Console.WriteLine("Stars:");
                            for (int i1 = 0; i1 < stars.Count; i1++)
                            {
                                Stars star = stars[i1];
                                if (star.gxName == inpName)
                                {
                                    string clsName = GetStar_Class(star.Temperature);
                                    Console.WriteLine("Name: " + star.Name);
                                    Console.WriteLine("Class: " + clsName + "(" + star.Weight + "," + star.Size + "," + star.Temperature + "," + star.Lightness + ")");
                                }
                                Console.WriteLine("Planets:");
                                foreach (var planet in planets)
                                {
                                    if (planet.starName == star.Name)
                                    {
                                        Console.WriteLine("Name: " + planet.Name);
                                        Console.WriteLine("Type: " + planet.Type);
                                        Console.WriteLine("Support life: " + planet.Obitaemi);
                                    }
                                    Console.WriteLine("Moons:");
                                    for (int i = 0; i < moons.Count; i++)
                                    {
                                        Moon moon = moons[i];
                                        if (moon.planetName == planet.Name)
                                        {
                                            Console.WriteLine(moon.Name);
                                        }
                                    }
                                }

                            }
                        }
                    }
                    Console.WriteLine("--- End of data for " + inpName + " galaxy ---");

                }
                if (row == "exit")
                {
                    Environment.Exit(-1);
                }
            }
        }

        public static string GetStar_Class(int temperature)
        {
            if (temperature > 30000)
                return "O";
            else if (temperature > 10000 && temperature < 30000)
                return "B";
            else if (temperature > 7500 && temperature < 10000)
                return "A";
            else if (temperature > 6000 && temperature < 7500)
                return "F";
            else if (temperature > 5200 && temperature < 6000)
                return "G";
            else if (temperature > 3700 && temperature < 5200)
                return "K";
            else
                return "M";
        }

    }
}
