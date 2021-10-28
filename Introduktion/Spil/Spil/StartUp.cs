using System;
namespace Spil
{
    public class StartUp
    {
        List<Card> P1Deck = new List<Card>();
        List<Card> P2Deck = new List<Card>();
        
        public void Start()
        {
            AddCards(P1Deck);

        }


        void CombatEngine(Card Player1, Card Player2)
        {
            t
        }

        public List<Card> AddCards(List<Card> cards)
        {
            Card card1 = new Card()
            {
                Name = "Imoen",
                HitPoints = 100,
                Type = CharacterType.Theif
            };
            Card card2 = new Card()
            {
                Name = "Jon Snow",
                HitPoints = 100,
                Type = CharacterType.Fighter
            };
            Card card3 = new Card()
            {
                Name = "Gandalf",
                HitPoints = 100,
                Type = CharacterType.Wizard
            };
            Card card4 = new Card()
            {
                Name = "Imoen",
                HitPoints = 100,
                Type = CharacterType.Earth
            };
        }
    }


}

