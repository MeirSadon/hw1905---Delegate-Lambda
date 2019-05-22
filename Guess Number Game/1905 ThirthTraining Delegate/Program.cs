using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905_ThirthTraining_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Guesser guesser = new Guesser(r.Next(1000));
            Bingo b = new Bingo();
            guesser.ItsBingo = b.Print;

            NumberTooBig ntb = new NumberTooBig();
            guesser.TooBig = ntb.Print;

            NumberTooSmall nts = new NumberTooSmall();
            guesser.TooSmall = nts.Print;

            //Console.WriteLine("Choose Number From 0 Till 10");
            //Console.WriteLine($"\n\n\n*** {guesser.Number} ***\n\n\n");
            guesser.StartGuessing();
        }
    }
}
