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
            Input input = new Input();
            string choice;
            //Get either manually entered text, or text from a file

            Console.WriteLine("Please choose a method of text input.  For Manual text enter [ M ]   or   For File text enter [ F ] >>>: ");

            choice = Console.ReadLine();
            
            if (choice == "M" | choice == "m")
                {
                  input.manualTextInput();
                }

            else if (choice == "F" | choice == "f")
                {
                  input.fileTextInput("Text File.txt");
                }



            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
