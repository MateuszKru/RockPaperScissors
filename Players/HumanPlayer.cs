using RockPaperScissors.Utils;
using RockPaperScissors.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Players
{
    public class HumanPlayer : Player
    {
        public override void ChooseItem()
        {
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            while (!GameTools.CheckValidInput(userInput, GameTools.ValidItemKeys))
            {
                GameTools.DisplayInvalidInsert(userInput.KeyChar);
                userInput = Console.ReadKey(true);
            }

            if (userInput.Modifiers == 0 && Enum.IsDefined(typeof(ItemsEnum), Byte.Parse(userInput.KeyChar.ToString())) && Enum.TryParse(userInput.KeyChar.ToString(), out ItemsEnum userChoice))
            {
                SetItem(userChoice);
            }
        }

    }
}
