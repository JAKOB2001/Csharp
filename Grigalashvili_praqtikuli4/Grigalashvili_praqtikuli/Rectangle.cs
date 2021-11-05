using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_praqtikuli
{
    public class Rectangle
    {
        protected int rectangleBase;

        public Rectangle(int areaBase)
        {
            rectangleBase = areaBase;
        }
    }
    public class RectangleChild : Rectangle
    {
        protected int rectangleHight;
        protected int rectangleArea;
         
        public RectangleChild(int areaBase,int hight): base(areaBase)
        {
            rectangleHight = hight;
        }
        public int Area()
        {
            return rectangleHight * rectangleBase;
        }
    }
}
