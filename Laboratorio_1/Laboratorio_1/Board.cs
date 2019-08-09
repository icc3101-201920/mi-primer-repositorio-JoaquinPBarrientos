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
            set => meleeCards = value;
        }

        public List<CombatCard> RangeCards
        {
            get => rangeCards;
            set => rangeCards = value;
        }

        public List<CombatCard> LongRangeCards
        {
            get => longRangeCards;
            set => longRangeCards = value;
        }

        public List<SpecialCard> SpecialMeleeCards
        {
            get => specialMeleeCards;
            set => specialMeleeCards = value;
        }

        public List<SpecialCard> SpecialRangeCards
        {
            get => specialRangeCards;
            set => specialRangeCards = value;
        }

        public List<SpecialCard> SpecialLongRangeCards
        {
            get => specialLongRangeCards;
            set => specialLongRangeCards = value;
        }

        public List<SpecialCard> CaptainCards
        {
            get => captainCards;
            set => captainCards = value;
        }

        public List<SpecialCard> WeatherCards
        {
            get => weatherCards;
            set => weatherCards = value;
        }
    }
}
