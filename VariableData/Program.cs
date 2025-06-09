using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;


namespace VariableData
{
    class Program 
    {
        public static void Main(string[] args) // This is the main entry point of the program
        {
            Console.WriteLine("Hello World");

            Example1.SayHello(); // Will execute the static method in the Example1 file

            // Demonstrating the minimum and maximum values of each datatype
            MinMaxValues.MinMaxValuesExample();

            // Demonstrating value and reference type variables
            ValueAndReferenceTypes.ValueAndReferenceTypesExample();
        }
    }
}