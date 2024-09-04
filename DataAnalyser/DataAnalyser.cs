using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalyser
{
    public class DataAnalyser
    {
        // fields
        private List<int> _numbers;
        private SummaryStrategy _strategy;

        // constructors
        public DataAnalyser()
        {
            _strategy = new AverageSummary();
        }

        public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
        {
            _numbers = numbers;
            _strategy = strategy;
        }

        // properties
        public SummaryStrategy Strategy { get => _strategy; set => _strategy = value; }



        // methods
        public void AddNumber(int num)
        {
            if (num > 0) // input validation
            {
                _numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Enter a non negative number");
            }
        }

        public void Summarise()
        {
            Strategy.PrintSummary(_numbers);
        }

       
    }
}
