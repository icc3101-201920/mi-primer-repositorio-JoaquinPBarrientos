using System;
using System.Collections.Generic;

namespace Card
{
    public class Deck
    {
        private CombatCard combatCards;
        private SpecialCard specialCards;
    }

    public Deck()
    {
        combatCards = new List<CombatCard>();
        specialCards = new List<SpecialCard>();
    }

    public List<CombatCard> CombatCards
    {
        get => List < CombatCard > combatCards;
        set => List < CombatCard > combatCards = value;
    }

    public List<SpecialCard> SpecialCards
    {
        get => List < SpecialCard > specialCards;
        set => List < SpecialCard > specialCards = value;
    }

    public void AddCombatCard(CombatCard combatCard)
    {
        Console.WriteLine("Adding wtf");
    }

    public void AddSpecialCard(SpecialCard specialCard)
    {
        Console.WriteLine("Adding wtf");

    }

    public void DestroyCombatCard(int cardId)
    {
        Console.WriteLine("Destroying wtf");
    }

    public void DestroySpecialCard(int cardId)
    {
        Console.WriteLine("Destroying wtf");
    }

    public void Shuffle()
    {
        Console.WriteLine("SHUFFLE!");
    }
}