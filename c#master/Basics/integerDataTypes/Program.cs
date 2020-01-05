using System.Xml.Xsl.Runtime;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Net.Http;
using System;

namespace integerDataTypes
{
    class Program
    {
        static void Main()
        {
            int someInt = 8;
            // 2^32 is max number size of an int
                int intMax = int.MaxValue;
                int intMin = int.MinValue;

            System.Console.WriteLine(intMax);
            System.Console.WriteLine(intMin);

            uint someUInt = 8;
            // uint values can only be positive, "unassigned"
                uint uintMin = uint.MinValue;
                uint uintMax = uint.MaxValue;  

            System.Console.WriteLine(uintMin);
            System.Console.WriteLine(uintMax);

            System.Console.WriteLine(Math.Pow(2,32));

            byte someByteNumber = 254;
            // can only have positive numbers up to 255
                byte byteMin = byte.MinValue;
                byte byteMax = byte.MaxValue;

            System.Console.WriteLine(byteMin);
            System.Console.WriteLine(byteMax);

                sbyte minsByte = sbyte.MinValue;
                sbyte maxsByte = sbyte.MaxValue;
            //short byte can have negative or positive numbers within range of 255 

            System.Console.WriteLine(minsByte);
            System.Console.WriteLine(maxsByte);

            long maxLong = long.MinValue;
            long minLong = long.MaxValue;
            // long number storage 2^64 size aka 2x the size of int
            System.Console.WriteLine(maxLong);
            System.Console.WriteLine(minLong);

            ulong maxuLong = ulong.MinValue;
            ulong minuLong = ulong.MaxValue;
            // long number storage 2^64 size aka 2x the size of int "unassigned"
            System.Console.WriteLine(maxuLong);
            System.Console.WriteLine(minuLong);

            string freespace = " ";

            //Floating point and decimals below this =================================//
            float someFloatNumber = 3.1415f;
            float floatMax = float.MaxValue;
            float floatMin = float.MinValue
            System.Console.WriteLine(floatMax.toString("f"));
            System.Console.WriteLine(floatMin.toString("f"));
            // only has a precision of 7 digits, the toString("f") indicates console should display full number

            double someDouble = 55.3422432
            double dblMax = double.MaxValue;
            double dblMin = double.MinValue;

            decimal someDecimal = .2342
            //precision of double is greater than float numbers, and decimal greater than double

            // int radius = 4;
            // System.Console.WriteLine((Math.Pow(radius,2)) * someFloatNumber );
        
        }
    }
}
