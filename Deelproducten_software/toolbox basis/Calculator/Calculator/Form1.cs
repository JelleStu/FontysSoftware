using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Start

            void showBox()
            {
                MessageBox.Show("Made by Jelle Stukstette");
            }

            #endregion
        }



        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxbNumberTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToInt16(txbNumber1.Text);
            double numberTwo = Convert.ToInt16(txbNumberTwo.Text);

            double outcome = numberOne + numberTwo;
            string outcomeText = outcome.ToString();

            if (outcome > 0)
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
                lblOutcome.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
            }


        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToInt16(txbNumber1.Text);
            double numberTwo = Convert.ToInt16(txbNumberTwo.Text);

            double outcome = numberOne * numberTwo;
            string outcomeText = outcome.ToString();

            if (outcome > 0)
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
                lblOutcome.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
            }

        }

        private void btnToPower_Click(object sender, EventArgs e)
        {
            double numberOne = Convert.ToInt16(txbNumber1.Text);

            double outcome = Math.Pow(numberOne, 0.5);
            string outcomeText = outcome.ToString();

            if (outcome > 0)
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
                lblOutcome.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblOutcome.Text = "Uitkomst: " + outcomeText;
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                double numberOne = Convert.ToInt16(txbNumber1.Text);
                double numberTwo = Convert.ToInt16(txbNumberTwo.Text);

                double outcome = numberOne / numberTwo;
                string outcomeText = outcome.ToString();

                if (outcome > 0)
                {
                    lblOutcome.Text = "Uitkomst: 0 ";
                    lblOutcome.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblOutcome.Text = "Uitkomst: " + outcomeText;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ongeldig getal ingevoerd");
                throw;
            }
        }
    }
}
