using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String[] fruit = { "Appel", "Aardbei", "Banaan", "Framboos", "Mango" }; ;

            

            foreach(String eten in fruit)
            {
                fruitList.Items.Add(eten);
            }

            Array.Sort(fruit);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fruitList.Items.Clear();
            lblSelectedFruit.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FruitList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (fruitList.SelectedIndices.Count > 0)
            {
                int selectedNumber = fruitList.SelectedIndices[0];
                string selectedFruit = fruitList.Items[selectedNumber].Text;
                lblSelectedFruit.Text = selectedFruit;
            }
            else
            {
                return;
            }
            
        }
    }
}
