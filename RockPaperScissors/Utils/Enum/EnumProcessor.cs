using RockPaperScissors.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Utils.Enum
{
    public static class EnumProcessor
    {
        public static string Code(System.Enum item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            FieldInfo fi = item.GetType().GetField(item.ToString());

            if (fi == null)
            {
                return item.ToString();
            }

            EnumAttributes.Code[] attributes = (EnumAttributes.Code[])fi.GetCustomAttributes(typeof(EnumAttributes.Code), false);

            if (attributes.Length > 0)
            {
                return attributes[0].CodeAttr;
            }

            return item.ToString();
        }

        public static string Description(System.Enum item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            FieldInfo fi = item.GetType().GetField(item.ToString());

            if (fi == null)
            {
                return item.ToString();
            }

            EnumAttributes.Description[] attributes = (EnumAttributes.Description[])fi.GetCustomAttributes(typeof(EnumAttributes.Description), false);

            if (attributes.Length > 0)
            {
                return attributes[0].DescriptionAttr;
            }

            return item.ToString();
        }

        public static System.Enum Enumerador<T>(string codigo) where T : struct, IConvertible
        {
            System.Enum result = null;

            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            foreach (System.Enum status in System.Enum.GetValues(typeof(T)))
            {
                if (Code(status).Equals(codigo.Trim(), StringComparison.InvariantCultureIgnoreCase))
                {
                    result = status;
                }
            }

            return result;           
        }
    }
}
