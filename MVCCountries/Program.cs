using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();

            cc.CountryDetails(c);
        }
    }
}
            //string[] colors = { "red", "white", "blue" };
            //Country c = new Country("Stankonia", "Stankonese", "Hello World!", colors);
