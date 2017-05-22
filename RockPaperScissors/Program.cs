using Newtonsoft.Json;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Model;
using RockPaperScissors.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string partA = @"[[""Amando"", ""P""],[""Dave"", ""S""]]";

                string partB = @"[
                                [
                                [[""Amando"", ""P""],[""Dave"", ""S""]],
                                [[""Richard"",""R""],[""Michael"",""S""]]
                                ],
                                [
                                [[""Allen"",""S""],[""Omer"",""P""]],
                                [[""David E."", ""R""],[""Richard X."",""P""]]
                                ]
                            ]";

                Move rpsGameWinner = GameRunner.RpsGameWinner(partA);
                Console.WriteLine(string.Format("Game winner: {0}", rpsGameWinner));
                Console.WriteLine();
                Move rpsTournamentWinner = GameRunner.RpsTournamentWinner(partB);
                Console.WriteLine(string.Format("Tournament winner: {0}", rpsTournamentWinner));               
            }
            catch (NoSuchStrategyException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch(WrongNumberOfPlayersException wnpe)
            {
                Console.WriteLine(wnpe.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
