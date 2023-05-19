using RockPaperScissors.Utils;
using System;
using System.Linq;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameTools.DisplayInfo("Welcome in game Rock paper and scissors!", true);

            Game game = new();

            game.StartGame();
        }

    }
}
