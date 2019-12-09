﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 188.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
         
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Force = double.Parse(textBox2.Text);

            try
            {
                double Angle = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show(Angle + "has not been inputted correctly");
                double Angle = 0.0;
            }

            double angle = double.Parse(textBox1.Text);




            double Fx = Force * cos(angle);
            double Fy = Force * sin(angle);

            label1.Text = "Fx = " + Fx;
            label2.Text = "Fy = " + Fy;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
