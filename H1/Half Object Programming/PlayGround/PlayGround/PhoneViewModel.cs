using System;
using System.Collections.Generic;

namespace PlayGround
{
    public class PhoneViewModel
    {
        private List<Phone> Phones { get; set; }

        public PhoneViewModel()
        {
            Phones = new List<Phone>();
            Phone.Model = "Sony";
            Phones.Add( new Phone("25831812"));
            Phones.Add( new Phone("25831813"));
            Phones.Add( new Phone("25831814"));
            
        }

        public string PrintAll()
        {
            string h = "";
            foreach (Phone phone in Phones)
            {
                h += $"Phone Number {phone.PhoneNumber} Model {Phone.Model}\n";
            }

            return h;
        }

    }
}