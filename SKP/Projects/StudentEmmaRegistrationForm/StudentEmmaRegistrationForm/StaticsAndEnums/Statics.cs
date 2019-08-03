using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace StudentEmmaRegistrationForm
{
    public static class Statics
    {
        public static readonly List<string> CorrectEducationDirectionEnumNames = new List<string>()
        {
            "IT-Supporter", "Datatekniker med speciale i programmering", "Datatekniker med speciale i infrastruktur"
        };

        public static readonly List<string> CorrectGfSchoolEnumNames = new List<string>()
        {
            "Køge", "Nykøbing F.", "Ringsted", "Roskilde", "Slagelse", "Vordingborg"

        };
        public static string Path { get; set; }


    }

}