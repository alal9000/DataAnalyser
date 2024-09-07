using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize and instantiate variables and objects
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            MinMaxSummary minmax = new MinMaxSummary();
            AverageSummary average = new AverageSummary();

            // Create a DataAnalyser object with a list of 10 numbers and the minmax summary strategy
            DataAnalyser dataAnalyser = new DataAnalyser(numbers, minmax);

            // call the Summarise method
            dataAnalyser.Summarise();

            // add three numbers to the dataAnalyser
            dataAnalyser.AddNumber(11);
            dataAnalyser.AddNumber(12);
            dataAnalyser.AddNumber(13);

            // Set the summary strategy to the average strategy
            dataAnalyser.Strategy = average;

            // call the Summarise method
            dataAnalyser.Summarise();
        }
    }
}
