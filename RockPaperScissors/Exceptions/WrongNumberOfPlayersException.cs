using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Exceptions
{
    public class WrongNumberOfPlayersException : Exception
    {
        public WrongNumberOfPlayersException()
        {
        }

        public WrongNumberOfPlayersException(string message)
        : base(message)
        {
        }

        public WrongNumberOfPlayersException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
