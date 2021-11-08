using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSea_Cruising
{
    public enum GenderEnum { Female, Male, Disabled } // Passenger Gender Enum
    internal class Passengers : UniversalData
    {
        public GenderEnum Gender { get; set; } = GenderEnum.Disabled; // Create the gettter/setter and sets default to Disabled

        // ID, Email, Phone, Name, Gender, Description, Animal, CreationDate/BookingDate

        public string Description { get; set; }
        // animal
        public DateTime DoB { get; set; }

        public DateTime CreationDate { get; set;}


    }
}
