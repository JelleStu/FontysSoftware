using System;
using System.Windows.Forms;

namespace Calculator
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
            this.txbNumber1 = new System.Windows.Forms.TextBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.txbNumberTwo = new System.Windows.Forms.TextBox();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnToPower = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNumber1
            // 
            this.txbNumber1.Location = new System.Drawing.Point(32, 125);
            this.txbNumber1.Name = "txbNumber1";
            this.txbNumber1.Size = new System.Drawing.Size(100, 22);
            this.txbNumber1.TabIndex = 0;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(55, 84);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(58, 17);
            this.lblFirstNumber.TabIndex = 1;
            this.lblFirstNumber.Text = "Getal 1:";
            // 
            // txbNumberTwo
            // 
            this.txbNumberTwo.Location = new System.Drawing.Point(182, 125);
            this.txbNumberTwo.Name = "txbNumberTwo";
            this.txbNumberTwo.Size = new System.Drawing.Size(100, 22);
            this.txbNumberTwo.TabIndex = 2;
            this.txbNumberTwo.TextChanged += new System.EventHandler(this.TxbNumberTwo_TextChanged);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(208, 85);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(58, 17);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Getal 2:";
            this.lblNumber2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(322, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 51);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(420, 100);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(63, 51);
            this.btnTimes.TabIndex = 5;
            this.btnTimes.Text = "*";
            this.btnTimes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.BtnTimes_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(58, 166);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(0, 17);
            this.lblOutcome.TabIndex = 6;
            // 
            // btnToPower
            // 
            this.btnToPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPower.Location = new System.Drawing.Point(518, 100);
            this.btnToPower.Name = "btnToPower";
            this.btnToPower.Size = new System.Drawing.Size(74, 48);
            this.btnToPower.TabIndex = 7;
            this.btnToPower.Text = "√";
            this.btnToPower.UseVisualStyleBackColor = true;
            this.btnToPower.Click += new System.EventHandler(this.btnToPower_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(632, 99);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 48);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnToPower);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txbNumberTwo);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.txbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumber1;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.TextBox txbNumberTwo;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnToPower;
        private Button btnDivide;
    }
}

