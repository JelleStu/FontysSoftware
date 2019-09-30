using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisionArray
{
    public partial class Form1 : Form
    {
         int currentchannel = 0;
         string TV = "off";
        string[] channels =
        {
            "NPO", "NEDERLAND2", "NEDERLAND3", "RTL4", "NET5", "SBS6", "DISNEY", "ZIGGO SPORT", "COMEDY CENTRAL",
            "NATIONAL GEOGRAPHIC", "TELLSELL", "24/7 KITCHEN"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddChannel_Click(object sender, EventArgs e)
        {
            AddChannel();
        }

        private void AddChannel()
        {
            Array.Resize(ref channels, channels.Length + 1);
            channels[channels.Length - 1] = txbAddChannel.Text;
        }

        private void BtnTV_Click(object sender, EventArgs e)
        {
            if (TV == "off")
            {
                TV = "on";
                lblOnOff.ForeColor = Color.Green;
            }
            else
            {
                TV = "off";
                lblOnOff.ForeColor = Color.Red;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int nextChannel = currentchannel + 1;
            if (TV == "off")
            {
                MessageBox.Show("Zet je tv aan!");
            }
            else
            {
                if (nextChannel > channels.Length)
                {
                    return;
                }
                else
                {
                    lblCurrentChannel.Text = channels[currentchannel];
                    currentchannel++;
                }
            }
        }

        private void BtnChannelDown_Click(object sender, EventArgs e)
        {
            int nextChannel = currentchannel - 1;
            if (TV == "off")
            {
                MessageBox.Show("Zet je TV aan!");
            }
            else
            {
                if (nextChannel < 0)
                {
                    return;
                }
                else
                {
                    lblCurrentChannel.Text = channels[currentchannel];
                    currentchannel--;
                }
            }
        }
    }
}
