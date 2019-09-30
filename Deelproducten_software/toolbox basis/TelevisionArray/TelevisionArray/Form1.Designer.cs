namespace TelevisionArray
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.txbAddChannel = new System.Windows.Forms.TextBox();
            this.btnTV = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.btnChannelUp = new System.Windows.Forms.Button();
            this.btnChannelDown = new System.Windows.Forms.Button();
            this.lblCurrentChannel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(558, 101);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(152, 45);
            this.btnAddChannel.TabIndex = 0;
            this.btnAddChannel.Text = "Voeg zender toe";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.BtnAddChannel_Click);
            // 
            // txbAddChannel
            // 
            this.txbAddChannel.Location = new System.Drawing.Point(395, 111);
            this.txbAddChannel.Name = "txbAddChannel";
            this.txbAddChannel.Size = new System.Drawing.Size(100, 22);
            this.txbAddChannel.TabIndex = 1;
            // 
            // btnTV
            // 
            this.btnTV.Location = new System.Drawing.Point(558, 234);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(152, 50);
            this.btnTV.TabIndex = 2;
            this.btnTV.Text = "Zet TV aan/uit";
            this.btnTV.UseVisualStyleBackColor = true;
            this.btnTV.Click += new System.EventHandler(this.BtnTV_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnOff.ForeColor = System.Drawing.Color.Red;
            this.lblOnOff.Location = new System.Drawing.Point(716, 149);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(91, 135);
            this.lblOnOff.TabIndex = 3;
            this.lblOnOff.Text = ".";
            // 
            // btnChannelUp
            // 
            this.btnChannelUp.Location = new System.Drawing.Point(220, 173);
            this.btnChannelUp.Name = "btnChannelUp";
            this.btnChannelUp.Size = new System.Drawing.Size(126, 43);
            this.btnChannelUp.TabIndex = 4;
            this.btnChannelUp.Text = "+";
            this.btnChannelUp.UseVisualStyleBackColor = true;
            this.btnChannelUp.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnChannelDown
            // 
            this.btnChannelDown.Location = new System.Drawing.Point(220, 233);
            this.btnChannelDown.Name = "btnChannelDown";
            this.btnChannelDown.Size = new System.Drawing.Size(126, 43);
            this.btnChannelDown.TabIndex = 5;
            this.btnChannelDown.Text = "-";
            this.btnChannelDown.UseVisualStyleBackColor = true;
            this.btnChannelDown.Click += new System.EventHandler(this.BtnChannelDown_Click);
            // 
            // lblCurrentChannel
            // 
            this.lblCurrentChannel.AutoSize = true;
            this.lblCurrentChannel.Location = new System.Drawing.Point(421, 250);
            this.lblCurrentChannel.Name = "lblCurrentChannel";
            this.lblCurrentChannel.Size = new System.Drawing.Size(59, 17);
            this.lblCurrentChannel.TabIndex = 6;
            this.lblCurrentChannel.Text = "TV is uit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentChannel);
            this.Controls.Add(this.btnChannelDown);
            this.Controls.Add(this.btnChannelUp);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.btnTV);
            this.Controls.Add(this.txbAddChannel);
            this.Controls.Add(this.btnAddChannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.TextBox txbAddChannel;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.Label lblOnOff;
        private System.Windows.Forms.Button btnChannelUp;
        private System.Windows.Forms.Button btnChannelDown;
        private System.Windows.Forms.Label lblCurrentChannel;
    }
}

