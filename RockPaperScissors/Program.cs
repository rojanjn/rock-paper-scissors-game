namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rock paper scissors game
            //the user plays against the machine

            string[] options = { "Rock", "Paper", "Scissors" };

            //introduction & instructions
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

            //reading user's name
            string player = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player}, What a legendary name!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==============================================");
            Console.WriteLine("            Now, LET'S PLAY!");
            Console.WriteLine("=============================================="); Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("Please choose one:");

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
                if (userInput == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine("Take Care now..");
                    Console.WriteLine("BYEEEEE");
                    Console.WriteLine();

                    break;
                }

                //user input to string
                string[] choices = { "Rock", "Paper", "Scissors" };
                string playerChoice = choices[userInput - 1];

                //computer's turn
                Random random = new Random();
                string compChoice = choices[random.Next(choices.Length)];

                Console.WriteLine("----------==========---------");
                Console.WriteLine();
                Console.WriteLine($"{player}, you chose {playerChoice}");
                Console.WriteLine($"Computer chose {compChoice}");
                Console.WriteLine();
                Console.WriteLine("----------==========---------");

                //determining losses
                if (playerChoice == "Rock" && compChoice == "Paper")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Better luck next time ;)");
                    Console.WriteLine();
                }

                if (playerChoice == "Scissors" && compChoice == "Rock")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Better luck next time ;)");
                    Console.WriteLine();
                }

                if (playerChoice == "Paper" && compChoice == "Scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU LOST!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Better luck next time ;)");
                    Console.WriteLine();
                }

                //determining wins
                if (playerChoice == "Rock" && compChoice == "Scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WON!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Congrats ;)");
                    Console.WriteLine();
                }

                if (playerChoice == "Paper" && compChoice == "Rock")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WON!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Congrats ;)");
                    Console.WriteLine();
                }

                if (playerChoice == "Scissors" && compChoice == "Paper")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YOU WON!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Congrats ;)");
                    Console.WriteLine();
                }

                //determining draw
                if (playerChoice == compChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("OMG that's a DRAW!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }
    }
}
