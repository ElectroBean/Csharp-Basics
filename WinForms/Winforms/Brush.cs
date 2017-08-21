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
        public Brush(PictureBox drawArea)
        {

        }
        public Brush()
        {

        }
        public SolidBrush color = new SolidBrush(Color.PeachPuff);
        float size = 10;
        public bool marker = false;
        public bool eraser = false;
        bool bucket = false;
        public bool painting = false;

        virtual public void paint(Bitmap bmp, PictureBox drawArea, float upDownSize, MouseEventArgs e)
        {
            if (painting && marker)
            {
                //drawArea.DrawToBitmap(bmp, new Rectangle(0, 0, drawArea.Width, drawArea.Height));
                Graphics g = Graphics.FromImage(bmp);
                g.FillEllipse(color, e.X - (upDownSize / 2), e.Y - (upDownSize / 2), upDownSize, upDownSize);
                drawArea.Image = bmp;
                
                
            }

            if (painting && eraser)
            {
                //drawArea.DrawToBitmap(bmp, new Rectangle(0, 0, drawArea.Width, drawArea.Height));
                Graphics g = Graphics.FromImage(bmp);
                color = new SolidBrush(Color.White);
                g.FillEllipse(color, e.X - (upDownSize / 2), e.Y - (upDownSize / 2), upDownSize, upDownSize);
                drawArea.Image = bmp;

            }

            if(painting && bucket)
            {
                drawArea.DrawToBitmap(bmp, new Rectangle(0, 0, drawArea.Width, drawArea.Height));
                Graphics g = Graphics.FromImage(bmp);
                drawArea.Image = bmp;

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
