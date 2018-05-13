namespace CardGameEngine
{
    public interface ICard
    {
        Rank Rank { get; }
        Suit Suit { get; }
    }
}