using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public class Circle : Figure
    {
        private int radius;

        public Circle(int x, int y, int radius, Form form) : base(x, y, form)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius should be greater than 0.");
            }
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.FillEllipse(Brushes.Black, x, y, 2 * radius, 2 * radius);
            }
        }

        public override void HideDrawingBackGround()
        {
            using (Graphics g = form.CreateGraphics())
            {
                g.FillEllipse(Brushes.White, x, y, 2 * radius, 2 * radius);
            }
        }
    }
}
