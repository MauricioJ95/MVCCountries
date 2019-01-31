using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    class Country
    {
        public string Name;
        public string Language;
        public string Hello;
        public string[] Colors;

        public Country(string Name, string Language, string Hello, string[] Colors)
        {
            this.Name = Name;
            this.Language = Language;
            this.Hello = Hello;
            this.Colors = Colors;
        }
    }
}
