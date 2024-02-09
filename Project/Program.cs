namespace Blackjack;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");
        Console.ReadKey();
        // 52 cards in a deck
        // 4 suits
        // 3 face cards
        // Ace

        // Trying to get 21
        // bust 21 you lose
        // Turn based
        // Closest to 21 without going over wins

        // Deck deck = new();

        // Random rnd = new();

        // for (int i = 0; i < 52; i++)
        // {
        //     int suit = rnd.Next(0, 4);
        //     int value = rnd.Next(1, 14);
        //     switch (suit)
        //     {
        //         case 0:
        //             deck.Add(new Heart(value));
        //             break;
        //         case 1:
        //             deck.Add(new Diamond(value));
        //             break;
        //         case 2:
        //             deck.Add(new Club(value));
        //             break;
        //         case 3:
        //             deck.Add(new Spade(value));
        //             break;
        //     }
        // }

        // deck.PrintDeck();

        // do
        // {
        //     Console.Write("Shuffle? (y/n): ");
        //     string? userChoice = Console.ReadLine();

        //     if (string.IsNullOrEmpty(userChoice))
        //     {
        //         Console.WriteLine("You need to enter a value...");
        //         continue;
        //     }

        //     userChoice = userChoice.ToLower();

        //     if (userChoice == "y")
        //     {
        //         Console.WriteLine("Shuffling...");
        //         deck.Shuffle();
        //         deck.PrintDeck();
        //     }
        //     else if (userChoice == "n")
        //     {
        //         Console.WriteLine("Goodbye!");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid input.");
        //     }

        // } while (true);
    }
}
