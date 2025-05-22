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

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================================");
            Console.WriteLine("            WELCOME TO THE GAME!");
            Console.WriteLine("=============================================="); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("In this game, you will have to choose between Rock, Paper, or Scissors.");
            Console.WriteLine("The computer will also pick one at random.");
            Console.WriteLine("Let's see who wins the most rounds! 😈");
            Console.WriteLine("----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Before we begin, what's your name warrior?");
            Console.ForegroundColor = ConsoleColor.White;
            string player = Console.ReadLine(); //reading user's name

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player}, What a legendary name!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================================");
            Console.WriteLine("            Now, LET'S PLAY!");
            Console.WriteLine("=============================================="); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            

        }
    }
}
