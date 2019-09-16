namespace GuessTheSentence
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbSentence = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbWord = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raad de zin";
            // 
            // txbSentence
            // 
            this.txbSentence.Location = new System.Drawing.Point(199, 178);
            this.txbSentence.Name = "txbSentence";
            this.txbSentence.Size = new System.Drawing.Size(389, 22);
            this.txbSentence.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vul hier je zin in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raad een woord";
            // 
            // txbWord
            // 
            this.txbWord.Location = new System.Drawing.Point(302, 296);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(170, 22);
            this.txbWord.TabIndex = 4;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(327, 382);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(143, 17);
            this.lblOutcome.TabIndex = 5;
            this.lblOutcome.Text = "Woord is op positie: x";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(512, 287);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(109, 40);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Raad";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.txbWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSentence);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSentence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnGuess;
    }
}

