using System;
namespace Card
{
    public class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public Player(int lp,int ap, Deck d,Hand h, Board b,SpecialCard sp)
        {
            lifePoints = lp;
            attackPoints = ap;
            deck = d;
            hand = h;
            board = b;
            captain = sp;
        }

        public int LifePoints
        {
            get => lifePoints;
            set => lifePoints = value;
        }

        public int AttackPoints
        {
            get => attackPoints;
            set => attackPoints = value;
        }

        public Deck Deck
        {
            get => deck;
            set => deck = value;
        }

        public Hand Hand
        {
            get => hand;
            set => hand = value;
        }

        public Board Board
        {
            get => board;
            set => board = value;
        }

        public SpecialCard Captain
        {
            get => captain;
            set => captain = value;
        }

        public void DrawCard()
        {
            Console.WriteLine("Sacando carta");
        }

        public void PlayCard(int cardId)
        {
            Console.WriteLine("Jugó carta");
        }

        public void ChangeCard(int cardId)
        {
            Console.WriteLine("Cambiando carta");
        }

        public void FirstHand()
        {
            Console.WriteLine("Primera mano");
        }

        public void ChooseCaptainCard(SpecialCard captainCard)
        {
            Console.WriteLine("Ni idea que está pasando");
        }

    }
}
