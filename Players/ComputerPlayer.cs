using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Utils.Enums;

namespace RockPaperScissors.Players
{
    public class ComputerPlayer : Player
    {
        public override void ChooseItem()
        {
            Random rand = new();

            int randomItem = rand.Next(Enum.GetValues(typeof(ItemsEnum)).Cast<byte>().Min() + 1, Enum.GetValues(typeof(ItemsEnum)).Cast<byte>().Max() + 1);

            ItemsEnum randomComputerItem = (ItemsEnum)randomItem;

            SetItem(randomComputerItem);
        }
    }
}
