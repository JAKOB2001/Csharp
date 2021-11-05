using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grigalashvili_praqtikuli
{
    public class TV
    {
        protected int watt_Hour;
        protected int duration_TV;
        public TV(int wattsHour, int durationTV)
        {
            watt_Hour = wattsHour;
            duration_TV = durationTV;
        }
        public int Calculate()
        {
            return watt_Hour * duration_TV;
        }
    }
    public class TV_Child : TV
    {
        private int use_Watts;
        public TV_Child(int wattsHour, int durationTV) : base(wattsHour, durationTV)
        {
            use_Watts = Calculate();
        }
        public void outPut(Label wattsHour, Label durationTV, Label useWatts)
        {
            wattsHour.Text = "How many watts per hour " + watt_Hour.ToString() + " watts";
            durationTV.Text = "How many hours did you use " + duration_TV.ToString() + " in hours";
            useWatts.Text = "Use watts " + use_Watts.ToString() + " watts";
        }
    }
}
