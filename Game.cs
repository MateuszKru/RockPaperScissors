using RockPaperScissors.Players;
using RockPaperScissors.Utils;
using RockPaperScissors.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        private readonly Player _humanPlayer;
        private readonly Player _computerPlayer;
        private readonly GameRound _gameRound;
        private ResultEnum _resultEnum;

        public Game()
        {
            _humanPlayer = new HumanPlayer();
            _computerPlayer = new ComputerPlayer();
            _gameRound = new GameRound(_humanPlayer, _computerPlayer);
        }

        public void StartGame()
        {

            do
            {
                if (_gameRound.RoundNumber > 1)
                {
                    GameTools.DisplayInfo("*********************************************************");
                    GameTools.DisplayInfo("Next round!", true);
                }
                GameTools.DisplayInfo($"Round: {_gameRound.RoundNumber}");
                GameTools.DisplayInstruction();

                _humanPlayer.ChooseItem();
                GameTools.DisplayInfo($"Player choice: {_humanPlayer.Item}", false);

                _computerPlayer.ChooseItem();
                GameTools.DisplayInfo($"Computer choice: {_computerPlayer.Item}", true);
                _resultEnum = _gameRound.CompareChoices();
                GameTools.DisplayRoundResult(_resultEnum);
                GameTools.DisplayInfo($"Player: {_humanPlayer.Points} vs Computer: {_computerPlayer.Points}", true);
            }
            while (_humanPlayer.Points < 3 && _computerPlayer.Points < 3);

            EndGame(_resultEnum);
        }

        private void EndGame(ResultEnum result)
        {
            GameTools.DisplayInfo($"{Regex.Replace(result.ToString(), "(\\B[A-Z])", " $1")}!", true);
            ConsoleKeyInfo playerDecision = new();
            while (!GameTools.CheckValidInput(playerDecision, GameTools.ValidDecisionKeys))
            {
                GameTools.DisplayInfo("Try again? Insert [y] or [n]", true);
                playerDecision = Console.ReadKey(true);

                switch (playerDecision.Key)
                {
                    case ConsoleKey.Y:
                        StartNewRound();
                        break;
                    case ConsoleKey.N:
                        GameTools.DisplayInfo("Bye!");
                        break;
                    default:
                        GameTools.DisplayInvalidInsert(playerDecision.KeyChar);
                        continue;
                }
            }
        }
        private void StartNewRound()
        {
            GameTools.DisplayInfo("OK, let's play again!", true);
            _humanPlayer.RemovePoints();
            _computerPlayer.RemovePoints();
            StartGame();
        }
    }
}
