using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms
{
    public partial class Form1 : Form
    {

        bool paint = false;
        SolidBrush color;
        bool marker = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            Graphics gl = panel1.CreateGraphics();
            gl.Clear(panel1.BackColor);
            //https://www.youtube.com/watch?v=HxCq77mrQyo
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint && marker)
            {
                color = new SolidBrush(Color.PeachPuff);
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(color, e.X - 5, e.Y - 5, 10, 10);
                // g.Dispose();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0))
            {
                marker = true;
            }
            if(!checkedListBox1.GetItemChecked(0))
            {
                marker = false;
            }
        }
    }
}
