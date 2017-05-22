using RockPaperScissors.Enum;
using RockPaperScissors.Exceptions;
using RockPaperScissors.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class Move
    {
        public string PlayerName { get; set; }
        public StrategiesEnum Strategy { get; set; }

        public Move()
        {
        }

        public Move(string[] arrayMove)
        {
            this.PlayerName = arrayMove[0];

            System.Enum convertedStrategy = EnumProcessor.Enumerador<StrategiesEnum>(arrayMove[1]);

            if(convertedStrategy == null)
            {
                throw new NoSuchStrategyException("Estratégia inválida!");
            }

            this.Strategy = (StrategiesEnum)convertedStrategy;
        }

        public override string ToString()
        {
            return string.Format("[\"{0}\",\"{1}\"]", this.PlayerName, EnumProcessor.Description(this.Strategy));
        }
    }
}
