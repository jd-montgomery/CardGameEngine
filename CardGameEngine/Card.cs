using System;
namespace CardGameEngine
{
    public class Card : ICard
    {
		private bool IsJoker { get; set; }
  
		private Card() 
		{
			IsJoker = true;    
		}
  
		public Card(Rank rank, Suit suit)
		{
			Rank = rank;
			Suit = suit;
			IsJoker = false;
		}
		
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }
        public static ICard GetJoker() => new Card();

		public override string ToString()
		{
            if (IsJoker)
                return "Joker";
            
            return 
                $"{Enum.GetName(typeof(Rank), Rank)} " +
                $"of {Enum.GetName(typeof(Suit), Suit)}";

		}
	}
}
