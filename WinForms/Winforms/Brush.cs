using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Winforms
{
    class Brush
    {
        public SolidBrush color = new SolidBrush(Color.PeachPuff);
        float size = 10.0f;
        public bool marker = false;
        public bool eraser = false;
        bool selector = false;
        bool bucket = false;
        public bool painting = false;

        public void paint(Panel drawArea, float upDownSize, MouseEventArgs e)
        {
            if (painting && marker)
            {
                Graphics g = drawArea.CreateGraphics();
                g.FillEllipse(color, e.X - (size / 2), e.Y - (size / 2), upDownSize, upDownSize);

            }

            if (painting && eraser)
            {
                Graphics g = drawArea.CreateGraphics();
                color = new SolidBrush(Color.White);
                g.FillEllipse(color, e.X - (size / 2), e.Y - (size / 2), upDownSize, upDownSize);

            }

            if(painting && bucket)
            {
                Graphics g = drawArea.CreateGraphics();

            }
        }

        public void updateSize(float aInput)
        {
            size = aInput;
        }

        public void updateColor(Color asd)
        {
            if (!eraser)
            {
                color = new SolidBrush(asd);

            }
        }

    }
}
