using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);
            // Draw Border
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            topLine.DrawLine();
            bottomLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            Point p1 = new Point(1, 3, '*', true);
            Point p2 = new Point(4, 5, '#', true);
            Console.WriteLine();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.DrawLine();
            Console.ReadLine();
        }
    }
}
