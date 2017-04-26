using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {   //bool value for do while loop
            bool run = true;

            Console.WriteLine("Welcome to the Countires Maintenance Application!");

            do
            {   //prompts user for which type of action they would like to take
                Console.WriteLine("1 - See the list of countries");
                Console.WriteLine("2 - Add a country");
                Console.WriteLine("3 - Delete a country");
                Console.WriteLine("4 - Exit");
                Console.Write("\nEnter menu number:");
                int input = Validation.GetIntWithinRange();
                //passing intput and bool value into get choice method
                run = GetChoice(input, run);

                Console.WriteLine("\n");

            } while (run == true);
            //end message
            Console.WriteLine("Thank you for using the application!");
        }

        public static bool GetChoice(int input, bool run)
        {   //takes input method and selects what type of action the program takes
            if (input == 1)
            {   //calles read method in Textfile class
                CountriesTextFile.ReadFile();
            }
            if (input == 2)
            {   //prompts the user to enter a country value to add to the list
                Console.WriteLine("Enter country: ");
                string newcountry = Console.ReadLine();
                //passes input into writefile method
                CountriesTextFile.WriteFile(newcountry);

                Console.WriteLine("This country has been saved!");
            }
            if (input == 3)
            {   //calls delete file method
                CountriesTextFile.DeleteFile();
            }
            if (input == 4)
            {   //ends do/while loop
                run = false;
            }
            return run;
        }
    }
}
