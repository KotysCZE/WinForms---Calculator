namespace Kalkulačka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            result_button = new Button();
            dot = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            result = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Location = new Point(15, 186);
            n1.Name = "n1";
            n1.Size = new Size(48, 44);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += button1_Click;
            
            // 
            // n2
            // 
            n2.Location = new Point(69, 186);
            n2.Name = "n2";
            n2.Size = new Size(48, 44);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += button2_Click;

            // 
            // n3
            // 
            n3.Location = new Point(123, 186);
            n3.Name = "n3";
            n3.Size = new Size(48, 44);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += button3_Click;
            // 
            // n4
            // 
            n4.Location = new Point(15, 136);
            n4.Name = "n4";
            n4.Size = new Size(48, 44);
            n4.TabIndex = 3;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += button4_Click;
            // 
            // n5
            // 
            n5.Location = new Point(69, 136);
            n5.Name = "n5";
            n5.Size = new Size(48, 44);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += button5_Click;
            // 
            // n6
            // 
            n6.Location = new Point(123, 136);
            n6.Name = "n6";
            n6.Size = new Size(48, 44);
            n6.TabIndex = 5;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += button6_Click;
            // 
            // n7
            // 
            n7.Location = new Point(15, 86);
            n7.Name = "n7";
            n7.Size = new Size(48, 44);
            n7.TabIndex = 6;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += button7_Click;
            // 
            // n8
            // 
            n8.Location = new Point(69, 86);
            n8.Name = "n8";
            n8.Size = new Size(48, 44);
            n8.TabIndex = 7;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += button8_Click;
            // 
            // n9
            // 
            n9.Location = new Point(123, 86);
            n9.Name = "n9";
            n9.Size = new Size(48, 44);
            n9.TabIndex = 8;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += button9_Click;
            // 
            // n0
            // 
            n0.Location = new Point(69, 236);
            n0.Name = "n0";
            n0.Size = new Size(48, 44);
            n0.TabIndex = 9;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += button0_Click;
            // 
            // result_button
            // 
            result_button.Location = new Point(223, 13);
            result_button.Name = "result_button";
            result_button.Size = new Size(48, 44);
            result_button.TabIndex = 10;
            result_button.Text = "=";
            result_button.UseVisualStyleBackColor = true;
            result_button.Click += resultButton_Click;
            // 
            // dot
            // 
            dot.Location = new Point(123, 236);
            dot.Name = "dot";
            dot.Size = new Size(48, 44);
            dot.TabIndex = 11;
            dot.Text = ",";
            dot.UseVisualStyleBackColor = true;
            dot.Click += dotButton_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(225, 86);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(48, 44);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(225, 136);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(48, 44);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(225, 186);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(48, 44);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(225, 236);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(48, 44);
            buttonDivide.TabIndex = 15;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.ForeColor = SystemColors.ActiveCaptionText;
            result.Location = new Point(15, 28);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 16;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(15, 237);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(48, 44);
            clearButton.TabIndex = 17;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 293);
            Controls.Add(clearButton);
            Controls.Add(result);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(dot);
            Controls.Add(result_button);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "Kalkulačka";
            Text = "Kalkulačka";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button result_button;
        private Button dot;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Label result;
        private Button clearButton;
    }
}