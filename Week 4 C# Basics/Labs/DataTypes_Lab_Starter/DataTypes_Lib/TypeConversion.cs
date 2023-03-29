using System;
using System.Formats.Asn1;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if ((short)num != num)
            {
                throw new OverflowException("Invalid Type " + num);
            }
            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            long lnum = (long)num;
            return lnum;
        }
    }
}
