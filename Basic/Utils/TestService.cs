using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class TestService
    {
        // basic variables types
        public static void BasicVarTypes()
        {
            Console.WriteLine("-------> BasicVarTypes");

            // whole numbers
            byte byteData = 255;
            sbyte sbyteData = -128;
            int intData = -32;
            uint uintData = 4;
            short shortData = -100;
            ushort ushortData = 2;
            long longData = 23;

            // has decimals
            float floatData = 1.4e5f;
            double doubleData = 1.43e20;

            // characters
            char charData = 'e';
            string stringData = "testing";

            // boolean
            bool boolData = false;

            // some testing
            object typeofData = charData.GetType().FullName;
            bool defaultValue = default(bool);
            Console.WriteLine($"{ typeofData } | { defaultValue}");

        }

        // string
        public static void StringType()
        {
            Console.WriteLine("-------> StringType");
            string stringData = "Test String Data";
            int strIndex = stringData.IndexOf("Data");
            string modifiedStrData = stringData.Insert(strIndex, "insert ");
            string joinedStr = string.Join("",new String[]{ modifiedStrData, ": joined", "list of string"});
            string replaceStr = joinedStr.Replace(":", ">---->");
            string removedStr = replaceStr.Remove(0, 4);

            Console.WriteLine(removedStr);
        }


        // dates
        public static void Dates()
        {
            Console.WriteLine("-------> Dates");
        }

        // lists
        public static void Lists()
        {
            Console.WriteLine("-------> Lists");
        }


        // dictionaries
        public static void Dictionaries()
        {
            Console.WriteLine("-------> Dictionaries");
        }


        // json
        public static void Json()
        {
            Console.WriteLine("-------> Json");
        }


        // conditional statement
        public static void ConditionalStatements()
        {
            Console.WriteLine("-------> ConditionalStatements");
        }

        // loops
        public static void Loops()
        {
            Console.WriteLine("-------> Loops");
        }


        // linq
        public static void LingQ()
        {
            Console.WriteLine("-------> LingQ");
        }


        // using library
        public static void UsingLibrary()
        {
            Console.WriteLine("-------> UsingLibrary");
        }
    }
}
