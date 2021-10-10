using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKRandomCharGenerator.Generation;

namespace SKRandomCharGenerator
{
    // TODO - Starting Locations
    // TODO - Traits and Goals (1.0.0.0)
    // TODO - Birthsign selector rework (1.0.0.1)

    public class GeneratedCharacter
    {
        public string Name { get; set; }
        public Races Race { get; set; }
        public CharacterSexes Sex { get; set; } 
        public Birthsigns Sign { get; set; }

        public SkillSet CharSkills { get; set; }

        public string StartingLocation { get; set; }

        public List<string> Traits { get; set; }
        public List<string> Goals { get; set; }
        
        public GeneratedCharacter()
        {
            var ng = Generation.Names.NameGenerator.Initialize();
            var slg = Generation.StartingLocationGetter.Initialize();
            
            Race = GeneratorLogic.PickRace();
            Sex = GeneratorLogic.PickSex();
            CharSkills = GeneratorLogic.PickSkills();
            Sign = GeneratorLogic.PickSign(Race, CharSkills);
            Name = ng.GenerateName(Race, Sex);
            StartingLocation = slg.GetLocation(Race);
        }
    }
}
