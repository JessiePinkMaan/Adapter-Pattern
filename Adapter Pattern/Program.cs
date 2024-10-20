namespace Adapter_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ComputerGame game = new ComputerGame("Epic Adventure", 16, 60);
            PCGame adaptedGame = new ComputerGameAdapter(game);

            System.Console.WriteLine($"Title: {adaptedGame.GetTitle()}");
            System.Console.WriteLine($"PEGI Rating: {adaptedGame.GetPegiAgeRating()}");
            System.Console.WriteLine($"Is Triple A: {adaptedGame.IsTripleA()}");
        }
        }
    }
