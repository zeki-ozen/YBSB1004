/** Structured Programming W6 */
/** Pre-Post Increment and Decrement Operators */
/** Numeric Data Types */


namespace PrePostIncDec
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10;

            x = x + 1; // this line increments x by 1
            // x++;
            // x += 1; // this line increments x by 1

            // Q: How can we increment x not by 1 but by 2?
            x = x + 2; // this line increments x by 2
            x += 2; // this line increments x by 2

            // Q: How can we increment x not by 2 but by 7?
            x = x + 7; // this line increments x by 7
            x += 7; // this line increments x by 7


            x = x - 1; // this line decrements x by 1
            // x--;
            // x -= 1; // this line decrements x by 1


            // Q: How can we decrement x not by 1 but by 2?
            x = x - 2; // this line decrements x by 2
            x -= 2; // this line decrements x by 2





            /***** Data Types *****/

            // A. Numeric Data Types
            // A. 1. Integral Data Types

            // byte
            // byte requires 1 byte of memory
            // byte is an unsigned data type
            // byte is used to store positive values
            byte b = 255; // 0 to 255
            byte b1 = 256; // Error: Outside the range
            byte b2 = -1; // Error: Outside the range

            // s : signed
            // sbyte : signed byte
            // sbyte requires 1 byte of memory
            // sbyte is a signed data type
            // sbyte is used to store positive and negative values
            sbyte sb = 127; // -128 to 127
            sbyte sb1 = 128; // Error: Outside the range
            sbyte sb2 = -129; // Error: Outside the range


            // short data type
            // short requires 2 bytes of memory
            // short is a signed data type
            // short is used to store positive and negative values
            short sh = 32767; // -32768 to 32767
            short sh1 = 32768; // Error: Outside the range
            short sh2 = -32769; // Error: Outside the range


            // u: unsigned
            // ushort : unsigned short
            // ushort requires 2 bytes of memory
            ushort ush = 65535; // 0 to 65535
            ushort ush1 = 65536; // Error: Outside the range
            ushort ush2 = -1; // Error: Outside the range




            // int data type
            // int requires 4 bytes of memory
            // int is a signed data type
            // int is used to store positive and negative values
            int i = 2147483647; // -2147483648 to 2147483647
            int i1 = 2147483648; // Error: Outside the range
            int i2 = -2147483649; // Error: Outside the range



            // uint : unsigned int
            // uint requires 4 bytes of memory
            // uint is an unsigned data type
            // uint is used to store positive values
            uint ui = 4294967295; // 0 to 4294967295
            uint ui1 = 4294967296; // Error: Outside the range
            uint ui2 = -1; // Error: Outside the range



            // long data type
            // long requires 8 bytes of memory
            // long is a signed data type
            // long is used to store positive and negative values
            long l = 9223372036854775807; // -9223372036854775808 to 9223372036854775807
            long l1 = 9223372036854775808; // Error: Outside the range
            long l2 = -9223372036854775809; // Error: Outside the range



            // ulong : unsigned long
            // ulong requires 8 bytes of memory
            // ulong is an unsigned data type
            // ulong is used to store positive values
            ulong ul = 18446744073709551615; // 0 to 18446744073709551615
            ulong ul1 = 18446744073709551616; // Error: Outside the range
            ulong ul2 = -1; // Error: Outside the range



            // ask number from user
            int number = Convert.ToInt32(Console.ReadLine());


            // exercise of integral data types

            short sh3 = 45;
            short sh4 = 12;
            byte b3 = sh3 + sh4; // Error: Cannot implicitly convert type 'int' to 'byte'
            int i3 = sh3 + sh4; // 57
            long l3 = sh3 + sh4; // 57

            byte b4 = 45;
            short sh5 = 12;
            int i4 = b4 + sh5; // 57



        }
    }
}
