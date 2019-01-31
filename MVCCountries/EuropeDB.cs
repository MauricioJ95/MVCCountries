using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class EuropeDB
    {
        public List<Country> EUCountries;
        public EuropeDB()
        {
            string[] SwedenColors = { "Gold", "Blue" };
            EUCountries.Add(new Country("Sweden", "Swedish", "Hej världen!", SwedenColors));
            string[] MexicoColors = { "Red", "White", "Green" };
            EUCountries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MexicoColors));
            string[] CanadaColors = { "Red", "White" };
            EUCountries.Add(new Country("Canada", "English and French", "Bonjour Le Monde", CanadaColors));
            string[] HondurasColors = { "Blue", "White" };
            EUCountries.Add(new Country("Honduras", "Spanish", "Hola Mundo!", HondurasColors));
            string[] JamaicaColors = { "Green", "Black", "Yellow" };
            EUCountries.Add(new Country("Jamaica", "Patwa", "Hello World!", JamaicaColors));
        }
    }
}
