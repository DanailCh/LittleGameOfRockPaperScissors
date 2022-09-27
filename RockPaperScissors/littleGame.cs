using System;

namespace rockPaperScissors
{
    class littleGame
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";
            Console.Write("Choose your weapon Rock(r),Paper(p) or Scissors(s): ");

            string playerMove = Console.ReadLine();
            if (playerMove=="r"||playerMove=="Rock"||playerMove=="rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "Paper" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "Scissors" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again...");
                return;
            }

            Random rnd = new Random();
            int computerRandomNumber = rnd.Next(1, 4);
            string computerMove = "";
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
                
            }
            Console.WriteLine($"Computer chose {computerMove}");
            if ((playerMove == rock & computerMove == scissors) || (playerMove == paper & computerMove == rock) || (playerMove == scissors & computerMove == paper)) 
            {
                Console.WriteLine("Congratulations! You Win.");
            }
            else if ((playerMove == scissors & computerMove == rock) || (playerMove == rock & computerMove == paper) || (playerMove == paper & computerMove == scissors))
            {
                Console.WriteLine("Sorry. You lose.");
            }
            else
            {
                Console.WriteLine("It's a draw.");
            }
            //Console.WriteLine("if you want to continue playing type (yes) if you want to close the program type(no): ");

            //string playerSecondInput = Console.ReadLine();
            //if (playerSecondInput=="yes")
            //{
            //    return;
            //}
        }
    }
}
