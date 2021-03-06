﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Runtime.InteropServices.ComTypes;
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

        // conditional statement
        public static void ConditionalStatements()
        {
            Console.WriteLine("-------> ConditionalStatements");
            string name = "gilbert D. Cuerbo";
            string switchData = "a";

            // if else
            if ((name.IndexOf("gilbert") > -1) ? true : false)
            {
                Console.WriteLine("name is Gilbert");
            }
            else if (name.Length == 0)
            {
                Console.WriteLine("String Size is zero");
            }
            else
            {
                Console.WriteLine("Default Log");
            }

            // switch
            switch(switchData)
            {
                case "a":
                    Console.WriteLine("a process");
                    break;
                case "b":
                    Console.WriteLine("b process");
                    break;
                case "c":
                    Console.WriteLine("c process");
                    break;
                default:
                    Console.WriteLine("default process");
                    break;
            }
        }
 
        // loops
        public static void Loops()
        {
            Console.WriteLine("-------> Loops");
            // while
            int count = 0;
            int total = 0;
            while (count > 11)
            {
                count++;
                total++;
            }

            // do while
            count = 0;
            do
            {
                count++;
                total++;
            }
            while (count < 10);

            // for
            for (int i = 0; i < 10; i++)
            {
                total++;
            }

            Console.WriteLine($"Loop total: { total }");
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

            Dictionary<string, string> dictionaryData = new Dictionary<string, string>();
            dictionaryData.Add("firstName", "gilbert");
            dictionaryData.Add("middlename", "Defante");
            dictionaryData.Add("lastName", "cuerbo");
            dictionaryData.Add("gender", "male");
            dictionaryData.Remove("gender");

            foreach (KeyValuePair<string, string> me in dictionaryData) {
                Console.WriteLine($"{ me.Key }:{ me.Value }");
            }
        }

        // tuples
        public static void Tuples()
        {
            Console.WriteLine("-------> Tuples");

            Tuple<string, int, int, bool> collections = new Tuple<string, int, int, bool>("one", 2, 3, true);
            collections = Tuple.Create("wan", 4, 5, true);

            var coll = Tuple.Create(1,2,3,4,5,6,7,8);

            Console.WriteLine($"first is: { coll.Item1 } and the last is: { coll.Rest.Item1 }");
        }


        // json
        public static void Json()
        {
            Console.WriteLine("-------> Json");
            string data = @"{
                'Name': 'gebe',
                'Hobbies': []
            }";
            TestData parseData = JsonConvert.DeserializeObject<TestData>(data);
            parseData.Hobbies.Add("Drawing");
            parseData.Hobbies.Add("Programming");

            Console.WriteLine($"{ parseData.Name }'s Hobbies are: { String.Join(",", parseData.Hobbies) }\n #{ JsonConvert.SerializeObject(parseData) }");
        }


        // linq
        public static void LingQ()
        {
            Console.WriteLine("-------> LingQ");
            List<TestData> listDta = new List<TestData>() {
                new TestData() { Name = "gilbert", Hobbies = new List<string>() { "Drawing", "Progrmming", "BJJ"} },
                new TestData() { Name = "harold", Hobbies = new List<string>() { "Farming", "Mining", "Smoking"} },
                new TestData() { Name = "felix", Hobbies = new List<string>() { "diving", "spying", "jogging"} },
                new TestData() { Name = "elbon", Hobbies = new List<string>() { "reading", "chemicals", "history"} },
                new TestData() { Name = "dina", Hobbies = new List<string>() { "korean", "novel"} },
                new TestData() { Name = "Ian charlse", Hobbies = new List<string>() { "Invention", "playing", "cartoons"} }
            };

            // get pepole who loves drwing
            // query syntax
            List<TestData> artist = (
                from data in listDta
                where data.Name.Contains("gilbert")
                select data
            ).ToList();
            Console.WriteLine("artist: " + JsonConvert.SerializeObject(artist));

            // method syntax
            List<TestData> miner = listDta.Where(item => {
                return item.Name == "harold";
            }).ToList();

            Console.WriteLine("miner: " + JsonConvert.SerializeObject(miner));


        }


        // using library
        public static void UsingLibrary()
        {
            Console.WriteLine("-------> UsingLibrary");
        }
    }

    // test class
    class TestData
    {
        public string Name
        {
            get;
            set;
        }

        public List<string> Hobbies
        {
            get;
            set;
        }
    };
}
