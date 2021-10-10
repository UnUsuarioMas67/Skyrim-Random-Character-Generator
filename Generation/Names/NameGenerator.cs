using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKRandomCharGenerator.Generation.Names
{
    public class NameGenerator
    {
        [XmlIgnore]
        private Random rand = new Random();

        [XmlIgnore]
        private static string fileName 
        { 
            get
            {
                string filepath = @"Data\namelist.xml";

                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory("Data");

                return filepath;
            } 
        }

        [XmlIgnore]
        public bool IsDataProperlyLoaded { get; private set; } = true;

        public List<RaceNameList> Samples;

        private NameGenerator() { }
        
        public string GenerateName(Races race, CharacterSexes sex)
        {
            StringBuilder output = new StringBuilder();
            
            var nameList = Samples.Where(x => x.Race == race).First();

            // get the first name
            if (sex == CharacterSexes.Female)
            {
                int i = rand.Next(nameList.FemaleNames.Count);
                
                if (nameList.FemaleNames.Count != 0)
                    output.Append(nameList.FemaleNames[i]);
            }
            else
            {
                int i = rand.Next(nameList.MaleNames.Count);

                if (nameList.MaleNames.Count != 0)
                    output.Append(nameList.MaleNames[i]);
            }

            // get the surname
            if (nameList.CanHaveSurnames && rand.Next(3) < 2)
            {
                int i = rand.Next(nameList.Surnames.Count);

                if (nameList.Surnames.Count != 0)
                {
                    if (race != Races.Orc)
                        output.Append(" " + nameList.Surnames[i]);
                    else if (sex == CharacterSexes.Male)
                        output.Append(" gro-" + nameList.Surnames[i]);
                    else
                        output.Append(" gra-" + nameList.Surnames[i]);
                }
            }

            return output.ToString();
        }

        public void AddFirstName(string sample, Races race, CharacterSexes sex)
        {
            var nameList = Samples.Where(x => x.Race == race).First();

            if (sex == CharacterSexes.Female)
                nameList.FemaleNames.Add(sample);
            else
                nameList.MaleNames.Add(sample);
        }

        public void RemoveFirstName(string sample, Races race, CharacterSexes sex)
        {
            var nameList = Samples.Where(x => x.Race == race).First();

            if (sex == CharacterSexes.Female)
                nameList.FemaleNames.Remove(sample);
            else
                nameList.MaleNames.Remove(sample);
        }

        public void AddSurname(string sample, Races race)
        {
            var nameList = Samples.Where(x => x.Race == race).First();

            if (!nameList.CanHaveSurnames)
                return;

            nameList.Surnames.Add(sample);    
        }

        public void RemoveSurname(string sample, Races race)
        {
            var nameList = Samples.Where(x => x.Race == race).First();

            nameList.Surnames.Remove(sample);
        }

        /// <summary>
        /// Saves the NameGenerator data into the xml file
        /// </summary>
        public void Save()
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(NameGenerator));
                xml.Serialize(stream, this);
            }
        }

        /// <summary>
        /// Gets the data from the xml file. If there isn't any data a new file will be created
        /// </summary>
        /// <returns></returns>
        public static NameGenerator Initialize()
        {
            if (!File.Exists(fileName))
            {
                return CreateNewFile();
            }

            try
            {
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(NameGenerator));
                    return (NameGenerator)xml.Deserialize(stream);
                }
            }
            catch (InvalidOperationException)
            {
                File.Move(fileName, @"Data\namelist.xml.invalid");
                return new NameGenerator { IsDataProperlyLoaded = false };
            }
        }

        private static NameGenerator CreateNewFile()
        {
            NameGenerator output = new NameGenerator() { Samples = RaceNameList.GetEmptyLists() };

            // serializes an empty NameGenerator instance
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(NameGenerator));
                xml.Serialize(stream, output);
            }

            return output;
        }
    }
}
