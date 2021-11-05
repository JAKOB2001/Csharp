using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_Praqtikuli1
{
    class Plane_2
    {
        public int tankCapacity; // Tank capacity of liter
        public int distance; // distance traveled with 1 liter

        public void toGrant(int flue, int dist)
        {
            tankCapacity = flue;
            distance = dist;
        }
        public void outPut(Label label)
        {
            label.Text = "tankCapacity: " + tankCapacity + "\n1 litres distance traveled in kilometers: " + distance;
        }
        public int traveledDistance()
        {
            return tankCapacity * distance;
        }

    }
}
