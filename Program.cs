using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            
            myFamily.Add("brother1", new Dictionary<string, string>(){
                {"name", "David"},
                {"age", "37"}
            });
            myFamily.Add("brother2", new Dictionary<string, string>(){
                {"name", "Devin"},
                {"age", "25"}
            });
            myFamily.Add("brother3", new Dictionary<string, string>(){
                {"name", "Deion"},
                {"age", "21"}
            });
            myFamily.Add("Mother", new Dictionary<string, string>(){
                {"name", "Jeanne"},
                {"age", "54"}
            });

            // for
            foreach (var sibling in myFamily)
            {
                Console.WriteLine($"{{0}} is my {sibling.Key} and is {{1}} years old.", sibling.Value["name"], sibling.Value["age"]);
                // foreach (var param in myFamily[sibling.Key])
                // {
                //     Console.WriteLine(param.Key);
                // }
            }
        }
    }
}
