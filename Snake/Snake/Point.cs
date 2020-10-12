using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        // конструкторы
        public Point() { 
        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(int x, int y, char sym, bool draw)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            if (draw) Draw();
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            sym = p.sym;
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Move(int offset, Direction direction)
        {
            if      (direction == Direction.RIGHT) x = x + offset;
            else if (direction == Direction.LEFT) x = x - offset;
            else if (direction == Direction.UP)   y = y - offset;
            else if (direction == Direction.DOWN) y = y + offset;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool isHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
