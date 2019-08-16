using System;
using System.Collections.Generic;

namespace Card
{
    public class Board
    {
        private List<CombatCard> meleeCards;
        private List<CombatCard> rangeCards;
        private List<CombatCard> longRangeCards;
        private List<SpecialCard> specialMeleeCards;
        private List<SpecialCard> specialRangeCards;
        private List<SpecialCard> specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        public Board()
        {
            meleeCards = new List<CombatCard>();
            rangeCards = new List<CombatCard>();
            longRangeCards = new List<CombatCard>();
            specialMeleeCards = new List<SpecialCard>();
            specialRangeCards = new List<SpecialCard>();
            specialLongRangeCards = new List<SpecialCard>();
            captainCards = new List<SpecialCard>();
            weatherCards = new List<SpecialCard>();
        }

        public List<CombatCard> MeleeCards
        {
            get => meleeCards;
          
        }

        public List<CombatCard> RangeCards
        {
            get => rangeCards;
            
        }

        public List<CombatCard> LongRangeCards
        {
            get => longRangeCards;
           
        }

        public List<SpecialCard> SpecialMeleeCards
        {
            get => specialMeleeCards;
            
        }

        public List<SpecialCard> SpecialRangeCards
        {
            get => specialRangeCards;
            
        }

        public List<SpecialCard> SpecialLongRangeCards
        {
            get => specialLongRangeCards;
           
        }

        public List<SpecialCard> CaptainCards
        {
            get => captainCards;
        
        }

        public List<SpecialCard> WeatherCards
        {
            get => weatherCards;
            
        }

        public void AddCombatCard(int playerId,CombatCard combatCard)
        {

            Console.WriteLine("No se que hacer");


        }
    }
}
