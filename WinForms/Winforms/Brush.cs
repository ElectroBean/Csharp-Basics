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
           xSize = drawArea.Width;
           ySize = drawArea.Height;
        }
        public Brush()
        {

        }
        public SolidBrush color = new SolidBrush(Color.PeachPuff);
        float size = 10;
        public bool marker = false;
        public bool eraser = false;
        bool selector = false;
        bool bucket = false;
        public bool painting = false;
        private const int xSize;
        private const int ySize;
        Bitmap bmp = new Bitmap(Image.FromFile("./BG.png"), xSize, ySize);

        public void paint(PictureBox drawArea, float upDownSize, MouseEventArgs e)
        {
            if (painting && marker)
            {
                //Bitmap bmp = new Bitmap(drawArea.Width, drawArea.Height);
                //drawArea.DrawToBitmap(bmp, new Rectangle(0, 0, drawArea.Width, drawArea.Height));
                Graphics g = Graphics.FromImage(bmp);
                g.FillEllipse(color, e.X - (upDownSize / 2), e.Y - (upDownSize / 2), upDownSize, upDownSize);
                drawArea.Image = bmp;

            }

            if (painting && eraser)
            {
                //Bitmap bmp = new Bitmap(drawArea.Width, drawArea.Height);
                //drawArea.DrawToBitmap(bmp, new Rectangle(0, 0, drawArea.Width, drawArea.Height));
                Graphics g = Graphics.FromImage(bmp);
                color = new SolidBrush(Color.White);
                g.FillEllipse(color, e.X - (upDownSize / 2), e.Y - (upDownSize / 2), upDownSize, upDownSize);
                drawArea.Image = bmp;
            }

            if(painting && bucket)
            {
                Bitmap bmp = new Bitmap(drawArea.Width, drawArea.Height);
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
