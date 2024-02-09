namespace Blackjack;

public class Diamond(int value) : ICard
{
    public int Value => value;
    public string Name => "Ace";
}