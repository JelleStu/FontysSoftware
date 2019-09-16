using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheSentence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            string Sentece = txbSentence.Text;
            string word = txbWord.Text;

            int outcome = Sentece.IndexOf(word) + 1;
            lblOutcome.Text = outcome.ToString();
        }
    }
}
