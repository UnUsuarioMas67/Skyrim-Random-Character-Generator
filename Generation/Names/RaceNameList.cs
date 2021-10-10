using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SKRandomCharGenerator.Generation.Names
{
    public class RaceNameList
    {
        [XmlAttribute()]
        public Races Race { get; set; }

        [XmlAttribute]
        public bool CanHaveSurnames = true;

        public List<string> MaleNames { get; set; } = new List<string>();
        public List<string> FemaleNames { get; set; } = new List<string>();
        public List<string> Surnames { get; set; } = new List<string>();


        private RaceNameList() { }

        public static List<RaceNameList> GetEmptyLists()
        {
            return new List<RaceNameList>()
            {
                new RaceNameList { Race = Races.Altmer, CanHaveSurnames = false },
                new RaceNameList { Race = Races.Argonian, CanHaveSurnames = false },
                new RaceNameList { Race = Races.Bosmer, CanHaveSurnames = false },
                new RaceNameList { Race = Races.Breton },
                new RaceNameList { Race = Races.Dunmer },
                new RaceNameList { Race = Races.Imperial },
                new RaceNameList { Race = Races.Khajiit, CanHaveSurnames = false },
                new RaceNameList { Race = Races.Nord },
                new RaceNameList { Race = Races.Orc },
                new RaceNameList { Race = Races.Redguard, CanHaveSurnames = false }
            };
        }
    }
}
