using RockPaperScissors.Players;
using RockPaperScissors.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Utils
{
    public class GameRound
    {
        public byte RoundNumber { get; private set; } = 1;

        private ResultEnum _roundResult;
        private readonly Player _humanPlayer;
        private readonly Player _computerPlayer;
        public GameRound(Player humanPlayer, Player computerPlayer)
        {
            _humanPlayer = humanPlayer;
            _computerPlayer = computerPlayer;
        }

        public ResultEnum CompareChoices()
        {
            if (_humanPlayer.Item == ItemsEnum.Rock && _computerPlayer.Item == ItemsEnum.Scissors ||
                _humanPlayer.Item == ItemsEnum.Paper && _computerPlayer.Item == ItemsEnum.Rock ||
                _humanPlayer.Item == ItemsEnum.Scissors && _computerPlayer.Item == ItemsEnum.Paper)
            {
                _humanPlayer.AddPoint();
                _roundResult = ResultEnum.HumanWin;
            }
            else if (_humanPlayer.Item == ItemsEnum.Rock & _computerPlayer.Item == ItemsEnum.Paper ||
                     _humanPlayer.Item == ItemsEnum.Scissors && _computerPlayer.Item == ItemsEnum.Rock ||
                     _humanPlayer.Item == ItemsEnum.Paper && _computerPlayer.Item == ItemsEnum.Scissors)
            {
                _computerPlayer.AddPoint();
                _roundResult = ResultEnum.ComputerWin;
            }
            else
            {
                _roundResult = ResultEnum.Draw;
            }

            SetRoundNumber(RoundNumber += 1);

            if (_computerPlayer.Points == 3 || _humanPlayer.Points == 3)
                SetRoundNumber(1);

            return _roundResult;
        }
        private void SetRoundNumber(byte number) => RoundNumber = number;
    }
}
