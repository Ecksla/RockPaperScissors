using RockPaperScissors.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Enum
{
    public enum StrategiesEnum
    {
        [EnumAttributes.Code("R")]
        [EnumAttributes.Description("Rock")]
        Rock = 0,

        [EnumAttributes.Code("P")]
        [EnumAttributes.Description("Paper")]
        Paper = 1,

        [EnumAttributes.Code("S")]
        [EnumAttributes.Description("Scissors")]
        Scissors = 2,
    }
}
