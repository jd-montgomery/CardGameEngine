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
    }
}
