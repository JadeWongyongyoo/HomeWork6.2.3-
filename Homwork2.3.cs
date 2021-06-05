using System;

namespace HomeWork_6._2
{
    class Program
    {
        static void Main(string[] args)
        {            
            int NumberTakoyaki = int.Parse(Console.ReadLine());
            int NumberBigbox, Numbermediumbox, NumberSmallBox;
            NumberBigbox = NumberTakoyaki / 6;
            NumberTakoyaki = NumberTakoyaki % 6;
            Numbermediumbox = NumberTakoyaki / 4;
            NumberTakoyaki = NumberTakoyaki % 4;
            NumberSmallBox = NumberTakoyaki / 2;
            NumberTakoyaki = NumberSmallBox % 2;
            if (NumberTakoyaki == 1)
            {
                NumberSmallBox += 1; 
            }
            Console.WriteLine("large number of boxes: {0} || Number of medium-sized boxes = {1} || number of small boxes = {2}", NumberBigbox, Numbermediumbox, NumberSmallBox);
            Console.WriteLine();

        }
    }
}
