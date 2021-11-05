using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_praqtikuli
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        private void button_area_Click(object sender, EventArgs e)
        {
            var rectBase = int.Parse(textBox_base.Text);
            var rectHight = int.Parse(textBox_hight.Text);

            var obj = new RectangleChild(rectBase, rectHight);

            label_answer.Text = "Rectangle area is : " + obj.Area().ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                        var a = int.Parse(textBox1.Text);
            var b = int.Parse(textBox2.Text);

            var obj = new TV_Child(a, b);
            obj.outPut(label_wattsHour, label_useTV, label_useWatts);
        }
    }
}
