using System;
using System.Collections.Generic;

namespace DictionariesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Create a dictionary, key/value pairs. using the Dictionary Class  
            Dictionary<string, string> newDict = new Dictionary<string, string>();
            //or
            var otherDict = new Dictionary<int, string>();
            //when populating, the Keys have to be unique. 
            newDict.Add("one", "Bub");
            newDict.Add("two", "Josh");
            newDict.Add("three", "Bob");
            newDict.Add("four", "jacob");

            otherDict.Add(1, "towel");
            otherDict.Add(2, "soap");
            otherDict.Add(3, "wash rag");
            otherDict.Add(4, "tooth brush");

            //This uses the .Count to display to number of objects in the dictionary
            Console.WriteLine($"There are {newDict.Count} things in dictionary one");
            Console.WriteLine($"There are {otherDict.Count} things in dictionary two");

            //Remove a key form the Duictiopnary
            newDict.Remove("one");
            otherDict.Remove(1);

            //see if the dictionary contains a value. 
            Console.WriteLine($"Dict one contains Key two: {newDict.ContainsKey("two")}");
            Console.WriteLine($"Dict two contains key 1: {otherDict.ContainsKey(1)}");

            //Print out the contents of the Dictionary using the KeyValuePair inside the foreach loop
            foreach (KeyValuePair<string, string> kvp in newDict)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }
            Console.WriteLine("- one ^ - two v -");
            foreach (KeyValuePair<int, string> kvp in otherDict)
            {
                Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
            }

        }
    
    }
}
