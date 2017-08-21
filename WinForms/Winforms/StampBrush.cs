using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Winforms
{
    class StampBrush : Brush
    {
        public Image stamp;
        public float size = 10;

        public StampBrush(Image image)
        {
            stamp = image;
        }

        override public void paint(Bitmap bmp, PictureBox drawArea, float upDownSize, MouseEventArgs e)
        {
            if (painting)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(stamp, e.X - (upDownSize / 2), e.Y - (upDownSize / 2));
                drawArea.Image = bmp;

            }
        }

    }
}
