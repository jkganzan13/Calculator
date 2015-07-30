using System.Drawing;
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
            this.seven = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.displayBottom = new System.Windows.Forms.Label();
            this.displayTop = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 84);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(49, 45);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(232, 186);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(47, 96);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(67, 84);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(49, 45);
            this.eight.TabIndex = 4;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(122, 84);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(49, 45);
            this.nine.TabIndex = 5;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 135);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(49, 45);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(67, 135);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(49, 45);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(122, 135);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(49, 45);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 186);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(49, 45);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(67, 186);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(49, 45);
            this.two.TabIndex = 10;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(122, 186);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(49, 45);
            this.three.TabIndex = 11;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 237);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(104, 45);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(122, 237);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(49, 45);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(177, 135);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(49, 45);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(232, 135);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(49, 45);
            this.multiply.TabIndex = 17;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // displayBottom
            // 
            this.displayBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBottom.BackColor = System.Drawing.Color.White;
            this.displayBottom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBottom.Location = new System.Drawing.Point(12, 33);
            this.displayBottom.Name = "displayBottom";
            this.displayBottom.Size = new System.Drawing.Size(267, 36);
            this.displayBottom.TabIndex = 18;
            this.displayBottom.Text = "0";
            this.displayBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayTop
            // 
            this.displayTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayTop.BackColor = System.Drawing.Color.White;
            this.displayTop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTop.Location = new System.Drawing.Point(12, 15);
            this.displayTop.Name = "displayTop";
            this.displayTop.Size = new System.Drawing.Size(267, 25);
            this.displayTop.TabIndex = 19;
            this.displayTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.displayTop.Text = "";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(177, 84);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(49, 45);
            this.delete.TabIndex = 20;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(232, 84);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(49, 45);
            this.clear.TabIndex = 21;
            this.clear.Text = "C";
            this.clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(177, 237);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(49, 45);
            this.add.TabIndex = 22;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(177, 186);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(49, 45);
            this.subtract.TabIndex = 23;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 296);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.displayTop);
            this.Controls.Add(this.displayBottom);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.seven);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }
              

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Label displayBottom;
        private System.Windows.Forms.Label displayTop;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
    }
}

