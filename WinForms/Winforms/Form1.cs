using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Imaging;

namespace Winforms
{
    public partial class Form1 : Form
    {
        Brush currentBrush;
        Bitmap bmp;
        //list of stamps because i needed a list for the assessment
        List<StampBrush> stamps = new List<StampBrush>();
        
        public Form1()
        {
            InitializeComponent();
            currentBrush = new Brush();
            pictureBox1.Image = Image.FromFile("./BG.png");
            bmp = new Bitmap(Image.FromFile("./BG.png"), pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                stamps.Add(new StampBrush(imageList1.Images[i]));
            }

         
            //System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Cross;
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //default background
            pictureBox1.Image = Image.FromFile("./BG.png");
            bmp = new Bitmap(Image.FromFile("./BG.png"), pictureBox1.Width, pictureBox1.Height);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saving
            FileStream fs = new FileStream("bexample.bin", FileMode.Create);
            pictureBox1.Image.Save(fs, ImageFormat.Png);
            fs.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // //setting brush to a new brush
           // if (radioButton1.Checked)
           // {
           //     currentBrush = new Brush();
           //     currentBrush.marker = true;
           //     currentBrush.color = new SolidBrush(colorDialog1.Color);
           //
           // }
           // else
           // {
           //     currentBrush.marker = false;
           //
           // }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //changes back to marker
            if (radioButton1.Checked)
            {
                SolidBrush newCol = currentBrush.color;
                currentBrush = new Brush();
                currentBrush.marker = true;
                currentBrush.color = newCol;

            }
            else
            {
                currentBrush.marker = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                currentBrush = new Brush();
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

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                currentBrush = new Brush();
                currentBrush.colorPick = true;

            }
            else
            {
                currentBrush.colorPick = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear the screen by resetting the bitmap to the original bitmap
            pictureBox1.Image = Image.FromFile("./BG.png");
            bmp = new Bitmap(Image.FromFile("./BG.png"), pictureBox1.Width, pictureBox1.Height);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //updates color
                currentBrush.updateColor(colorDialog1.Color);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            currentBrush.paint(bmp, pictureBox1, (float)numericUpDown4.Value, e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            currentBrush.painting = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentBrush.paint(bmp, pictureBox1, (float)numericUpDown4.Value, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            currentBrush.painting = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //XmlSerializer xml = new XmlSerializer(typeof(Bitmap));
            //StreamReader sr = new StreamReader("example.xml");
            //Bitmap bmap = xml.Deserialize(sr) as Bitmap;
            //sr.Close();
            //pictureBox1.Image = bmap;

            //byte[] bytes = new byte[fStream.Length];
            //fStream.Read(bytes, 0, (int)fStream.Length);

            if (File.Exists("bexample.bin"))
            {
                //loads image and draws it to bitmap so you can draw on it
                FileStream fStream = new FileStream("bexample.bin", FileMode.Open, FileAccess.Read);
                pictureBox1.Image = new Bitmap(fStream);
                fStream.Close();
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;

                bmp = new Bitmap(Image.FromFile(file));//, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG (*.png) | *.png |JPEG (*.jpg) | *.jpg | All files (*.*) | *.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;

                FileStream fs = new FileStream(file, FileMode.Create);
                pictureBox1.Image.Save(fs, ImageFormat.Png);
                fs.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                int img = itm.ImageIndex;
                Image ig = imageList1.Images[img];
                currentBrush = new StampBrush(ig);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                int img = itm.ImageIndex;
                Image ig = imageList1.Images[img];
                currentBrush = stamps[img];
            }
        }
    }
}
