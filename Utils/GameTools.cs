using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Utils.Enums;

namespace RockPaperScissors.Utils
{
    public static class GameTools
    {
        public static readonly ConsoleKey[] ValidItemKeys = { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3, ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3 };
        public static readonly ConsoleKey[] ValidDecisionKeys = { ConsoleKey.Y, ConsoleKey.N };
        public static bool CheckValidInput(ConsoleKeyInfo charKey, ConsoleKey[] keys)
        {
            if (keys.Contains(charKey.Key))
            {
                return true;
            }
            return false;
        }
        public static void DisplayInstruction()
        {
            DisplayInfo("Choose your element:", true);
            DisplayInfo($"Press [1] to pick {ItemsEnum.Rock}");
            DisplayInfo($"Press [2] to pick {ItemsEnum.Paper}");
            DisplayInfo($"Press [3] to pick {ItemsEnum.Scissors}", true);
        }
        public static void DisplayRoundResult(ResultEnum result)
        {
            switch (result)
            {
                case ResultEnum.HumanWin:
                    DisplayInfo("Player scored a point!");
                    break;
                case ResultEnum.ComputerWin:
                    DisplayInfo("Computer scored a point!");
                    break;
                case ResultEnum.Draw:
                    DisplayInfo("Draw! No one gets a point");
                    break;
            }
        }
        public static void DisplayInvalidInsert(char keyChar) => DisplayInfo($"Input {keyChar} is not valid");
        public static void DisplayInfo(string message, bool extraLine = false)
        {
            Console.WriteLine(message);

            if (extraLine) Console.WriteLine();
        }
    }
}
