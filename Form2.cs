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
   

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            odf.Filter = "All|*.jpg;*.jpeg;*.png|JPG (*.jpg,*.jpeg)|*jpg;*jpeg|PNG|*.png";
            if (odf.ShowDialog() == DialogResult.OK)
            {
              
                
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
