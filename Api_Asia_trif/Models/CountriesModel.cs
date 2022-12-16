using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Asia_trif.Models
{
    public class CountriesModel
    {
        public CountriesModel(Country country)
        {
            IdCountry = country.IdCountry;
            NameCountry = country.NameCountry;
        }
        public int IdCountry { get; set; }
        public string NameCountry { get; set; }

    }
}