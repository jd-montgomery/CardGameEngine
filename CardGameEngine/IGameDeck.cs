namespace CardGameEngine
{
    public interface IGameDeck
    {
        /// <summary>
        /// Gets the count of cards currently in the deck.
        /// This number is decreased by the game calling 
        /// <see cref="IGameDeck.Remove"/>.
        /// </summary>
        /// <value>The value will range from 0 to 54.</value>
        short Count { get; }

        /// <summary>
        /// Remove the <paramref name="card"/>.
        /// </summary>
        /// <returns>true if item is successfully removed; otherwise, false. 
        /// This method also returns false if item was not found in the
        /// <see cref="Deck"/>.</returns>
        /// <param name="card">The card to remove.</param>
        bool Remove(ICard card);

        /// <summary>
        /// Shuffle this <see cref="Deck"/>.
        /// </summary>
        void Shuffle();
    }
}