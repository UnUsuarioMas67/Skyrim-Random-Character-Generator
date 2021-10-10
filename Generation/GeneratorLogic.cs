using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKRandomCharGenerator.Generation.Names;

namespace SKRandomCharGenerator.Generation
{
    static class GeneratorLogic
    {
        private static Random rand = new Random();

        internal static Races PickRace()
        {
            int r = rand.Next(Enum.GetNames(typeof(Races)).Length);

            return (Races)r;
        }

        internal static CharacterSexes PickSex()
        {
            int s = rand.Next(Enum.GetNames(typeof(CharacterSexes)).Length);

            return (CharacterSexes)s;
        }

        /// <summary>
        /// Returns a list with the major skills
        /// </summary>
        /// <returns></returns>
        internal static SkillSet PickSkills()
        {
            return new SkillSet();
        }
        
        internal static Birthsigns PickSign(Races race, SkillSet skills)
        {
            return new Birthsign(race, skills).Sign;
        }
    }
}
