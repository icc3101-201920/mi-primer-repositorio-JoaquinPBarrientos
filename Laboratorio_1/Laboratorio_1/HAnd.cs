using System;
using System.Collections.Generic;

namespace Card
{
    public class Hand
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public Hand()
        {
            combatCards = new List<CombatCard>();
            specialCards = new List<SpecialCard>();
        }

        public List<CombatCard> CombatCards
        {
            get => combatCards;
            set => combatCards = value;
        }

        public List<SpecialCard> SpecialCards
        {
            get => specialCards;
            set => specialCards = value;

        }

        public void AddCombatCard(CombatCard combatCard)
        {
            Console.WriteLine("Adding combat card");
        }

        public void AddSpecialCard(SpecialCard specialCard)
        {
            Console.WriteLine("Adding special card");
        }

        public void DestroyCombatCard(int cardId)
        {
            Console.WriteLine("Destroying card");
        }

        public void DestroySpecialCard(int cardId)
        {
            Console.WriteLine("Destroying card");

        }

    }
}

