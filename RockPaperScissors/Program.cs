namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rock paper scissors game
            //the user plays against the machine

            Random random = new Random();
            //string randomChoice = random("Rock", "Paper", "Scissors");

            int counter = 0;

            Console.WriteLine("");
            Console.WriteLine("WELCOME TO THE GAME!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("In this game, you will have to choose between Rock, Paper, or Scissors.");
            Console.WriteLine("And the machine will choose one randomly as well.");
            Console.WriteLine("Let's see who wins the most rounds :)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Before starting the game, please let me know your name:");
            string player = Console.ReadLine();

            Console.WriteLine("Pretty name!");
            Console.WriteLine("");
            Console.WriteLine("Now, LET'S PLAY!");
            Console.WriteLine("");

            

        }
    }
}
