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
            string replaceStr = joinedStr.Replace(":", "#");
            string removedStr = replaceStr.Remove(0, 4);

            Console.WriteLine(removedStr);
        }


        // dates
        public static void Dates()
        {
            Console.WriteLine("-------> Dates");
            string format = "yyyy-MM-dd";
            DateTime date = DateTime.UtcNow;
            DateTime dateHereNow = DateTime.Now;
            DateTime costumDate = new DateTime(1995, 4, 27, 7, 30, 21);
            DateTime advanceDate = costumDate.AddDays(10);

            TimeZoneInfo timezone = TimeZoneInfo.Local;
            

            Console.WriteLine($"datetime here { dateHereNow } and for utc now { TimeZoneInfo.ConvertTimeToUtc(dateHereNow, timezone) },\n advance birthday{ advanceDate.ToString(format) }");

        }

        // lists
        public static void Lists()
        {
            Console.WriteLine("-------> Lists");
            List<string> listahan = new List<string>() {"Gilbert"};
            listahan.Add("Cuerbo");
            listahan.Add("Defante");
            listahan.Add("IT");

            // loop process
            listahan.ForEach((item) => {
                Console.WriteLine($"- { item }");
            });

            // filter process
            List<string> filtered = (List<string>) listahan.Where((item) => {
                return item != "IT";
            }).ToList();

            // map process
            List<bool> mapData = (List<bool>) listahan.Select((item) => {
                return item.IndexOf("Cuerbo") < 0? true: false;
            }).ToList();

            // reduce process
            String reduceData = listahan.Aggregate(
                seed: "",
                func: (item, acc) => {
                    if (item.Length > 0) { 
                        acc = $"{acc}+{item}";
                    }
                    return acc;
                }
            );

            // chained proceess
            string transformedData = listahan
                .Where((item) =>
                {
                    return item != "IT";
                })
                .Select((item) =>
                {
                    return $"* { item }";
                })
                .Aggregate(
                    seed: "",
                    func: (item, acc) => {
                        if (item.Length > 0)
                        {
                            acc = $"{acc}+{item}";
                        }
                        return acc;
                    }
                );


            //Console.WriteLine(String.Join(",", filtered));
            Console.WriteLine(transformedData);
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
