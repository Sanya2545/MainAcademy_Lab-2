using System;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)
            bool boo = Convert.ToBoolean(1);
            char ch = (char)100;
            byte b = Convert.ToByte(250.7);
            sbyte sb = Convert.ToSByte(5);
            short sh = Convert.ToInt16(700);
            ushort ush = Convert.ToUInt16(25);
            int i = -223;
            uint ui = 300;
            long l = (long)100000.6;
            ulong ul = 8;
            decimal de = (decimal)-33.1;
            float f = 2.4f;
            double d0 = 564.876;
            Console.WriteLine("bool : {0}\nchar : {1}\nbyte : {2}\nsbyte : {3}\nshort : {4}\nushort : {5}\nint : {6}\nuint : {7}\n" +
                "long : {8}\nulong : {9}\ndecimal : {10}\nfloat : {11}\ndouble : {12}\n", boo, ch, b, sb, sh, ush, i, ui, l, ul, de, f, d0);

            //const int x = 5;
            //x = 10;
            //const double y = 5;
            //y = 10;
            var a = 20;
            var c = 20.5;
            Console.WriteLine("Type of a : " + a.GetType() + "\nType of c : " + c.GetType());
            a = (int)20.5;
            c = 20;
            Console.WriteLine("Type of a : " + a.GetType() + "\nType of c : " + c.GetType());
            System.Int32 z = i;
            System.Double y = d0;
            //2) declare constants of int and double. Try to change their values.


            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?


            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                

                // 6) change values of variables from 1)


            }

            // 7)check values of variables from 1). Are they changed? Think, why


            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char
            ch = (char)i;

            // bool -> short
            sh = b;
            // double -> long
            l = (long)d0;
            // float -> char 
            ch = (char)f;
            // int to char
            ch = (char)i;
            // decimal -> double
            d0 = (double)de;
            // byte -> uint
            ui = b;
            // ulong -> sbyte
            sb = (sbyte)ul;
            // 9) and reverse conversion with fixing compilation errors.
            i = (int)ch;
            //b = Convert.ToBoolean(sh); - impossible
            d0 = l;
            f = ch;
            i = ch;
            de = (decimal)d0;
            b = (byte)ui;
            ul = (ulong)sb;

            // 10) declare int nullable value. Initialize it with 'null'. 
            int? p = null;
            // Try to initialize variable i with 'null'. Is it possible?
            //i = null; - it's impossible
        }
    }
}
