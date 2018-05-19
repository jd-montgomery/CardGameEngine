using System;
using CardGameEngine;
using Xunit;

namespace CardGameEngineTests
{
    public class DeckTests
    {
        [Fact]
        public void DeckShouldContain54CardsTest()
        {
            var d = new Deck();
            Assert.Equal(54, d.Count);
        }

        [Fact]
        public void DeckWithNoJokersContains52CardsTest()
        {
            var d = new Deck(false);
            Assert.Equal(52, d.Count);
        }

        [Fact]
        public void ShuffleTest()
        {
            var d = new Deck();
            var firstCard = d[0];
            var secondCard = d[1];
            var thirdCard = d[2];

            d.Shuffle();

            // Compare first three cards with deck before shuffle.
            Assert.NotEqual(firstCard.ToString() + secondCard.ToString() +
                           thirdCard.ToString(), d[0].ToString() +
                           d[1].ToString() + d[2].ToString());
        }
    }
}
