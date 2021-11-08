using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSea_Cruising
{
    internal class TicketClass
    {
        // Ticket From, To, Depart, TicketType {CabinType and Nr}
    }
    public enum Locations { Copenhagen, London, Stockholm } // Different Cabin Classes
    public class Cruises
    {
        public int CruiseID { get; set; }
        public DateTime Departure;
        public DateTime Arrival;
        public Locations Origin { get; set; }
        public Locations Destination { get; set;}
    }


}
