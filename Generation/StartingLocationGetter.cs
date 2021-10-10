using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using static SKRandomCharGenerator.Generation.ConfigurationHandler;

namespace SKRandomCharGenerator.Generation
{
    public class StartingLocationGetter
    {
        [XmlIgnore]
        private Random rand = new Random();

        [XmlIgnore]
        private static string fileName
        {
            get
            {
                string filepath = @"Data\location.xml";

                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory("Data");

                return filepath;
            }
        }

        public List<string> Samples { get; set; }

        /// <summary>
        /// Saves the NameGenerator data into the xml file
        /// </summary>
        public void Save()
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(StartingLocationGetter));
                xml.Serialize(stream, this);
            }
        }

        /// <summary>
        /// Gets the data from the xml file. If there isn't any data a new file will be created
        /// </summary>
        /// <returns></returns>
        public static StartingLocationGetter Initialize()
        {
            if (!File.Exists(fileName))
            {
                return CreateNewFile();
            }

            try
            {
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(StartingLocationGetter));
                    return (StartingLocationGetter)xml.Deserialize(stream);
                }
            }
            catch
            {
                File.Move(fileName, @"Data\location.xml.invalid");
                return new StartingLocationGetter { Samples = StartingLocationGetter.GetEmptyList() };
            }
        }

        private static StartingLocationGetter CreateNewFile()
        {
            StartingLocationGetter output = new StartingLocationGetter() { Samples = StartingLocationGetter.GetEmptyList() };

            // serializes an empty NameGenerator instance
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(StartingLocationGetter));
                xml.Serialize(stream, output);
            }

            return output;
        }

        private static List<string> GetEmptyList()
        {
            return new List<string>
            {
                "Whiterun",
                "Riverwood",
                "Rorikstead",
                "Falkreath",
                "Helgen",
                "Riften",
                "Ivarstead",
                "Shor's Stone",
                "Windhelm",
                "Solitude",
                "Dragon Bridge",
                "Markath",
                "Karthwasten",
                "Morthal",
                "Dawnstar",
                "Dushnikh Yal",
                "Largashbur",
                "Mor Khazgur",
                "Narzulbur"
            };
        }

        public string GetLocation(Races race)
        {
            var possibleChoices = new List<string>();
            StringBuilder output = new StringBuilder();

            foreach (string s in Samples)
                possibleChoices.Add(s);

            if (race != Races.Orc)
            {
                possibleChoices.Remove("Dushnikh Yal");
                possibleChoices.Remove("Largashbur");
                possibleChoices.Remove("Mor Khazgur");
                possibleChoices.Remove("Narzulbur");
            }

            output.Append(possibleChoices[rand.Next(possibleChoices.Count)]);

            return output.ToString();
        }
    }
}
