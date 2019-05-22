using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905_ThirthTraining_Delegate
{
    class Guesser
    {
        public int Number { get; set; }
        public Guesser(int number)
        {
            Number = number;
        }
        bool correctNumber = false;
        public Action<int> TooBig { get; set; }
        public Action<int> TooSmall { get; set; }
        public Action<int> ItsBingo { get; set; }


        public void StartGuessing()
        {

            while (correctNumber == false)
            {
                Console.Write("Guess Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (ItsBingo != null && number == Number)
                {
                    correctNumber = true;
                    ItsBingo.Invoke(number);
                }
                if(TooBig != null && number > Number)
                {
                    TooBig.Invoke(number);
                }
                if(TooSmall != null && number < Number)
                {
                    TooSmall.Invoke(number);
                }
            }
        }
    }
}
