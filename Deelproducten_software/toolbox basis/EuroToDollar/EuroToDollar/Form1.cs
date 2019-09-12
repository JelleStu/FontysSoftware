using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroToDollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string euro = TxbEuro.Text;
            decimal koers = KoersNummericUpDown.Value;
            decimal eurodecimal = Convert.ToDecimal(euro);

            decimal result = eurodecimal * koers;
            TxbDollar.Text = result.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dollarstring = TxbDollar.Text;
            decimal koers = KoersNummericUpDown.Value;
            decimal dollardecimal = Convert.ToDecimal(dollarstring);
            decimal euros = dollardecimal * koers;
            TxbEuro.Text = euros.ToString();
        }
    }
}
