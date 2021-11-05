using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grigalashvili_Praqtikuli1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Plane_1 obj_1 = new Plane_1();
            try
            {
                obj_1.passangerNumber = int.Parse(textBox1.Text);
                obj_1.ticketNumber = int.Parse(textBox2.Text);
                if(obj_1.ticketNumber < 0 || obj_1.ticketNumber < 0)
                {
                    throw new Exception();
                }
                label3.Text = "Passanger number: " + obj_1.passangerNumber +
                    " Ticket number: " + obj_1.ticketNumber;
            }
            catch (Exception)
            {
                label3.Text = "Incorrect Format!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plane_2 obj_2 = new Plane_2();
            try
            {
                int flue = int.Parse(textBox3.Text);
                int dist = int.Parse(textBox4.Text);
                if (flue < 0 || dist < 0)
                {
                    throw new Exception();
                }
                obj_2.toGrant(flue, dist);
                obj_2.outPut(label8);
                label9.Text = "The plane can pass Maxum: " +obj_2.traveledDistance().ToString() + " km";
            }
            catch(Exception)
            {
                label8.Text = "Incorrect Format!";
                label9.Text = "Incorrect Format!";
            }
        }

        private void button_Car_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.ownerName = textBox5.Text;
            car.carModel = textBox6.Text;

            label15.Text = car.ownerName;
            label16.Text = car.carModel;
        }
    }
}
