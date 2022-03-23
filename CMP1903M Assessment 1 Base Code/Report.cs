using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Report
    {
        //Handles the reporting of the analysis
        public string analysisReport(List<int> reportList)
        {
            return $"Below is the analysis of the text given... \nSentences: {reportList[0]}\nVowels: {reportList[1]}\nConsonants: {reportList[2]}\nUpper Case: {reportList[3]}\nLower Case: {reportList[4]} ";
        }

        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
}
