using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSea_Cruising
{
    public enum CabinType { FirstClass, BusinessClass, EconomyClass } // Different Cabin Classes
    public class Cabins
    {
        public CabinType Cabin { get; set; } = CabinType.EconomyClass; // Sets Standard Cabin to EconomyClass
        public int CabinNumber { get; set; } // Cabin Numbers FirstClass = 1-20, BusinessClass = 21-60, EconomyClass = 61-200

    }


}
