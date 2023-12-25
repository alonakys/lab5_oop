using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public abstract class Figure
    {
        protected int x;
        protected int y;
        protected Form form;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            for (int i = 0; i < 25; i++)
            {
                x += 5;
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
            }
        }
        public Figure(int x, int y, Form form)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "Form should not be null.");
            }
            this.x = x;
            this.y = y;
            this.form = form;
        }
    }
}
