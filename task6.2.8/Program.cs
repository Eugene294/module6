using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public int Square()
        {
            return a * b;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Rectangle(int a)
        {
            this.a = a;
            b = a;
        }
    }
}
