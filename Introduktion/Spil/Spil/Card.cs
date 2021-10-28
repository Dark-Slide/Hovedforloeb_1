using System;
namespace Spil
{
    public class Card
    {

        public enum CharacterType { Theif, Wizard, Fighter, Priest}
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public string Type { get; set; }
            
    }
}

