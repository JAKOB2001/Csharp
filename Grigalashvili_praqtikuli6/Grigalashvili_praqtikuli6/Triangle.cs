using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grigalashvili_praqtikuli6
{
    class Triangle
    {
        private int side1;
        private int side2;
        private int side3;
        private int per; // Perimeter
        public Triangle(int a, int b, int c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
        }
        public int Perimeter(Triangle triangle)
        {
            per = triangle.side1 + triangle.side2 + triangle.side3;
            return per;
        }
    }
}
