using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsApp4
{
    public class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;
        public Rhomb(int x, int y, int horDiagLen, int vertDiagLen, Form1 form) : base(x, y, form)
        {
            ValidateDiagonalLength(horDiagLen, nameof(horDiagLen));
            ValidateDiagonalLength(vertDiagLen, nameof(vertDiagLen));
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }
        private void ValidateDiagonalLength(int length, string paramName)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "Diagonal length should be greater than 0.");
            }
        }
        public override void DrawBlack()
        {
            Point[] points =
            {
                new Point(x+horDiagLen/2,y),
                new Point(x+horDiagLen,y+vertDiagLen/2),
                new Point(x+horDiagLen/2,y+vertDiagLen),
                new Point(x,y+vertDiagLen/2)
            };
            using (Graphics g = form.CreateGraphics())
            {
                g.FillPolygon(Brushes.Black, points);
            }
        }
        public override void HideDrawingBackGround()
        {
            Point[] points = {
            new Point(x + horDiagLen / 2, y),
            new Point(x + horDiagLen, y + vertDiagLen / 2),
            new Point(x + horDiagLen / 2, y + vertDiagLen),
            new Point(x, y + vertDiagLen / 2)
        };

            using (Graphics g = form.CreateGraphics())
            {
                g.FillPolygon(Brushes.White, points);
            }
        }
    }
}