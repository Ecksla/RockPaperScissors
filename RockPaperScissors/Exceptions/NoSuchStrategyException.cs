using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Exceptions
{
    public class NoSuchStrategyException : Exception
    {
        public NoSuchStrategyException()
        {
        }

        public NoSuchStrategyException(string message)
        : base(message)
        {
        }

        public NoSuchStrategyException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
