using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class DrawingCircle : IDrawingObject
    {
        private int x;
        private int y;
        private Color c;
        public DrawingCircle(int x,int y,Color c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public void Draw(Graphics g)
        {
            Pen a = new Pen(c);
            g.DrawEllipse(a,x,y,20,20);
        }
    }
}
