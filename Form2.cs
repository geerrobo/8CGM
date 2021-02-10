using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8CGM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OpenFileDialog odf = new OpenFileDialog();

        public Color[][] getBitmapColorMatrix(string filePath)
        {
            Bitmap bmp = new Bitmap(filePath);
            Color[][] matrix;
            int height = bmp.Height;
            int width = bmp.Width;
            if (height > width)
            {
                matrix = new Color[bmp.Width][];
                for (int i = 0; i <= bmp.Width - 1; i++)
                {
                    matrix[i] = new Color[bmp.Height];
                    for (int j = 0; j < bmp.Height - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
            }
            else
            {
                matrix = new Color[bmp.Height][];
                for (int i = 0; i <= bmp.Height - 1; i++)
                {
                    matrix[i] = new Color[bmp.Width];
                    for (int j = 0; j < bmp.Width - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
            }
            return matrix;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            odf.Filter = "All|*.jpg;*.jpeg;*.png|JPG (*.jpg,*.jpeg)|*jpg;*jpeg|PNG|*.png";
            if (odf.ShowDialog() == DialogResult.OK)
            {
                int width = 640, height = 320;
                //bitmap
                Bitmap bmp = new Bitmap(width, height);
                Bitmap bi = new Bitmap(odf.FileName);

                //pictureBox1.Size = new Size(bi.Width, bi.Height);
                bi.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = bi;

                Color[,] pixel = new Color[bi.Width, bi.Height];
                /*for (int i = 0; i < bi.Width; i++)
                {
                    for (int j = 0; j < bi.Height; j++)
                    {
                        pixel[i, j] = bi.GetPixel(i, j);
                    }
                }*/

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}