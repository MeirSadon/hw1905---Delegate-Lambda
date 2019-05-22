using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1905___Delegate
{
    class SimpleCalculator
    {
        public int NumberGetter()
        {
            int number = -1;
            while (number < 0)
            {
                Console.WriteLine("Please Enter Positive Number:");
                number = Convert.ToInt32(Console.ReadLine());
            }
                return number;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Choose Your Operation:\n" +
                "Press '1' For '+'\n" +
                "Press '2' For '-'\n" +
                "Press '3' For 'X'\n" +
                "Press '4' For '/'");
        }

        public int GetUserChoise()
        {
            int oper = 0;
            while (oper < 1 || oper > 4)
            {
                oper = Convert.ToInt32(Console.ReadLine());
            }
            return oper;
        }

        public double Calculator(int n1, int n2, int oper)
        {
            switch (oper)
            {
                case 1: return n1 + n2;
                case 2: return n1 - n2;
                case 3: return n1 * n2;
                case 4: return n1 / n2;
                default: return -1;
            }

            //double result = -1;
            //switch (oper)
            //{
            //    case 1: { result = n1 + n2; return result; }
            //    case 2: { result = n1 - n2; return result; }
            //    case 3: { result = n1 * n2; return result; }
            //    case 4: { result = n1 / n2; return result; }
            //}
            //PrintResultNicely(result);
            //return result;

        }

        public void PrintResultNicely(double resultOfCalculate)
        {
            for (int i = 0; i < resultOfCalculate; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\nThe Result Is: {resultOfCalculate}");
        }
    }
}