using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1905___Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            AtomicCalculator ac = new AtomicCalculator();
            SimpleCalculator sc = new SimpleCalculator();

            ac.GetNumberFromUser = sc.NumberGetter;            
            ac.MenuPrinter = sc.PrintMenu;
            ac.GetUserChoise = sc.GetUserChoise;
            ac.Calculate = sc.Calculator;
            ac.ResultPrinter = sc.PrintResultNicely;
            ac.ResultPrinter += x =>
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("*");
                }
            };
            ac.Run();
        }
    }
}
