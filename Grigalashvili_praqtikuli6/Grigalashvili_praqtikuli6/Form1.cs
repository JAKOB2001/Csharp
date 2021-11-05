using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_praqtikuli6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_triangle_Click(object sender, EventArgs e)
        {
            var side1 = int.Parse(textBox_side1.Text);
            var side2 = int.Parse(textBox_side2.Text);
            var side3 = int.Parse(textBox_side3.Text);

            var side4 = int.Parse(textBox_side4.Text);
            var side5 = int.Parse(textBox_side5.Text);
            var side6 = int.Parse(textBox_side6.Text);

            var triangle_1 = new Triangle(side1, side2, side3);
            var triangle_2 = new Triangle(side4, side5, side6);

            label_triangle1.Text = "Triangle: triangle_1, Parameter: triangle_1\nanswer: "+ triangle_1.Perimeter(triangle_1);
            label_triangle2.Text = "Triangle: triangle_1, Parameter: triangle_2\nanswer: " + triangle_1.Perimeter(triangle_2);
            label_triangle3.Text = "Triangle: triangle_2, Parameter: triangle_1\nanswer: " + triangle_2.Perimeter(triangle_1);

        }
        private void button_square_Click(object sender, EventArgs e)
        {
            var square_1 = new Klasi_1();
            var square_2 = square_1.Calc_square(int.Parse(textBox_square.Text));
            square_2.outPut(label_square);
        }
    }
}
