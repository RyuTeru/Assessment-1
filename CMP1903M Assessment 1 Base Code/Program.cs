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
            Input textobj = new();
            //Get either manually entered text, or text from a file
            bool choice_made;
            choice_made = false;
            while (choice_made == false)
            {
                Console.WriteLine("Please choose a method of text input.  For Manual text enter [ M ]   or   For File text enter [ F ] >>>: ");
                string choice = Console.ReadLine();

                if (choice == "M" | choice == "m")
                {
                    textobj.manualTextInput();
                    if (textobj.text.Length == 0)
                    {
                        Console.WriteLine("No manual sentence was given.");
                        continue;
                    } 
                    choice_made = true;
                }
                else if (choice == "F" | choice == "f")
                {
                    string CurrentDir = Environment.CurrentDirectory;
                    string location = ("Text File.txt");
                    textobj.fileTextInput(location);
                    choice_made = true;
                    Analyse LongWords = new();
                    LongWords.findLongWords(textobj.text);
                    Report fileToReport = new();
                    fileToReport.longWordReport();
                }
                else
                {
                    Console.WriteLine("Invalid input made...");
                    choice_made = false;
                }
            }
            //Create an 'Analyse' object
            Analyse sentence = new();
            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            parameters = sentence.analyseText(textobj.text);
            //Report the results of the analysis
            Report textToReport = new();
            Console.WriteLine(textToReport.analysisReport(parameters));

            //Get the frequency of individual letters
            Input frequency = new();
            string freq;
            choice_made = false;
            while (choice_made == false)
            {
                freq = frequency.freqQuestion();
                if (freq.ToUpper() == "Y")
                {
                    sentence.letterFrequency(textobj.text);
                    Console.WriteLine("\n Ending program...");
                    break;
                }
                else if (freq.ToUpper() == "N")
                {
                    Console.WriteLine("Ending program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }
        
        
    
    }
}
