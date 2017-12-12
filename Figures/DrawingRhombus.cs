using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class DrawingRhombus : IDrawingObject
    {
        private int x;
        private int y;
        private Color c;
        Point[] P = new Point[4];
        public DrawingRhombus(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public void Draw(Graphics g)
        {
            Pen a = new Pen(c);
            P[0] = new Point(x+10, y);
            P[1] = new Point(x, y +10);
            P[2] = new Point(x + 10, y+20);
            P[3] = new Point(x+20, y+10);
            g.DrawPolygon(a, P);
        }
    }
}
