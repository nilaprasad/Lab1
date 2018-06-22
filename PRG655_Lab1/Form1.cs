using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG655_Lab1
{
    public partial class Form1 : Form
    {
        public Form1(string[] salesname, double[] subtotal, int salespeople)
        {
            InitializeComponent();
            for (int i = 0; i < salespeople; i++)
            {
                this.chart1.Series["Sales"].Points.AddXY(salesname[i], subtotal[i]);
                this.chart1.Series["Sales"].IsValueShownAsLabel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
