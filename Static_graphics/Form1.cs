﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_graphics
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p = new Pen(System.Drawing.Color.Black);
        int cout_x;
        int cout_y;
        public Form1()
        {
            InitializeComponent();
            p.Width = Whide_trackBar.Value;
            g = pictureBox1.CreateGraphics();
           
        }
        private void Draw()
        {
            g.Clear(System.Drawing.Color.White);
            for (int i = 0; i < X_trackBar.Value; i++)
            {
                g.DrawEllipse(p, 20+100*i, 20, 100, 100);
                g.DrawEllipse(p, 45+100*i, 45, 50, 50);
            }
        }

        private void Whide_trackBar_Scroll(object sender, EventArgs e)
        {
            p.Width = Whide_trackBar.Value;
            Draw();
        }

        private void X_trackBar_Scroll(object sender, EventArgs e)
        {
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
