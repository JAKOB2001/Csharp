using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_praqtikuli6
{
    class Square
    {
        private int side;
        private int area;
        private int perimeter;
        public Square(int s, int a, int p)
        {
            side = s;
            area = a;
            perimeter = p;
        }
        public void outPut(Label label_outPut)
        {
            label_outPut.Text = $"Side: {side} \nArea: {area} \nPerimeter: {perimeter}";
        }
    }
}
