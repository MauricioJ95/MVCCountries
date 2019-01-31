using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();
        }
        public void CountryMenu()
        {
            Console.WriteLine("What Continent would you like to learn about?(North America/Europe)");
            string input = Console.ReadLine();
            List<Country> countries;
            if (input.ToLower() == "north america")
            {
                NorthAmericanDB nadb = new NorthAmericanDB();
                countries = nadb.NACountries;
            }
        }
    }
}
