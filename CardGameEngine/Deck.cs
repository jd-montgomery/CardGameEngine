using System;
using System.Collections.Generic;

namespace CardGameEngine
{
    /// <summary>
    /// A traditional deck of playing cards with or without Jokers.
    /// </summary>
    public class Deck : IGameDeck
    {
        private static Random shuffleRandom = new Random();
        private IList<ICard> _deck { get; } = new List<ICard>();

        public Deck(bool withJokers = true)
        {
            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    _deck.Add(new Card((Rank)Enum.Parse(typeof(Rank), rank),
                                       (Suit)Enum.Parse(typeof(Suit), suit)));
                }
            }

            if (withJokers)
            {
                _deck.Add(Card.GetJoker());
                _deck.Add(Card.GetJoker());
            }
        }

        /// <summary>
        /// Shuffle this <see cref="Deck"/>.
        /// </summary>
        public void Shuffle()
        {
            int n = Count;
            while (n > 1)
            {
                n--;
                int k = shuffleRandom.Next(n + 1);
                ICard value = this[k];
                this[k] = this[n];
                this[n] = value;
            }
        }

        /// <summary>
        /// Get or set the <see cref="ICard" /> at <paramref name="index"/>. 
        /// </summary>
        public ICard this[int index]
        {
            get => _deck[index];
            set => _deck[index] = value;
        }

        /// <summary>
        /// Gets the count of cards currently in the deck.
        /// This number is decreased by the game calling 
        /// <see cref="IGameDeck.Remove"/>.
        /// </summary>
        /// <value>The value will range from 0 to 54.</value>
        public short Count => (short)_deck.Count;

        /// <summary>
        /// Remove the <paramref name="card"/>.
        /// </summary>
        /// <returns>true if item is successfully removed; otherwise, false. 
        /// This method also returns false if item was not found in the
        /// <see cref="Deck"/>.</returns>
        /// <param name="card">The card to remove.</param>
        public bool Remove(ICard card) => _deck.Remove(card);
    }
}
