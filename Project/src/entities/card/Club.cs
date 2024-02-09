namespace Blackjack;

public class Club(int value) : ICard
{
    public int Value => value;
    public string Name => "Ace";
}