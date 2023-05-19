using RockPaperScissors.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Players
{
    public abstract class Player
    {
        protected Player() { }
        public byte Points { get; private set; } = 0;
        public ItemsEnum Item { get; private set; } = 0;

        protected void SetItem(ItemsEnum item) => Item = item;
        public void AddPoint() => Points++;
        public void RemovePoints() => Points = 0;
        public abstract void ChooseItem();
    }
}
