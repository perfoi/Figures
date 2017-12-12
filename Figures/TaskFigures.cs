using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }
        Color currentcolor = Color.Black;
        IDrawingObject figure;
        Figures g = new Figures();
        int x = 10;
        int y = 10;
        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                currentcolor = colorDialog1.Color;
            }
        }

        private void buttonDrawFigure_Click(object sender, EventArgs e)
        {
            if (radioButtonSquare.Checked)
            {
                figure=new DrawingSquare(x, y,currentcolor);
            }
            if (radioButtonCircle.Checked)
            {
                figure=new DrawingCircle(x, y, currentcolor);
            }
            if (radioButtonRhombus.Checked)
            {
                figure=new DrawingRhombus(x, y, currentcolor);
            }
            if (radioButtonTriangle.Checked)
            {
                figure=new DrawingTriangle(x, y, currentcolor);
            }
            if (radioButtonRectangle.Checked)
            {
                figure=new DrawingRectangle(x, y, currentcolor);
            }
            g.Push(figure);
            x += 30;
            panel1.Invalidate();
        }

        private void buttonDeleteLastFigure_Click(object sender, EventArgs e)
        {
            g.Pop();
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g.Draw(panel1.CreateGraphics(),currentcolor);
        }

        private void buttonNewRow_Click(object sender, EventArgs e)
        {
            y += 30;
            x = 10;
        }
    }
}
