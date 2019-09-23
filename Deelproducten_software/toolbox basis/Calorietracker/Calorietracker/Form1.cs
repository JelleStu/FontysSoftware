using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorietracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string Sex;
            double kcal = 0;
            string age = txbAge.Text;
            int agenumber = Convert.ToInt16(age);
            if (rdoBtnMale.Checked == true)
            {
                kcal = 2500;
                if (rdoBtnLazy.Checked == true)
                {
                    kcal = kcal * 0.9;
                }
                if (agenumber <= 50)
                {
                    kcal = kcal - 200;
                }
                string kcalstring = kcal.ToString();
                MessageBox.Show(kcalstring);
            }
            else if(rdoBtnWife.Checked == true)
            {
                kcal = 2000;
                if (rdoBtnLazy.Checked == true)
                {
                    kcal = kcal * 0.9;
                }
                if (agenumber >= 50)
                {
                    kcal = kcal - 200;
                }

                string kcalstring = kcal.ToString();
                MessageBox.Show(kcalstring);
            }
        }
    }
}
