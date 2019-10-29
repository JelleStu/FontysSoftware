using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisionArray
{
    public partial class Form1 : Form
    {
        int currentchannel = 0;
        bool TV = false;
       
        private List<Channel> channels;

        public Form1()
        {
            InitializeComponent();
            channels = new List<Channel>();
            channels.Add(new Channel("NPO",  1));
            channels.Add(new Channel( "Nederland 2", 2));
            channels.Add(new Channel("Nederland 3", 3));
            channels.Add(new Channel( "RTL 4",4));
        }

        private void BtnAddChannel_Click(object sender, EventArgs e)
        {
            AddChannel();
        }

        private void AddChannel()
        {
            string channelnew = txbAddChannel.Text;
            int channelnumbernew = Convert.ToInt32(txbChannel.Text);
            Channel NewChannel = new Channel(channelnew, channelnumbernew);
            if (channels == null)
                channels = new List<Channel>();

            channels.Add(NewChannel);
        }

        private void BtnTV_Click(object sender, EventArgs e)
        {
            TV = !TV;
            if (TV == false)
            {
                lblOnOff.ForeColor = Color.Red;
            }
            else
            {
                lblOnOff.ForeColor = Color.Green;
            }
            TV = !TV;
        }

        private void BtnChannelUpClick(object sender, EventArgs e)
        {
            
            int nextChannel = currentchannel + 1;
            if (TV == false)
            {
                MessageBox.Show("Zet je tv aan!");
            }
            else
            {
                if (nextChannel <= channels.Count)
                {
                    currentchannel++;
                    string channelName = GetChannelByNumber(currentchannel).getName();
                    lblCurrentChannel.Text = channelName;
                }
            }
        }

        private Channel getChannelByName(string channelName)
        {
            /*return channels.FirstOrDefault(c =>)*/
            foreach (Channel c in channels)
            {
                if (c.getName() == channelName)
                {
                    return c;
                }
            }

            return null;
        }
        private Channel GetChannelByNumber(int channelNumber)
        {
            return channels.FirstOrDefault(c => c.GetChannelnumber() == channelNumber);
            foreach (Channel c in channels)
            {
                if (c.GetChannelnumber() == channelNumber)
                    return c;
            }
            return null;
        }

        private void BtnChannelDown_Click(object sender, EventArgs e)
        {
            int nextChannel = currentchannel - 1;

            if (TV == false)
            {
                MessageBox.Show("Zet je TV aan!");
            }
            else
            {
                if (nextChannel > 0)
                {
                    currentchannel--;
                    string channelName = GetChannelByNumber(currentchannel).getName();
                    lblCurrentChannel.Text = channelName;
                }
            }
        }
    }
}
