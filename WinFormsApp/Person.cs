using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone {get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return $"voornaam: {firstName}, achternaam: {lastName}, telefoonnummer: {phone}, leeftijd: {age}, woonplaats: {city}, land: {country}";
        }



    }
}
