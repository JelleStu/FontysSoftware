namespace Calorietracker
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
            this.rdoBtnMale = new System.Windows.Forms.RadioButton();
            this.rdoBtnWife = new System.Windows.Forms.RadioButton();
            this.rdoBtnActive = new System.Windows.Forms.RadioButton();
            this.rdoBtnLazy = new System.Windows.Forms.RadioButton();
            this.lblAge = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoBtnMale
            // 
            this.rdoBtnMale.AutoSize = true;
            this.rdoBtnMale.Location = new System.Drawing.Point(27, 71);
            this.rdoBtnMale.Name = "rdoBtnMale";
            this.rdoBtnMale.Size = new System.Drawing.Size(56, 21);
            this.rdoBtnMale.TabIndex = 1;
            this.rdoBtnMale.TabStop = true;
            this.rdoBtnMale.Text = "Man";
            this.rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdoBtnWife
            // 
            this.rdoBtnWife.AutoSize = true;
            this.rdoBtnWife.Location = new System.Drawing.Point(27, 116);
            this.rdoBtnWife.Name = "rdoBtnWife";
            this.rdoBtnWife.Size = new System.Drawing.Size(68, 21);
            this.rdoBtnWife.TabIndex = 2;
            this.rdoBtnWife.TabStop = true;
            this.rdoBtnWife.Text = "Vrouw";
            this.rdoBtnWife.UseVisualStyleBackColor = true;
            // 
            // rdoBtnActive
            // 
            this.rdoBtnActive.AutoSize = true;
            this.rdoBtnActive.Location = new System.Drawing.Point(44, 59);
            this.rdoBtnActive.Name = "rdoBtnActive";
            this.rdoBtnActive.Size = new System.Drawing.Size(129, 21);
            this.rdoBtnActive.TabIndex = 1;
            this.rdoBtnActive.TabStop = true;
            this.rdoBtnActive.Text = "Actief (normaal)";
            this.rdoBtnActive.UseVisualStyleBackColor = true;
            // 
            // rdoBtnLazy
            // 
            this.rdoBtnLazy.AutoSize = true;
            this.rdoBtnLazy.Location = new System.Drawing.Point(44, 104);
            this.rdoBtnLazy.Name = "rdoBtnLazy";
            this.rdoBtnLazy.Size = new System.Drawing.Size(188, 21);
            this.rdoBtnLazy.TabIndex = 5;
            this.rdoBtnLazy.TabStop = true;
            this.rdoBtnLazy.Text = "Niet actief (couch potato)";
            this.rdoBtnLazy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnLazy.UseVisualStyleBackColor = true;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(537, 49);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 17);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Leeftijd";
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(540, 91);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(100, 22);
            this.txbAge.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(540, 136);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Bereken";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBtnMale);
            this.groupBox1.Controls.Add(this.rdoBtnWife);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBtnActive);
            this.groupBox2.Controls.Add(this.rdoBtnLazy);
            this.groupBox2.Location = new System.Drawing.Point(265, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(200, 193);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lifestyle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoBtnMale;
        private System.Windows.Forms.RadioButton rdoBtnWife;
        private System.Windows.Forms.RadioButton rdoBtnActive;
        private System.Windows.Forms.RadioButton rdoBtnLazy;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

