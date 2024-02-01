namespace calculator
{
    partial class Calculator
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            button_Clear = new Button();
            button_Negative = new Button();
            button_Delete = new Button();
            button_Multiply = new Button();
            button_Divide = new Button();
            button_Subtract = new Button();
            button_Add = new Button();
            button_Equals = new Button();
            textBox_Result = new TextBox();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Arial Rounded MT Bold", 30F);
            button7.Location = new Point(21, 164);
            button7.Name = "button7";
            button7.Size = new Size(120, 120);
            button7.TabIndex = 1;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Rounded MT Bold", 30F);
            button8.Location = new Point(147, 164);
            button8.Name = "button8";
            button8.Size = new Size(120, 120);
            button8.TabIndex = 2;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Rounded MT Bold", 30F);
            button9.Location = new Point(273, 164);
            button9.Name = "button9";
            button9.Size = new Size(120, 120);
            button9.TabIndex = 3;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 30F);
            button4.Location = new Point(21, 290);
            button4.Name = "button4";
            button4.Size = new Size(120, 120);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 30F);
            button5.Location = new Point(147, 290);
            button5.Name = "button5";
            button5.Size = new Size(120, 120);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 30F);
            button6.Location = new Point(273, 290);
            button6.Name = "button6";
            button6.Size = new Size(120, 120);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 30F);
            button1.Location = new Point(21, 416);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 30F);
            button2.Location = new Point(147, 416);
            button2.Name = "button2";
            button2.Size = new Size(120, 120);
            button2.TabIndex = 8;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 30F);
            button3.Location = new Point(273, 416);
            button3.Name = "button3";
            button3.Size = new Size(120, 120);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Font = new Font("Arial Rounded MT Bold", 30F);
            button0.Location = new Point(147, 542);
            button0.Name = "button0";
            button0.Size = new Size(120, 120);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Arial Rounded MT Bold", 30F);
            buttonDot.Location = new Point(273, 542);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(120, 120);
            buttonDot.TabIndex = 11;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += button_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Red;
            button_Clear.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Clear.ForeColor = SystemColors.ButtonHighlight;
            button_Clear.Location = new Point(21, 542);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(120, 120);
            button_Clear.TabIndex = 12;
            button_Clear.Text = "C";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += buttonClear_Click;
            // 
            // button_Negative
            // 
            button_Negative.BackColor = SystemColors.ActiveBorder;
            button_Negative.Font = new Font("Arial Rounded MT Bold", 20F);
            button_Negative.ForeColor = SystemColors.ButtonHighlight;
            button_Negative.Location = new Point(416, 164);
            button_Negative.Name = "button_Negative";
            button_Negative.Size = new Size(120, 120);
            button_Negative.TabIndex = 13;
            button_Negative.Text = "-/+";
            button_Negative.UseVisualStyleBackColor = false;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.Coral;
            button_Delete.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Delete.ForeColor = SystemColors.ButtonHighlight;
            button_Delete.Location = new Point(542, 164);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(120, 120);
            button_Delete.TabIndex = 14;
            button_Delete.Text = "D";
            button_Delete.UseVisualStyleBackColor = false;
            // 
            // button_Multiply
            // 
            button_Multiply.BackColor = SystemColors.ControlDarkDark;
            button_Multiply.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Multiply.ForeColor = SystemColors.ButtonHighlight;
            button_Multiply.Location = new Point(416, 290);
            button_Multiply.Name = "button_Multiply";
            button_Multiply.Size = new Size(120, 120);
            button_Multiply.TabIndex = 15;
            button_Multiply.Text = "x";
            button_Multiply.UseVisualStyleBackColor = false;
            button_Multiply.Click += button_Multiply_Click;
            // 
            // button_Divide
            // 
            button_Divide.BackColor = SystemColors.ControlDarkDark;
            button_Divide.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Divide.ForeColor = SystemColors.ButtonHighlight;
            button_Divide.Location = new Point(542, 290);
            button_Divide.Name = "button_Divide";
            button_Divide.Size = new Size(120, 120);
            button_Divide.TabIndex = 16;
            button_Divide.Text = "÷";
            button_Divide.UseVisualStyleBackColor = false;
            button_Divide.Click += button_Divide_Click;
            // 
            // button_Subtract
            // 
            button_Subtract.BackColor = SystemColors.ControlDarkDark;
            button_Subtract.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Subtract.ForeColor = SystemColors.ButtonHighlight;
            button_Subtract.Location = new Point(416, 416);
            button_Subtract.Name = "button_Subtract";
            button_Subtract.Size = new Size(120, 120);
            button_Subtract.TabIndex = 17;
            button_Subtract.Text = "-";
            button_Subtract.UseVisualStyleBackColor = false;
            // 
            // button_Add
            // 
            button_Add.BackColor = SystemColors.ControlDarkDark;
            button_Add.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Add.ForeColor = SystemColors.ButtonHighlight;
            button_Add.Location = new Point(416, 542);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(120, 120);
            button_Add.TabIndex = 18;
            button_Add.Text = "+";
            button_Add.UseVisualStyleBackColor = false;
            // 
            // button_Equals
            // 
            button_Equals.BackColor = SystemColors.ActiveCaption;
            button_Equals.Font = new Font("Arial Rounded MT Bold", 30F);
            button_Equals.ForeColor = SystemColors.ButtonHighlight;
            button_Equals.Location = new Point(542, 416);
            button_Equals.Name = "button_Equals";
            button_Equals.Size = new Size(120, 246);
            button_Equals.TabIndex = 19;
            button_Equals.Text = "=";
            button_Equals.UseVisualStyleBackColor = false;
            // 
            // textBox_Result
            // 
            textBox_Result.Font = new Font("Arial Rounded MT Bold", 40F);
            textBox_Result.Location = new Point(21, 45);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(638, 85);
            textBox_Result.TabIndex = 20;
            textBox_Result.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(682, 693);
            Controls.Add(textBox_Result);
            Controls.Add(button_Equals);
            Controls.Add(button_Add);
            Controls.Add(button_Subtract);
            Controls.Add(button_Divide);
            Controls.Add(button_Multiply);
            Controls.Add(button_Delete);
            Controls.Add(button_Negative);
            Controls.Add(button_Clear);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button buttonDot;
        private Button button_Clear;
        private Button button_Negative;
        private Button button_Delete;
        private Button button_Multiply;
        private Button button_Divide;
        private Button button_Subtract;
        private Button button_Add;
        private Button button_Equals;
        private TextBox textBox_Result;
    }
}
