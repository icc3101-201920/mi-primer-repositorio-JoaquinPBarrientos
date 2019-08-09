using System;
namespace Card
{
    public class CombatCard
    {
        private string name;
        private int attackPoints;
        private bool hero;
        private string type;
        private string effect;



        public CombatCard(string N, int aP, bool b, string t, string e)
        {
            name = N;
            attackPoints = aP;
            hero = b;
            type = t;
            effect = e;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int AttackPoints
        {
            get => attackPoints;
            set => attackPoints = value;
        }

        public bool Hero
        {
            get => hero;
            set => hero = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Effect
        {
            get => effect;
            set => effect = value;
        }

    }
}