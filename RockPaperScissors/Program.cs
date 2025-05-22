namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rock paper scissors game
            //the user plays against the machine

            string[] options = { "Rock", "Paper", "Scissors" };
            Random random = new Random();

            //introduction & instructions
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================================");
            Console.WriteLine("            WELCOME TO THE GAME!");
            Console.WriteLine("=============================================="); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.WriteLine("In this game, you will face off against the computer.");
            Console.WriteLine("Choose between Rock, Paper, or Scissors each round.");
            Console.WriteLine("----------------------------------------------");

            //player name
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Before we begin... what's your name warrior?   ");
            Console.ForegroundColor = ConsoleColor.White;

            //reading user's name
            string player = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player}, What a legendary name!");
            Console.WriteLine();

            //game start
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================================");
            Console.WriteLine("            Now... LET'S PLAY!");
            Console.WriteLine("=============================================="); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();

            //game engine:
            while (true)
            {
                Console.WriteLine($"{player}, It's your turn!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1 --> Rock");
                Console.WriteLine("2 --> Paper");
                Console.WriteLine("3 --> Scissors");
                Console.WriteLine("4 --> Exit the game");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Your choice: ");

                string input = Console.ReadLine();
                int userInput;

                //validation
                if (!int.TryParse(input, out userInput) || userInput < 1 || userInput > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("INVALID INPUT! Please enter 1, 2, 3, or 4.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue; //restarting the loop
                }

                //exit option
                if (userInput == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Thanks for playing, {player}!");
                    Console.WriteLine("Take Care, and may the odds be ever in your favor. :)");
                    Console.WriteLine("BYE");
                    Console.WriteLine();

                    break;
                }

                //user input to string
                string[] choices = { "Rock", "Paper", "Scissors" };
                string playerChoice = choices[userInput - 1];

                //computer's turn
                string compChoice = choices[random.Next(choices.Length)];

                Console.WriteLine("----------==========---------");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine();
                Console.WriteLine($"{player} chose: {playerChoice}");
                Console.WriteLine($"Computer chose: {compChoice}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("----------==========---------");
                Console.WriteLine();

                //game logic
                if (playerChoice == compChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a DRAW!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You two think alike ;)");
                    Console.WriteLine();
                }
                else if (
                    (playerChoice == "Rock" && compChoice == "Scissors") ||
                    (playerChoice == "Paper" && compChoice == "Rock") ||
                    (playerChoice == "Scissors" && compChoice == "Paper")
                    )
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WON!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("A glorious victory! Congrats ;)");
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Better luck next time ;)");
                    Console.WriteLine();
                }
            }
        }
    }
}
