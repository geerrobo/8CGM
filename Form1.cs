using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _8CGM
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog odf = new OpenFileDialog();

        private void btnClickthis_Click(object sender, EventArgs e)
        {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();                  
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //odf.Filter = "All|*.jpg;*.jpeg;*.png|JPG (*.jpg,*.jpeg)|*jpg;*jpeg|PNG|*.png";
            //lblHelloWord.Text = "Hello World";
            //odf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void opennewform(object obj)
        {
            Application.Run(new Form2());     
        }
    }
}
