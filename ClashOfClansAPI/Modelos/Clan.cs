using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClansAPI.Modelos
{
    class Clan
    {
        public string tag { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public Localidad location { get; set; }
        public ClanDistintivoUrl badgeUrls { get; set; }
        public string warFrequency { get; set; }
        public int clanLevel { get; set; }
        public int warWins { get; set; }
        public int warWinStreak { get; set; }
        public int clanPoints { get; set; }
        public int requiredTrophies { get; set; }
        public int members { get; set; }
        public IList<Jugador> memberList { get; set; }
    }
}
