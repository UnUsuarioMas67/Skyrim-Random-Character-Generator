using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SKRandomCharGenerator.Generation.ConfigurationHandler;

namespace SKRandomCharGenerator.Generation
{
    public class SkillSet
    {
        static Random rand = new Random();

        public List<Skills> Majors { get; private set; }
        public List<Skills> Minors { get; private set; }

        public List<Skills> All { get { return Majors.Concat(Minors).ToList(); } }

        public SkillSet()
        {
            Majors = GenerateSkills();
            Minors = GenerateSkills(Majors);
        }

        /// <summary>
        /// Returns a list with the major skills
        /// </summary>
        /// <returns></returns>
        private static List<Skills> GenerateSkills()
        {
            return GenerateSkills(new List<Skills>());
        }

        /// <summary>
        /// Returns a list with the minor skills
        /// </summary>
        /// <param name="majorSkills"></param>
        /// <returns></returns>
        private static List<Skills> GenerateSkills(List<Skills> majorSkills)
        {
            var availableSkills = new List<Skills>();
            var output = new List<Skills>();

            bool outputIsMinor = majorSkills.Count >= ReadSetting("MajorSkillCount").AsInt();

            int totalSkillCount = Enum.GetNames(typeof(Skills)).Length;

            // add skills from the enum to the avaiable skill pool
            for (int i = 0; i < totalSkillCount; ++i)
            {
                // prevents speech and lockpicking from being included as major skills
                if (((Skills)i == Skills.Speech || (Skills)i == Skills.Lockpicking) && !outputIsMinor)
                    continue;

                // includes the skill to the pool only if it's NOT enchanting or already in the major skill list 
                if ((Skills)i != Skills.Enchanting && !majorSkills.Contains((Skills)i))
                    availableSkills.Add((Skills)i);
            }

            int requiredSkillsAmount = !outputIsMinor ? ReadSetting("MajorSkillCount").AsInt() : ReadSetting("MinorSkillCount").AsInt();

            // picks three skills from the first list and adds them to the output list
            while (output.Count < requiredSkillsAmount)
            {
                // avoids conflict between skills
                if (ReadSetting("PreventSkillConflict").AsBool() == true)
                {
                    HandleOverlappingSkills(majorSkills, availableSkills, output);
                    HandleConflictingSkills(availableSkills, output);
                }

                // chance roll to include Enchanting
                if (!majorSkills.Concat(output).ToList().Contains(Skills.Enchanting))
                    if (rand.NextDouble() < ReadSetting("EnchantingChance").AsFloat())
                    {
                        output.Add(Skills.Enchanting);
                        continue;
                    }

                int s = rand.Next(availableSkills.Count);

                output.Add(availableSkills[s]);
                availableSkills.Remove(availableSkills[s]);
            }

            if (!outputIsMinor) return output;

            // makes the class contains at least one offensive skills and one defensive skill
            var offenseSkills = new List<Skills> { Skills.Destruction, Skills.Conjuration, Skills.Illusion,
            Skills.OneHanded, Skills.TwoHanded, Skills.Marksmanship };

            var defenseSkills = new List<Skills> { Skills.HeavyArmor, Skills.LightArmor, Skills.Alteration, Skills.Sneak };

            var skillsInUse = output.Concat(majorSkills).ToList();

            if (!skillsInUse.Intersect(offenseSkills).Any())
            {
                // this is to prevent replacing the defense skill if there is only one
                bool hasMultipleDefenseSkills = output.Intersect(defenseSkills).ToList().Count > 1;

                var oldSkill = hasMultipleDefenseSkills ? 
                    output.First() : output.Where(x => !defenseSkills.Contains(x)).First();

                var newSkill = offenseSkills[rand.Next(offenseSkills.Count)];

                output.Remove(oldSkill);
                output.Add(newSkill);
            }

            if (!skillsInUse.Intersect(defenseSkills).Any())
            {
                // this is to prevent replacing the offense skill if there is only one
                bool hasMultipleOffenseSkills = output.Intersect(offenseSkills).ToList().Count > 1;

                var oldSkill = hasMultipleOffenseSkills ? 
                    output.First() : output.Where(x => !offenseSkills.Contains(x)).First();

                var newSkill = defenseSkills[rand.Next(defenseSkills.Count)];

                output.Remove(oldSkill);
                output.Add(newSkill);
            }

            return output;
        }

        private static void HandleConflictingSkills(List<Skills> availableSkills, List<Skills> output)
        {
            // prevents marksmanship and destruction from being in the same category
            if (output.Contains(Skills.Marksmanship))
                availableSkills.Remove(Skills.Destruction);
            else if (output.Contains(Skills.Destruction))
                availableSkills.Remove(Skills.Marksmanship);

            // alchemy and restoration
            if (output.Contains(Skills.Alchemy))
                availableSkills.Remove(Skills.Restoration);
            else if (output.Contains(Skills.Restoration))
                availableSkills.Remove(Skills.Alchemy);

            // illusion and conjuration
            if (output.Contains(Skills.Illusion))
                availableSkills.Remove(Skills.Conjuration);
            else if (output.Contains(Skills.Conjuration))
                availableSkills.Remove(Skills.Illusion);
        }

        private static void HandleOverlappingSkills(List<Skills> majorSkills, List<Skills> availableSkills, List<Skills> output)
        {
            var skillsInUse = output.Concat(majorSkills).ToList();

            // prevents melee skills from being paired together
            if (skillsInUse.Contains(Skills.OneHanded))
                availableSkills.Remove(Skills.TwoHanded);
            else if (skillsInUse.Contains(Skills.TwoHanded))
                availableSkills.Remove(Skills.OneHanded);

            // prevents heavy armor from being paired with light armor or sneak and viceversa
            if (skillsInUse.Contains(Skills.LightArmor) || skillsInUse.Contains(Skills.Sneak))
                availableSkills.Remove(Skills.HeavyArmor);
            else if (skillsInUse.Contains(Skills.HeavyArmor))
            {
                availableSkills.Remove(Skills.LightArmor);
                availableSkills.Remove(Skills.Sneak);
            }

            // prevents blocking from being selected if there aren't any skills it can be paired with
            if (!skillsInUse.Contains(Skills.OneHanded) || !skillsInUse.Contains(Skills.TwoHanded) || !skillsInUse.Contains(Skills.Destruction)
                && availableSkills.Contains(Skills.Block))
                availableSkills.Remove(Skills.Block);
            else if (!skillsInUse.Contains(Skills.Block))
                availableSkills.Add(Skills.Block);

            // prevents smithing and alchemy from being paired
            if (skillsInUse.Contains(Skills.Smithing))
                availableSkills.Remove(Skills.Alchemy);
            else if (skillsInUse.Contains(Skills.Alchemy))
                availableSkills.Remove(Skills.Smithing);

            // makes sure pickpocket is only available when sneak is already selected
            if (!skillsInUse.Contains(Skills.Sneak))
            {
                if (availableSkills.Contains(Skills.Pickpocket))
                    availableSkills.Remove(Skills.Pickpocket);
            }
            else if (!skillsInUse.Contains(Skills.Pickpocket))
                    availableSkills.Add(Skills.Pickpocket);
        }

    }
}
