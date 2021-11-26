using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class PlayerData
    {
        Player p1 = new() {
            Name = "Lionel Messi",
            Nationality = "Argentina",
            DateOfBirth = new DateTime(1987, 6, 24),
            Height = 169, Weight = 67,
            PreferredFoot = Foot.Left
        };
        Player p2 = new()
        {
            Name = "Christiano Ronaldo",
            Nationality = "Portugal",
            DateOfBirth = new DateTime(1985, 6, 24),
            Height = 169,
            Weight = 67,
            PreferredFoot = Foot.Left
        }
    }
}
