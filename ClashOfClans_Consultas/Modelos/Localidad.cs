using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans_Consultas.Modelos
{
    class Localidad
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isCountry { get; set; }
        public string countryCode { get; set; }
    }
}
