namespace Blackjack;

public class Deck
{
    List<ICard> Cards = [];

    public Deck()
    {
    }

    public void Add(ICard card)
    {
        Cards.Add(card);
    }

    public void Remove(ICard card)
    {
        Cards.Remove(card);
    }

    public void Shuffle()
    {
        Random rnd = new();
        for (int i = 0; i < Cards.Count; i++)
        {
            int j = rnd.Next(0, Cards.Count);

            if (i == j) continue;

            (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
        }
    }

    public void PrintDeck()
    {
        for (int i = 0; i < Cards.Count; i++)
        {
            Console.WriteLine($"Card: {Cards[i].Value}");
        }
    }
}