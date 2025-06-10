using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace VariableData
{
    public class Example1
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello World! From SayHello method of the Example 1 class");
        }
    }

    public class MinMaxValues
    {
        public static void MinMaxValuesExample()
        {
            // Demonstrating the minimum and maximum values of each datatype
            Console.WriteLine("Signed integral types:");
            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine("\nUnsigned Data Types: ");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine("\nFloating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

            // Reference Type Variables
            int[] data; // Declare a reference variable
            data = new int[3]; // Create a new array, now data references

            int[] data2 = new int[3]; // Declare the reference variable and immidietly points it to the new array of 3 integers
        }
    }

    public class ValueAndReferenceTypes
    {
        public static void ValueAndReferenceTypesExample()
        {
            // Value Types
            int val_A = 2;
            int val_B = val_A;
            val_B = 5;

            Console.WriteLine("--Value Types--");
            Console.WriteLine($"val_A: {val_A}"); // 2
            Console.WriteLine($"val_B: {val_B}"); // 5

            // Reference Types
            int[] ref_1 = new int[1];
            ref_1[0] = 2;
            int[] ref_2 = ref_1; // When ref_2 is initialised, it points to the same memory as ref_1
            ref_2[0] = 5;  // Changes ref_2 is changed to 5, so is ref_1 because it points to the same place
            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_1[0]}");
            Console.WriteLine($"ref_B[0]: {ref_2[0]}");

        }
    }

    public class Casting
    {
        public static void CastingExample()
        {

            // Compiler can make safe conversions e.g. int to string
            int first = 2;
            string second = "4";

            string result = first + second;
            Console.WriteLine(result); // 24

            // E.g. int to decimal
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            // Casting
            decimal myDecimal2 = 3.89m;
            Console.WriteLine("My Decimal " + myDecimal2);

            int myInt2 = (int)myDecimal2;
            Console.WriteLine($"int: {myInt2}");

            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);


            // Trying to parse a value, returns an out value (result1) and whether it was true/fals
            string value1 = "102";
            int result1 = 0;
            if (int.TryParse(value1, out result1))
            {
            Console.WriteLine($"Measurement: {result1}");
            }
            else
            {
            Console.WriteLine("Unable to report the measurement.");
            }

        }
    }
}