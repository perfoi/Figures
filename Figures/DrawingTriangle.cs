using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class DrawingTriangle : IDrawingObject
    {
        private int x;
        private int y;
        private Color c;
        Point[] P = new Point[3];
        public DrawingTriangle(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public void Draw(Graphics g)
        {
            P[0] = new Point(x, y + 20);
            P[1] = new Point(x + 20, y + 20);
            P[2] = new Point(x + 10, y);
            Pen a = new Pen(c);
            g.DrawPolygon(a, P);
        }
    }
}
