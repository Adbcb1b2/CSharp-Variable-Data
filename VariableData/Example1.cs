using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
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

    class ArrayHelperMethods
    {
        public static void ArrayHelperExample1()
        {
            string[] items = ["H11", "B5", "N9", "K2"];

            Console.WriteLine("Sorted List");

            // Sort the items alphanumerically
            Array.Sort(items);

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            // Now Reverse-Order the pallets
            Console.WriteLine("Reversed List");
            Array.Reverse(items);
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            // Clearing an array
            Console.WriteLine($"Before: {items[0]}");
            Array.Clear(items, 0, 2); // Clears items 0 up to 2
            Console.WriteLine($"After: {items[0]}"); // This will be null, the cleared value cannot be treated as a string

            // Storing the length of an array 
            int itemsLength = items.Length;
            Console.WriteLine($"Clearing 2... count: {itemsLength}");

            // Demonstrating a cleared string array, an int array would have values of 0
            foreach (string item in items)
            {
                Console.WriteLine($"Item: {item} ");
            }


        }

        public static void ArrayHelperExample2()
        {
            string[] pallets = ["B4", "C4", "D9", "G7"];

            Console.WriteLine("");

            Array.Clear(pallets, 0, 2); // Clear elements 0 up to 2

            // Print each element of the array after clearing it
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");

            // Resize the array to include 6 items
            Array.Resize(ref pallets, 6);

            Console.WriteLine($"Resizing 6... count: {pallets.Length}");

            // Changing the elements of an array
            pallets[4] = "Z01";
            pallets[5] = "Z99";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"Pallet: {pallet}");
            }

            Console.WriteLine();

            // Resize the array to have 3 items, removes the last items
            Array.Resize(ref pallets, 3);

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"Pallet: {pallet}");
            }

            // You cant remove null elements from an array.
            // You would have to count the number of non-null values in a loop using a counter
            // Then you need to create a second array that is the size of the counter variable
            // Then you would need to loop through each element in the original array and copy the non-null values
        }

        public static void ArrayHelperExample3()
        {
            // Convert a string to a char array
            string value = "123abc";
            char[] valueArray = value.ToCharArray();

            // Reverse the array
            Array.Reverse(valueArray);

            // Cast back to a string
            string result = new string(valueArray);

            Console.WriteLine(result);

            // Joining the reversed value array to a string separated by comma values
            string result2 = String.Join(",", valueArray);
            Console.WriteLine(result2);

            // We can then split this into an array of strings
            string[] result3 = result2.Split(',');
            foreach (var res in result3)
            {
                Console.WriteLine(res);
            }

        }

    }
}