using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1905___Delegate
{
    class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoise { get; set; }
        public Func<int,int, int, double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }

        public void Run()
        {
            X = GetNumberFromUser();
            Y = GetNumberFromUser();
            MenuPrinter();
            int choiseOfUser = GetUserChoise();
            Calculate(X, Y, choiseOfUser);
            ResultPrinter(Calculate(X, Y, choiseOfUser));
        }


    }
}
