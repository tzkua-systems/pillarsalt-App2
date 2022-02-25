﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{
    class AnimatedLED : Button
    {
        public AnimatedLED()
        {
            BackColor = Color.DarkRed;
        }

        protected override void OnPaint(PaintEventArgs prevent)
        {
            base.OnPaint(prevent);

            Pen myPen = new Pen(this.BackColor, 1);
            Brush myBrush = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            Brush BrushInside = new SolidBrush(this.BackColor);

            Graphics g = prevent.Graphics;
            g.FillRectangle(myBrush, 0, 0, ClientSize.Width, ClientSize.Height);
            g.DrawEllipse(myPen, 0, 0, ClientSize.Width, ClientSize.Height);
            g.FillEllipse(BrushInside, 0, 0, ClientSize.Width, ClientSize.Height);

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);
        }
    }
}
