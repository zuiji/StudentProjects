using System.Collections.Generic;

namespace StudentCSV.StaticsAndEnums
{
    public static class Statics
    {
        public static readonly List<string> CorrectEducationDirectionEnumNames = new List<string>()
        {
            "IT-Supporter", "Datatekniker med speciale i programmering", "Datatekniker med speciale i infrastruktur"
        };

        public static readonly List<string> CorrectGfSchoolEnumNames = new List<string>()
        {
            "Anden","Køge", "Nykøbing F.", "Ringsted", "Roskilde", "Slagelse", "Vordingborg"

        };
        public static string Path { get; set; }
        public static string Password {get; set;}

    }

}