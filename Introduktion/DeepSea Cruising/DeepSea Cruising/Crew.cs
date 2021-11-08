using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSea_Cruising
{
    public enum CrewRole { Captain, Sailor, Cook, Waiter, Engineer }
    public class Crew : UniversalData
    {
        // Crew Email, Phone, Name, Work Hours (From, To), Role (Captain, Sailor, Cook, Waiter, "Engineer?")

        public DateTime WorkStart { get; set; } = new DateTime(2021, 1, 13, 0, 0, 0, 0);
        public DateTime WorkEnd { get; set; } = new DateTime(2021, 1, 13, 0, 0, 0, 0);
        public CrewRole Role { get; set; }

    }
}
