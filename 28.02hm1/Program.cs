using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02hm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string> {
                { "Словакия", "Slovakai" },
                { "Турция", "Turkey"},
                { "Украина", "Ukraine" },
                { "Франция", "France"},
                { "Италия", "Italy" },
                { "Испания", "Spain"},
                { "Англия", "England" },
                { "Австрия", "Austria"},
                { "Германия", "Germany"} };
            Console.WriteLine("Choose language:\t1. Englisch\t2. Russian");
            string l = Console.ReadLine();
            int language = Convert.ToInt32(l);
            string country;
            switch (language)
            {
                case 1:
                    Console.Write("Введите страну: ");
                    country = Console.ReadLine();
                    if (countries.ContainsKey(country))
                    {
                        Console.WriteLine($"{country} - {countries[country]}");
                    }
                    else { Console.WriteLine("Такого слова нету :("); }
                    break;
                case 2:
                    Console.Write("Enter country: ");
                    country = Console.ReadLine();
                    foreach (var key in countries.Keys)
                    {
                        if (countries[key] == country)
                        {
                            Console.WriteLine($"{countries[key]} - {key}");
                        }
                    }
                    break;
            }
        }
    }
}