//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            Input input = new();
            //Get either manually entered text, or text from a file
            bool choice_made;
            choice_made = false;

            while (choice_made == false)
            {

                Console.WriteLine("Please choose a method of text input.  For Manual text enter [ M ]   or   For File text enter [ F ] >>>: ");
                string choice = Console.ReadLine();

                if (choice == "M" | choice == "m")
                {
                    input.manualTextInput();
                    
                    choice_made = true;
                }

                else if (choice == "F" | choice == "f")
                {
                    string CurrentDir = Environment.CurrentDirectory;
                    Console.WriteLine(CurrentDir);
                    Console.ReadLine();
                    string location = (@$"{CurrentDir}\Text File.txt");
                    input.fileTextInput(location);
                    choice_made = true;
                }
                else
                {
                    Console.WriteLine("Invalid input made...");
                    choice_made = false;
                }
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
