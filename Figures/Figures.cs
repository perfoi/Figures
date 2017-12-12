using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class Figures 
    {
        private Stack<IDrawingObject> ourfigures = new Stack<IDrawingObject>();
        public Stack<IDrawingObject> Ourfigures { get { return ourfigures; } }
        private int x = 20;
        public int X { get { return x; } set { x = value; } }
        private int y = 20;
        public int Y { get { return y; } set { y = value; } }
        public void Push(IDrawingObject a)
        {
            ourfigures.Push(a);
        }
        public void Pop()
        {
            ourfigures.Pop();
        }
        public void Draw(Graphics g, Color c)
        {
            foreach (IDrawingObject o in ourfigures)
            {
                o.Draw(g);
            }
        }
    }
}
