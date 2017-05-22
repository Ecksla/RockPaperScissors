using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Utils.Enum
{
    public class EnumAttributes
    {
        [AttributeUsage(AttributeTargets.Field)]
        public class Code : Attribute
        {
            private string value;
            
            public Code(string value)
            {
                this.CodeAttr = value;
            }
            
            public string CodeAttr
            {
                get { return this.value; }
                set { this.value = value; }
            }
        }

        [AttributeUsage(AttributeTargets.Field)]
        public class Description : Attribute
        {
            private string value;

            public Description(string value)
            {
                this.DescriptionAttr = value;
            }

            public string DescriptionAttr
            {
                get { return this.value; }
                set { this.value = value; }
            }
        }
    }
}
