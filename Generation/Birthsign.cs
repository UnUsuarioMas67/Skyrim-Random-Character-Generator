using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SKRandomCharGenerator.Generation.ConfigurationHandler;

namespace SKRandomCharGenerator.Generation
{
    public class Birthsign
    {
        private static Random rand = new Random();

        private static List<Skills> allSkills = Enum.GetValues(typeof(Skills)).Cast<Skills>().ToList();
        private static List<Birthsigns> allSigns = Enum.GetValues(typeof(Birthsigns)).Cast<Birthsigns>().ToList();

        private static List<Skills> warriorSkills
        {
            get
            {               
                return allSkills.Where(x => (int)x >= 0 && (int)x < 6).ToList();
            }
        }

        private static List<Skills> thiefSkills
        {
            get
            {
                return allSkills.Where(x => (int)x >= 6 && (int)x < 12).ToList();
            }
        }

        private static List<Skills> mageSkills
        {
            get
            {
                return allSkills.Where(x => (int)x >= 12).ToList();
            }
        }

        private static List<Birthsigns> warriorSigns
        {
            get
            {
                return allSigns.Where(x => (int)x >= 0 && (int)x < 4).ToList();
            }
        }

        private static List<Birthsigns> thiefSigns
        {
            get
            {
                return allSigns.Where(x => (int)x >= 4 && (int)x < 8).ToList();
            }
        }

        private static List<Birthsigns> mageSigns
        {
            get
            {
                return allSigns.Where(x => (int)x >= 8 && (int)x < 11).ToList();
            }
        }

        public Birthsigns Sign { get; private set; }

        internal Birthsign(Races race, SkillSet skills)
        {
            // roll for Atronach sign
            if (rand.NextDouble() < ReadSetting("AtronachChance").AsFloat())
            {
                Sign = Birthsigns.Atronach;
                return;
            }
                
            // roll for Serpent sign
            if (rand.NextDouble() < ReadSetting("SerpentChance").AsFloat())
            {
                Sign = Birthsigns.Serpent;
                return;
            }
                
            var groupsCount = CountSkillsPerGroup(skills);
            var greaterGroup = groupsCount.OrderByDescending(x => x.Value).First().Key;
            var signGroup = new List<Birthsigns>();

            // select a group
            switch (greaterGroup)
            {
                case Groups.Warrior:
                    signGroup = warriorSigns;
                    break;

                case Groups.Thief:
                    signGroup = thiefSigns;
                    break;

                case Groups.Mage:
                    signGroup = mageSigns;
                    break;
            }

            // remove apprentice sign if the race is altmer
            if (race == Races.Altmer && signGroup == mageSigns)
                signGroup.Remove(Birthsigns.Apprentice);

            // roll
            Sign = signGroup[rand.Next(signGroup.Count)];
        }

        private Dictionary<Groups, int> CountSkillsPerGroup(SkillSet skills)
        {
            var output = new Dictionary<Groups, int>() 
            { 
                { Groups.Warrior, 0 },
                { Groups.Thief, 0 },
                { Groups.Mage, 0 }
            };

            foreach (Skills skill in skills.All)
            {
                // check if it is a warrior skill
                if (warriorSkills.Contains(skill))
                    ++output[Groups.Warrior];
                // check if it is a thief skill
                else if (thiefSkills.Contains(skill))
                    ++output[Groups.Thief];
                // if isn't either then is a mage skill
                else
                    ++output[Groups.Mage];
            }

            return output;
        }
    }
}
