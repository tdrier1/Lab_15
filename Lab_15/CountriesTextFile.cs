using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_15
{
    class CountriesTextFile
    {

        public static void WriteFile(string input)
        {   //uses streamwriter class and creates a new object whith the file location
            StreamWriter sw = new StreamWriter("../../TextFile1.txt", true);
            //passes input into the writeline method
            sw.WriteLine(input);
            //closes access to the txt file
            sw.Close();
        }

        public static void DeleteFile()
        {   //creates list from reading the textfile from location
            List<string> lines = File.ReadAllLines("../../TextFile1.txt").ToList();
            //loop used to print all lines with a number attached
            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + lines[i]);
            }
            //prompts user for input
            Console.Write("Please select a country to remove by number: ");
            int remcountry = Convert.ToInt32(Console.ReadLine());
            //removes the line from the txt file
            lines.RemoveAt(remcountry - 1);
            //moves everything back to an array
            File.WriteAllLines("../../TextFile1.txt", lines.ToArray());
        }

        public static string ReadFile()
        {   //streamreader allows user to view txt file
            StreamReader rd = new StreamReader("../../TextFile1.txt", true);
            string FileContent = rd.ReadToEnd();
            //writes txt file in console
            Console.WriteLine("\n" + FileContent);
           //closes access when finished
            rd.Close();
            //returns value to main method
            return FileContent;
        }
    }
}
