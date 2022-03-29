using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // New class made for Longwords function and Writing of a new file
    public class LongWordFile
    {   
        // Properties
        private const int longWordCap = 7;
        
        // Method to find all words longer than 7 letters
        public void findLongWords(string input)
        {   
            // Creation of list of long words
            List<string> longWords = new List<string>();
            // Temporary string to hold words
            string word = "";
            foreach (char character in input.ToCharArray())
                {  
                // If a real character is found then adds it to the temp string
                if (char.IsLetterOrDigit(character))
                {
                   word += character.ToString();
                   continue;
                }
                // If a non-character is found then checks the length of current temp string 
                if (word.Length > longWordCap)
                {
                    longWords.Add(word);
                }
                word = "";
                }
            // Creation of set to gather the unique long words
            var longWordSet = longWords.Distinct();
            string currentDir = Environment.CurrentDirectory;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(currentDir, "long words.txt")))
            {
                foreach (string words in longWordSet)
                    outputFile.WriteLine(words);
            }
        }
             




    }




}