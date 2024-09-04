using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    public class MinMaxSummary : SummaryStrategy
    {
        // concrete implementation
        public override void PrintSummary(List<int> numbers)
        {
            try
            {
                int min = numbers.Min();
                int max = numbers.Max();

                Console.WriteLine($"The min is {min} and the max is {max}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }

        // private methods
        private int Maximum(List<int> numbers)
        {
            // input validation
            if (numbers == null || numbers.Count == 0)
            {
                throw new InvalidOperationException("No numbers to calculate the maximum.");
            }

            return numbers.Max();
        }

        private int Minimum(List<int> numbers)
        {
            // input validation
            if (numbers == null || numbers.Count == 0)
            {
                throw new InvalidOperationException("No numbers to calculate the minimum.");
            }

            return numbers.Min();
        }
    }
}
