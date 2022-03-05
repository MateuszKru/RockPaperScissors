using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        Elements element = new Elements();

      

       
        public void displayInstruction()
        {
            Console.WriteLine("Choose your element:");
            Console.WriteLine($"1 Rock");
            Console.WriteLine($"2 Paper");
            Console.WriteLine($"3 Scissors");
            Console.WriteLine();
        }
        public string computerElement()
        {
            

            Random rand = new Random();
            int randomElement = rand.Next(element.elements.Length);
            string randomComputerElement = element.elements[randomElement].ToString();
            Console.WriteLine($"Computer choose: {randomComputerElement}");
            Console.WriteLine();
            return randomComputerElement;
            
        }
        public string insertUserElement()
        {
            
            
            while (true)
            {
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    string userElement = element.elements[0];
                    Console.WriteLine($"User choose: {userElement}");
                    return userElement;
                }
                else if (userInput == "2")
                {
                    string userElement = element.elements[1];
                    Console.WriteLine($"User choose: {userElement}");
                    return userElement;

                }
                else if (userInput == "3")
                {
                    string userElement = element.elements[2];
                    Console.WriteLine($"User choose: {userElement}");
                    return userElement;

                }
                else
                {
                    Console.WriteLine("Invalid insert");
                    Console.WriteLine();
                    displayInstruction();
                }
                Console.WriteLine();
            }
        }
    }
}
