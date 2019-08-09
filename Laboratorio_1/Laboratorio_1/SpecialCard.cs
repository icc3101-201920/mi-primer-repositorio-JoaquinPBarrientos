using System;
namespace Card
{
    public class SpecialCard
    {
        string name;
        string type;
        string buffType;
        string effect;

        public SpecialCard()
        {
        }

        public SpecialCard(string n, string t, string b, string e)
        {
            name = n;
            type = t;
            buffType = b;
            effect = e;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string BuffType
        {
            get => buffType;
            set => buffType = value;
        }

        public string Effect
        {
            get => effect;
            set => effect = value;
        }
    }
}
