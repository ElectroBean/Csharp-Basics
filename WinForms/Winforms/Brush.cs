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
        public SolidBrush color = new SolidBrush(Color.Black);
        float size = 10;
        public bool marker = false;
        public bool eraser = false;
        public bool bucket = false;
        public bool painting = false;
        public bool colorPick = false;

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
                Graphics g = Graphics.FromImage(bmp);
                

                drawArea.Image = bmp;

            }

            if(painting && colorPick)
            {
                Color  newColor = bmp.GetPixel(e.X, e.Y);
                color = new SolidBrush(newColor);
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
