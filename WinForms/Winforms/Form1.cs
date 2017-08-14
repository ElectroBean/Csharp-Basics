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
        Brush currentBrush = new Brush(); 

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
            //Graphics gl = panel1.CreateGraphics();
            //gl.Clear(panel1.BackColor);
            //https://www.youtube.com/watch?v=HxCq77mrQyo
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            currentBrush.painting = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            currentBrush.painting = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            currentBrush.paint(panel1, (float)numericUpDown4.Value, e);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
            {
                currentBrush.marker = true;
                currentBrush.color = new SolidBrush(colorDialog1.Color);

            }
           else
            {
                currentBrush.marker = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                currentBrush.eraser = true;

            }
            else
            {
                currentBrush.eraser = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gl = panel1.CreateGraphics();
            gl.Clear(panel1.BackColor);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currentBrush.updateColor(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentBrush.updateColor(colorDialog1.Color);
            }
        }
    }
}
