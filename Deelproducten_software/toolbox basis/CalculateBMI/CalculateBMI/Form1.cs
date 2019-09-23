using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            messagebox();

            #region Start

            MessageBox.Show("Made by Jelle Stukstette");

            #endregion
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string weightText = txbWeight.Text;
            string lengthText = txbLength.Text;

            decimal weightDecimal = Convert.ToDecimal(weightText);
            decimal lengthDecimal = Convert.ToDecimal(lengthText);

            decimal sum = weightDecimal / (lengthDecimal * lengthDecimal);
            lblOutcome.Text = sum.ToString();
        }















        #region stop

        void messagebox()
        {
            MessageBox.Show("Made by jelle");
        }

        #endregion
    }
}




