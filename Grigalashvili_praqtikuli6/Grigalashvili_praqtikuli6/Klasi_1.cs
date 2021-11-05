using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grigalashvili_praqtikuli6
{
    class Klasi_1
    {
        public Square Calc_square(int side)
        {
            var area = side * side;
            var perimeter = side * 4;
            var square = new Square(side, area, perimeter);

            return square;
        }
        
    }
}
