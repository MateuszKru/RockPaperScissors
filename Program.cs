using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            Elements element = new Elements();
            Game game = new Game();
            int playerPoints = 0;
            int computerPoints = 0;

            Console.WriteLine("Welcome in game Rock paper and scissors!");
            Console.WriteLine();
            

            while (true)
            {
                while (computerPoints < 3 && playerPoints < 3)
                {
                    game.displayInstruction();


                    string userChooseElement = game.insertUserElement();
                    string computerChooseElement = game.computerElement();


                    if (userChooseElement == element.elements[0] & computerChooseElement == element.elements[2] ||
                        userChooseElement == element.elements[1] & computerChooseElement == element.elements[0] ||
                        userChooseElement == element.elements[2] & computerChooseElement == element.elements[1])
                    {
                        playerPoints += 1;
                        Console.WriteLine($"{userChooseElement} beats {computerChooseElement}");
                        Console.WriteLine("User scored a point");
                    }
                    else if (userChooseElement == element.elements[0] & computerChooseElement == element.elements[1] ||
                             userChooseElement == element.elements[1] & computerChooseElement == element.elements[2] ||
                             userChooseElement == element.elements[2] & computerChooseElement == element.elements[0])
                    {
                        computerPoints += 1;
                        Console.WriteLine($"{computerChooseElement} beats {userChooseElement}");
                        Console.WriteLine("Computer scored a point");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                        Console.WriteLine("No one gets a point");
                    }
                    Console.WriteLine($"Player: {playerPoints} vs Computer: {computerPoints}");
                    Console.WriteLine();
                    if (computerPoints == 3)
                    {
                        Console.WriteLine("Computer wins!");
                        break;

                    }
                    else if(playerPoints == 3)
                    {
                        Console.WriteLine("Player wins!");
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }
               
                Console.WriteLine();
                Console.WriteLine("Try again?");
                Console.WriteLine("Insert y or n");

                string userInputDecision = Console.ReadLine();
                string userDecision = userInputDecision;

                if (userDecision == "y")
                {
                    playerPoints = 0;
                    computerPoints = 0;
                    continue;
                }
                else if (userDecision == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong insert");
                    continue;

                }
               
            }







        }




    }
}
