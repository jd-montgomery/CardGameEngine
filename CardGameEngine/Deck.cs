using System;
using System.Collections;
using System.Collections.Generic;

namespace CardGameEngine
{
    public class Deck : IReadOnlyList<ICard>
    {
        private IList<ICard> Stack { get; set; } = new List<ICard>();

        public int Count => Stack.Count;

        public ICard this[int index] => Stack[index];

        public Deck(bool withJokers = true)
        {
            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    Stack.Add(new Card((Rank)Enum.Parse(typeof(Rank), rank),
                                       (Suit)Enum.Parse(typeof(Suit), suit)));
                }
            }

            if (withJokers)
            {
                Stack.Add(Card.GetJoker());
                Stack.Add(Card.GetJoker());
            }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return Stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Stack.GetEnumerator();
        }
    }
}
