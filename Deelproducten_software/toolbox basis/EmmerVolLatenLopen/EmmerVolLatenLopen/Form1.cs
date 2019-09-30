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

namespace EmmerVolLatenLopen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFillWithWater_Click(object sender, EventArgs e)
        {
            string BucketSizeText = txbSizeBucket.Text;
            string CupSizeText = txbSizeCup.Text;

            int bucketSize = Convert.ToInt16(BucketSizeText);
            int cupSize = Convert.ToInt16(CupSizeText);
            progressBar1.Maximum = bucketSize;


            while (bucketSize >= cupSize)
            {
                Thread.Sleep(1000); //doe niks voor 100 ms
                Application.DoEvents();
                cupSize +
               progressBar1.Value = cupSize;
            }

        }
    }
}
