using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chose between rock, paper or scissors by typing it here: ");
            List<string> possibleMoves= new List<string>() { "rock","paper","scissors"};
            string playerMove = Console.ReadLine().ToLower();
            

            if (!possibleMoves.Contains(playerMove))
            {
                Console.WriteLine("Try again with a correct input!");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = possibleMoves[computerRandomNumber];


            Console.WriteLine($"The computer chose {computerMove}.");

            if ((playerMove == "rock" && computerMove == "scissors") || (playerMove == "paper" && computerMove == "rock")
                || (playerMove == "scissors" && computerMove ==  "paper"))
            {
                Console.WriteLine("You won!");
            }
            else if (playerMove==computerMove)
            {
                Console.WriteLine("Draw!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }

        }
    }
}
