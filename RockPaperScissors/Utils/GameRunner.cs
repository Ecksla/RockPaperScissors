using Newtonsoft.Json;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Utils
{
    public static class GameRunner
    {
        public static Move RpsGameWinner(string game)
        {
            var deserializedCommand = JsonConvert.DeserializeObject<string[][]>(game);

            if (deserializedCommand[0].Length < 2)
            {
                throw new WrongNumberOfPlayersException("Número de jogadores incorreto");
            }

            var playerOneMove = new Move(deserializedCommand[0]);
            var playerTwoMove = new Move(deserializedCommand[1]);

            return ReturnWinnerMove(playerOneMove, playerTwoMove);
        }

        public static Move ReturnWinnerMove(Move playerOneMove, Move playerTwoMove)
        {
            Move winner;

            if (playerOneMove.Strategy == playerTwoMove.Strategy)
            {
                winner = playerOneMove;
            }
            else if (MathUtils.Mod(playerOneMove.Strategy - playerTwoMove.Strategy, 3) == 1)
            {
                winner = playerOneMove;
            }
            else
            {
                winner = playerTwoMove;
            }

            return winner;
        }

        public static Move RpsTournamentWinner(string tournament)
        {
            var deserializedCommand = JsonConvert.DeserializeObject<object[]>(tournament);

            Move result = null;

            if (deserializedCommand[0] is string && deserializedCommand[1] is string)
            {
                result = new Move(deserializedCommand.Cast<string>().ToArray());
            }
            else
            {
                Move move1 = RpsTournamentWinner(deserializedCommand[0].ToString());
                Move move2 = RpsTournamentWinner(deserializedCommand[1].ToString());
                result = ReturnWinnerMove(move1, move2);
            }

            return result;            
        }
    }
}
