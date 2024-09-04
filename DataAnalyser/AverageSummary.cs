using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    public class AverageSummary : SummaryStrategy
    {
        // concrete implementation
        public override void PrintSummary(List<int> numbers)
        {
            // input validation
            if (numbers == null || numbers.Count == 0)
            {
                Console.WriteLine("No numbers to calculate the average.");
                return;
            }

            int total = 0;
            int count = numbers.Count;

            foreach (var number in numbers)
            {
                total += number;
            }

            float average = (float) total / count;


            Console.WriteLine($"The average is {average}");
        }

        // private methods
        private float Average(List<int> numbers)
        {
            // input validation
            if (numbers == null || numbers.Count == 0)
            {
                Console.WriteLine("No numbers to calculate the average.");
                return 0;
            }

            int total = 0;
            int count = numbers.Count;

            foreach (var number in numbers)
            {
                total += number;
            }

            return (float) total / count;
        }

    }
}
