using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            this.y = 0;
            this.x = 0;
        }
        public void seeCord()
        {
            Console.WriteLine($"Координаты х: {x} \nКоординаты y: {y}");
        }
        public void cordFromBegin()
        {
            Console.WriteLine($"Растояние от начала координат {Math.Sqrt((x*x) + (y*y))}" );
        }
        public void setPoint(ref int nx, ref int ny)
        {
            x = nx;
            y = ny;
        }
        public int newCordx
        {
            get { return x; }
            set
            {
                if (0 > value || value > 100)
                {
                    throw new Exception("=== Выход за пределы поля ===");
                }
                x = value;
            }
        }
        public int newCordy
        {
            get { return y; }
            set
            {
                if (0 > value || value > 100)
                {
                    throw new Exception("=== Выход за пределы поля ===");
                }
                y = value;
            }
        }
        public int umnX
        {
            get { return x; }
            set { x = value *  10; }
        }
        public int umnY
        {
            get { return y; }
            set { y = value * 10;}
        }
        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                        case 1: return y;
                    default: throw new Exception("Такого индекса не существует");
                }
            }
        }
        public static Point operator ++(Point p1)
        {
            return new Point(p1.x = p1.x + 1, p1.y = p1.y = p1.y + 1);
        }

    }
}
