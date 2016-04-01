using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansAPI.Modelos
{
    class Jugador
    {
        public string tag { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public int expLevel { get; set; }
        public Liga league { get; set; }
        public int trophies { get; set; }
        public int clanRank { get; set; }
        public int previousClanRank { get; set; }
        public int donations { get; set; }
        public int donationsReceived { get; set; }

    }
}
