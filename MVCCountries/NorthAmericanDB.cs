using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class NorthAmericanDB
    {
        public List<Country> NACountries;
        public NorthAmericanDB()
        {
            string[] USColors = { "Red", "White", "Blue" };
            NACountries.Add(new Country("USA", "English", "Hello World!", USColors));
            string[] MexicoColors = { "Red", "White", "Green" };
            NACountries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));
            string[] CanadaColors = { "Red", "White" };
            NACountries.Add(new Country("Canada", "English and French", "Bonjour Le Monde", CanadaColors));
            string[] HondurasColors = { "Blue", "White" };
            NACountries.Add(new Country("Honduras", "Spanish", "Hola Mundo!", HondurasColors));
            string[] JamaicaColors = { "Green", "Black", "Yellow"};
            NACountries.Add(new Country("Jamaica", "Patwa", "Hello World!", JamaicaColors));
        }
    }
}
