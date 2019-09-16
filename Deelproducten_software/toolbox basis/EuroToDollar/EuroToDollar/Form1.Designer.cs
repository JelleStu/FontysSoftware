namespace EuroToDollar
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
            this.KoersNummericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToEuro = new System.Windows.Forms.Button();
            this.btnToDollar = new System.Windows.Forms.Button();
            this.lblKoers = new System.Windows.Forms.Label();
            this.TxbEuro = new System.Windows.Forms.TextBox();
            this.TxbDollar = new System.Windows.Forms.TextBox();
            this.cmBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KoersNummericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // KoersNummericUpDown
            // 
            this.KoersNummericUpDown.DecimalPlaces = 2;
            this.KoersNummericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.KoersNummericUpDown.Location = new System.Drawing.Point(368, 298);
            this.KoersNummericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KoersNummericUpDown.Name = "KoersNummericUpDown";
            this.KoersNummericUpDown.Size = new System.Drawing.Size(120, 22);
            this.KoersNummericUpDown.TabIndex = 0;
            this.KoersNummericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(641, 175);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 69);
            this.lblCurrency.TabIndex = 1;
            this.lblCurrency.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = "€";
            // 
            // btnToEuro
            // 
            this.btnToEuro.Location = new System.Drawing.Point(332, 222);
            this.btnToEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToEuro.Name = "btnToEuro";
            this.btnToEuro.Size = new System.Drawing.Size(75, 23);
            this.btnToEuro.TabIndex = 3;
            this.btnToEuro.Text = "<";
            this.btnToEuro.UseVisualStyleBackColor = true;
            this.btnToEuro.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnToDollar
            // 
            this.btnToDollar.Location = new System.Drawing.Point(425, 222);
            this.btnToDollar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToDollar.Name = "btnToDollar";
            this.btnToDollar.Size = new System.Drawing.Size(75, 23);
            this.btnToDollar.TabIndex = 4;
            this.btnToDollar.Text = ">";
            this.btnToDollar.UseVisualStyleBackColor = true;
            this.btnToDollar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblKoers
            // 
            this.lblKoers.AutoSize = true;
            this.lblKoers.Location = new System.Drawing.Point(244, 300);
            this.lblKoers.Name = "lblKoers";
            this.lblKoers.Size = new System.Drawing.Size(118, 17);
            this.lblKoers.TabIndex = 5;
            this.lblKoers.Text = "Koers: 1 euro = $";
            // 
            // TxbEuro
            // 
            this.TxbEuro.Location = new System.Drawing.Point(227, 223);
            this.TxbEuro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbEuro.Name = "TxbEuro";
            this.TxbEuro.Size = new System.Drawing.Size(100, 22);
            this.TxbEuro.TabIndex = 6;
            this.TxbEuro.Text = "1";
            // 
            // TxbDollar
            // 
            this.TxbDollar.Location = new System.Drawing.Point(519, 222);
            this.TxbDollar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxbDollar.Name = "TxbDollar";
            this.TxbDollar.Size = new System.Drawing.Size(100, 22);
            this.TxbDollar.TabIndex = 7;
            this.TxbDollar.Text = "1";
            // 
            // cmBox
            // 
            this.cmBox.FormattingEnabled = true;
            this.cmBox.Items.AddRange(new object[] {
            "Dollar",
            "Yen"});
            this.cmBox.Location = new System.Drawing.Point(351, 165);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(121, 24);
            this.cmBox.TabIndex = 8;
            this.cmBox.Text = "Selecteer munt";
            this.cmBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBox);
            this.Controls.Add(this.TxbDollar);
            this.Controls.Add(this.TxbEuro);
            this.Controls.Add(this.lblKoers);
            this.Controls.Add(this.btnToDollar);
            this.Controls.Add(this.btnToEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.KoersNummericUpDown);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Koers";
            ((System.ComponentModel.ISupportInitialize)(this.KoersNummericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown KoersNummericUpDown;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToEuro;
        private System.Windows.Forms.Button btnToDollar;
        private System.Windows.Forms.Label lblKoers;
        private System.Windows.Forms.TextBox TxbEuro;
        private System.Windows.Forms.TextBox TxbDollar;
        private System.Windows.Forms.ComboBox cmBox;
    }
}

