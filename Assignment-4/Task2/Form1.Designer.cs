namespace Calculator
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
            textBox1 = new TextBox();
            ClearButton = new Button();
            minus = new Button();
            divide = new Button();
            remove = new Button();
            zero = new Button();
            comma = new Button();
            Equal = new Button();
            multiply = new Button();
            three = new Button();
            two = new Button();
            One = new Button();
            Sum = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            History = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(59, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 79);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.UseWaitCursor = true;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // ClearButton
            // 
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Location = new Point(187, 145);
            ClearButton.Margin = new Padding(0);
            ClearButton.Name = "ClearButton";
            ClearButton.Padding = new Padding(6, 5, 6, 5);
            ClearButton.Size = new Size(80, 53);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += Clear_Click;
            // 
            // minus
            // 
            minus.FlatStyle = FlatStyle.Flat;
            minus.Location = new Point(286, 145);
            minus.Margin = new Padding(0);
            minus.Name = "minus";
            minus.Padding = new Padding(6, 5, 6, 5);
            minus.Size = new Size(80, 53);
            minus.TabIndex = 2;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += Subtraction_Click;
            // 
            // divide
            // 
            divide.FlatStyle = FlatStyle.Flat;
            divide.Location = new Point(384, 145);
            divide.Margin = new Padding(0);
            divide.Name = "divide";
            divide.Padding = new Padding(6, 5, 6, 5);
            divide.Size = new Size(80, 53);
            divide.TabIndex = 2;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += Divide_Click;
            // 
            // remove
            // 
            remove.FlatStyle = FlatStyle.Flat;
            remove.Location = new Point(487, 145);
            remove.Margin = new Padding(0);
            remove.Name = "remove";
            remove.Padding = new Padding(6, 5, 6, 5);
            remove.Size = new Size(80, 53);
            remove.TabIndex = 2;
            remove.Text = "x";
            remove.UseVisualStyleBackColor = true;
            remove.Click += Remove_Click;
            // 
            // zero
            // 
            zero.FlatStyle = FlatStyle.Flat;
            zero.Location = new Point(187, 400);
            zero.Margin = new Padding(0);
            zero.Name = "zero";
            zero.Padding = new Padding(6, 5, 6, 5);
            zero.Size = new Size(178, 53);
            zero.TabIndex = 2;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += Zero_Click;
            // 
            // comma
            // 
            comma.FlatStyle = FlatStyle.Flat;
            comma.Location = new Point(384, 400);
            comma.Margin = new Padding(0);
            comma.Name = "comma";
            comma.Padding = new Padding(6, 5, 6, 5);
            comma.Size = new Size(80, 53);
            comma.TabIndex = 2;
            comma.Text = ".";
            comma.UseVisualStyleBackColor = true;
            comma.Click += Comma_Click;
            // 
            // Equal
            // 
            Equal.FlatStyle = FlatStyle.Flat;
            Equal.Location = new Point(487, 400);
            Equal.Margin = new Padding(0);
            Equal.Name = "Equal";
            Equal.Padding = new Padding(6, 5, 6, 5);
            Equal.Size = new Size(80, 53);
            Equal.TabIndex = 2;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equals_Click;
            // 
            // multiply
            // 
            multiply.FlatStyle = FlatStyle.Flat;
            multiply.Location = new Point(487, 210);
            multiply.Margin = new Padding(0);
            multiply.Name = "multiply";
            multiply.Padding = new Padding(6, 5, 6, 5);
            multiply.Size = new Size(80, 53);
            multiply.TabIndex = 3;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += Multiplication_Click;
            // 
            // three
            // 
            three.FlatStyle = FlatStyle.Flat;
            three.Location = new Point(384, 210);
            three.Margin = new Padding(0);
            three.Name = "three";
            three.Padding = new Padding(6, 5, 6, 5);
            three.Size = new Size(80, 53);
            three.TabIndex = 4;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += Three_Click;
            // 
            // two
            // 
            two.FlatStyle = FlatStyle.Flat;
            two.Location = new Point(286, 210);
            two.Margin = new Padding(0);
            two.Name = "two";
            two.Padding = new Padding(6, 5, 6, 5);
            two.Size = new Size(80, 53);
            two.TabIndex = 5;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += Two_Click;
            // 
            // One
            // 
            One.FlatStyle = FlatStyle.Flat;
            One.Location = new Point(187, 210);
            One.Margin = new Padding(0);
            One.Name = "One";
            One.Padding = new Padding(6, 5, 6, 5);
            One.Size = new Size(80, 53);
            One.TabIndex = 6;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Sum
            // 
            Sum.FlatStyle = FlatStyle.Flat;
            Sum.Location = new Point(487, 276);
            Sum.Margin = new Padding(0);
            Sum.Name = "Sum";
            Sum.Padding = new Padding(6, 5, 6, 5);
            Sum.Size = new Size(80, 115);
            Sum.TabIndex = 7;
            Sum.Text = "+";
            Sum.UseVisualStyleBackColor = true;
            Sum.Click += Addition_Click;
            // 
            // six
            // 
            six.FlatStyle = FlatStyle.Flat;
            six.Location = new Point(387, 276);
            six.Margin = new Padding(0);
            six.Name = "six";
            six.Padding = new Padding(6, 5, 6, 5);
            six.Size = new Size(80, 53);
            six.TabIndex = 8;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += Six_Click;
            // 
            // five
            // 
            five.FlatStyle = FlatStyle.Flat;
            five.Location = new Point(286, 276);
            five.Margin = new Padding(0);
            five.Name = "five";
            five.Padding = new Padding(6, 5, 6, 5);
            five.Size = new Size(80, 53);
            five.TabIndex = 9;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += Five_Click;
            // 
            // four
            // 
            four.FlatStyle = FlatStyle.Flat;
            four.Location = new Point(187, 276);
            four.Margin = new Padding(0);
            four.Name = "four";
            four.Padding = new Padding(6, 5, 6, 5);
            four.Size = new Size(80, 53);
            four.TabIndex = 10;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += Four_Click;
            // 
            // seven
            // 
            seven.FlatStyle = FlatStyle.Flat;
            seven.Location = new Point(187, 338);
            seven.Margin = new Padding(0);
            seven.Name = "seven";
            seven.Padding = new Padding(6, 5, 6, 5);
            seven.Size = new Size(80, 53);
            seven.TabIndex = 10;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += Seven_Click;
            // 
            // eight
            // 
            eight.FlatStyle = FlatStyle.Flat;
            eight.Location = new Point(286, 338);
            eight.Margin = new Padding(0);
            eight.Name = "eight";
            eight.Padding = new Padding(6, 5, 6, 5);
            eight.Size = new Size(80, 53);
            eight.TabIndex = 9;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += Eight_Click;
            // 
            // nine
            // 
            nine.FlatStyle = FlatStyle.Flat;
            nine.Location = new Point(384, 338);
            nine.Margin = new Padding(0);
            nine.Name = "nine";
            nine.Padding = new Padding(6, 5, 6, 5);
            nine.Size = new Size(80, 53);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += Nine_Click;
            // 
            // History
            // 
            History.FormattingEnabled = true;
            History.ItemHeight = 15;
            History.Location = new Point(59, 145);
            History.Name = "History";
            History.Size = new Size(120, 304);
            History.TabIndex = 12;
            History.Click += History_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(614, 474);
            Controls.Add(History);
            Controls.Add(nine);
            Controls.Add(Sum);
            Controls.Add(eight);
            Controls.Add(six);
            Controls.Add(seven);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(multiply);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(One);
            Controls.Add(Equal);
            Controls.Add(remove);
            Controls.Add(comma);
            Controls.Add(divide);
            Controls.Add(zero);
            Controls.Add(minus);
            Controls.Add(ClearButton);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "The Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ClearButton;
        private Button minus;
        private Button divide;
        private Button remove;
        private Button zero;
        private Button comma;
        private Button Equal;
        private Button multiply;
        private Button three;
        private Button two;
        private Button One;
        private Button Sum;
        private Button six;
        private Button five;
        private Button four;
        private Button seven;
        private Button eight;
        private Button nine;
        private ListBox History;
    }
}