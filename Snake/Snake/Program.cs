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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            Console.WriteLine();
            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}"); // 1 3
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}"); // 4 5

            p1 = p2;
            Console.WriteLine($"p1 = p2");

            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}"); // 4 5
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}"); // 4 5

            p2.x++;
            p2.y++;
            Console.WriteLine($"p2++");
            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}"); // 5 6
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}"); // 5 6

            Console.ReadLine();
        }
    }
}
