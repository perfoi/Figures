using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public interface IDrawingObject
    {
       void Draw(Graphics g);
    }
}
