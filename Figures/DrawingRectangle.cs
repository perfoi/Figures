using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class DrawingRectangle : IDrawingObject
    {
        private int x;
        private int y;
        private Color c;
        public DrawingRectangle(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public void Draw(Graphics g)
        {
            Pen a = new Pen(c);
            g.DrawRectangle(a, x, y, 15, 20);
        }
    }
}
