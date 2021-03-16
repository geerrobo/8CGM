using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                Bitmap bi = new Bitmap(odf.FileName);
                
                pictureBox1.Image = bmpResize(bi, 350, 350, true);
                //pictureBox2.Image = bmpResize(new Bitmap("C:\\Users\\geerc\\source\\repos\\8CGM\\person_watermark2.png"), 200, 200, false);
                //pictureBox2.Image = new Bitmap("C:\\Users\\geerc\\source\\repos\\8CGM\\person_watermark2.png");
                //pictureBox2.Size = new Size(200, 200);
                /*Color[,] pixel = new Color[bi.Width, bi.Height];
                for (int i = 0; i < bi.Width; i++)
                {
                    for (int j = 0; j < bi.Height; j++)
                    {
                        pixel[i, j] = bi.GetPixel(i, j);
                    }
                }*/

                int partlenght = bi.Height / 3;
                /*Color top = new Color();
                top = bi.GetPixel(bi.Width/2,partlenght/2);
                Color mid = new Color();
                mid = bi.GetPixel(bi.Width/2,(partlenght/2)+partlenght);
                Color bot = new Color();
                bot = bi.GetPixel(bi.Width / 2, (partlenght / 2) + (partlenght*2));*/
                textBoxTest.BackColor = bi.GetPixel(bi.Width / 2, partlenght / 2);
            }
        }

        private Bitmap bmpResize(Bitmap bi, int width, int height, bool bo)
        {
            var brush = new SolidBrush(Color.Black);
            if (bo)
            {
                brush = new SolidBrush(Color.Black);
            }
            else
            {
                brush = new SolidBrush(Color.Black);
            }
            float scale = Math.Min((float)width / bi.Width, (float)height / bi.Height);
            var bmp = new Bitmap((int)width, (int)height);
            var graph = Graphics.FromImage(bmp);

            // uncomment for higher quality output
            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(bi.Width * scale);
            var scaleHeight = (int)(bi.Height * scale);

            graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
            graph.DrawImage(bi, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);
            return bmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}