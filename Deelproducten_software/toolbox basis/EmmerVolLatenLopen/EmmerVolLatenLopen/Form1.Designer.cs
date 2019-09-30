namespace EmmerVolLatenLopen
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFillWithWater = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSizeBucket = new System.Windows.Forms.TextBox();
            this.txbSizeCup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 30);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 393);
            this.progressBar1.TabIndex = 0;
            // 
            // btnFillWithWater
            // 
            this.btnFillWithWater.Location = new System.Drawing.Point(291, 41);
            this.btnFillWithWater.Name = "btnFillWithWater";
            this.btnFillWithWater.Size = new System.Drawing.Size(191, 106);
            this.btnFillWithWater.TabIndex = 1;
            this.btnFillWithWater.Text = "Vullen met water";
            this.btnFillWithWater.UseVisualStyleBackColor = true;
            this.btnFillWithWater.Click += new System.EventHandler(this.BtnFillWithWater_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(291, 238);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(105, 17);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Emmer grootte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bekere grootte:";
            // 
            // txbSizeBucket
            // 
            this.txbSizeBucket.Location = new System.Drawing.Point(450, 232);
            this.txbSizeBucket.Name = "txbSizeBucket";
            this.txbSizeBucket.Size = new System.Drawing.Size(100, 22);
            this.txbSizeBucket.TabIndex = 4;
            // 
            // txbSizeCup
            // 
            this.txbSizeCup.Location = new System.Drawing.Point(450, 299);
            this.txbSizeCup.Name = "txbSizeCup";
            this.txbSizeCup.Size = new System.Drawing.Size(100, 22);
            this.txbSizeCup.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSizeCup);
            this.Controls.Add(this.txbSizeBucket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnFillWithWater);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnFillWithWater;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSizeBucket;
        private System.Windows.Forms.TextBox txbSizeCup;
    }
}

