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
            try
            {
                decimal koers = KoersNummericUpDown.Value;
                if (koers <= 0)
                {
                    MessageBox.Show("Koers kan niet 0 of minder zijn");
                }
                else
                {
                    string euro = TxbEuro.Text;
                    decimal eurodecimal = Convert.ToDecimal(euro);
                    decimal result = eurodecimal * koers;
                    TxbDollar.Text = result.ToString();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ey pannenkoek vul cijfers in");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string dollarstring = TxbDollar.Text;
            try
            {
                decimal koers = KoersNummericUpDown.Value;
                if (koers <= 0)
                {
                    MessageBox.Show("Koers kan geen 0 of lager zijn");
                }
                else
                {
                    decimal dollardecimal = Convert.ToDecimal(dollarstring);
                    decimal euros = dollardecimal / koers;
                    TxbEuro.Text = euros.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ey pannenkoek vul cijfers in");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValuta = cmBox.SelectedItem.ToString();

            switch (SelectedValuta)
            {
                case "Dollar":
                    lblCurrency.Text = "$";
                    lblKoers.Text = "Koers: 1 euro = $";
                    break;

                case "Yen":
                    lblCurrency.Text = "¥";
                    lblKoers.Text = "Koers: 1 euro = ¥";
                    break;
            }
        }
    }
}
