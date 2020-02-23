namespace Present_Value
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
            this.fvLabel = new System.Windows.Forms.Label();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.userAccumulateTextBox = new System.Windows.Forms.TextBox();
            this.userInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.userYearsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fvLabel
            // 
            this.fvLabel.AutoSize = true;
            this.fvLabel.Location = new System.Drawing.Point(12, 58);
            this.fvLabel.Name = "fvLabel";
            this.fvLabel.Size = new System.Drawing.Size(204, 13);
            this.fvLabel.TabIndex = 0;
            this.fvLabel.Text = "How much would you like to accumulate?";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(12, 102);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(226, 13);
            this.interestRateLabel.TabIndex = 1;
            this.interestRateLabel.Text = "What is the annual interest rate that will apply?";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(12, 155);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(251, 13);
            this.yearsLabel.TabIndex = 2;
            this.yearsLabel.Text = "In how many years do you want to accumulate this?";
            // 
            // userAccumulateTextBox
            // 
            this.userAccumulateTextBox.Location = new System.Drawing.Point(222, 55);
            this.userAccumulateTextBox.Name = "userAccumulateTextBox";
            this.userAccumulateTextBox.Size = new System.Drawing.Size(114, 20);
            this.userAccumulateTextBox.TabIndex = 3;
            // 
            // userInterestRateTextBox
            // 
            this.userInterestRateTextBox.Location = new System.Drawing.Point(244, 102);
            this.userInterestRateTextBox.Name = "userInterestRateTextBox";
            this.userInterestRateTextBox.Size = new System.Drawing.Size(114, 20);
            this.userInterestRateTextBox.TabIndex = 4;
            // 
            // userYearsTextBox
            // 
            this.userYearsTextBox.Location = new System.Drawing.Point(269, 152);
            this.userYearsTextBox.Name = "userYearsTextBox";
            this.userYearsTextBox.Size = new System.Drawing.Size(114, 20);
            this.userYearsTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(80, 243);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(244, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calculateLabel
            // 
            this.calculateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculateLabel.Location = new System.Drawing.Point(108, 193);
            this.calculateLabel.Name = "calculateLabel";
            this.calculateLabel.Size = new System.Drawing.Size(185, 37);
            this.calculateLabel.TabIndex = 8;
            this.calculateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 314);
            this.Controls.Add(this.calculateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.userYearsTextBox);
            this.Controls.Add(this.userInterestRateTextBox);
            this.Controls.Add(this.userAccumulateTextBox);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.fvLabel);
            this.Name = "Form1";
            this.Text = "Present Value Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fvLabel;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox userAccumulateTextBox;
        private System.Windows.Forms.TextBox userInterestRateTextBox;
        private System.Windows.Forms.TextBox userYearsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label calculateLabel;
    }
}

