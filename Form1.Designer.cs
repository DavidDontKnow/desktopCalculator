﻿namespace desktopCalculator
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button17 = new Button();
            button18 = new Button();
            button1 = new Button();
            button8 = new Button();
            result = new TextBox();
            button11 = new Button();
            button16 = new Button();
            previousValue = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(16, 149);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 1;
            button2.Text = "7";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(67, 149);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 2;
            button3.Text = "8";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(118, 149);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 3;
            button4.Text = "9";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(171, 200);
            button5.Name = "button5";
            button5.Size = new Size(45, 45);
            button5.TabIndex = 4;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += operator_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(67, 200);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(16, 200);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 6;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(118, 200);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 8;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(171, 251);
            button10.Name = "button10";
            button10.Size = new Size(45, 45);
            button10.TabIndex = 9;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += operator_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(16, 251);
            button12.Name = "button12";
            button12.Size = new Size(45, 45);
            button12.TabIndex = 11;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(67, 251);
            button13.Name = "button13";
            button13.Size = new Size(45, 45);
            button13.TabIndex = 12;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(118, 251);
            button14.Name = "button14";
            button14.Size = new Size(45, 45);
            button14.TabIndex = 13;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ButtonFace;
            button15.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(118, 302);
            button15.Name = "button15";
            button15.Size = new Size(45, 45);
            button15.TabIndex = 14;
            button15.Text = "=";
            button15.UseVisualStyleBackColor = false;
            button15.Click += preformOperation;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(67, 302);
            button17.Name = "button17";
            button17.Size = new Size(45, 45);
            button17.TabIndex = 16;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(16, 302);
            button18.Name = "button18";
            button18.Size = new Size(45, 45);
            button18.TabIndex = 17;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(171, 302);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 18;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += operator_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(169, 149);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 19;
            button8.Text = "÷";
            button8.UseVisualStyleBackColor = true;
            button8.Click += operator_Click;
            // 
            // result
            // 
            result.BackColor = SystemColors.AppWorkspace;
            result.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(18, 28);
            result.Name = "result";
            result.Size = new Size(200, 64);
            result.TabIndex = 20;
            result.Text = "0";
            result.TextAlign = HorizontalAlignment.Right;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(69, 98);
            button11.Name = "button11";
            button11.Size = new Size(147, 45);
            button11.TabIndex = 21;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = true;
            button11.Click += delete_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(16, 98);
            button16.Name = "button16";
            button16.Size = new Size(45, 45);
            button16.TabIndex = 22;
            button16.Text = "CLR";
            button16.UseVisualStyleBackColor = true;
            button16.Click += clearResult;
            // 
            // previousValue
            // 
            previousValue.BackColor = SystemColors.AppWorkspace;
            previousValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            previousValue.Location = new Point(18, 12);
            previousValue.Name = "previousValue";
            previousValue.Size = new Size(200, 29);
            previousValue.TabIndex = 23;
            previousValue.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(230, 357);
            Controls.Add(previousValue);
            Controls.Add(button16);
            Controls.Add(button11);
            Controls.Add(result);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button17;
        private Button button18;
        private Button button1;
        private Button button8;
        private TextBox result;
        private Button button11;
        private Button button16;
        internal TextBox previousValue;
        private TextBox previous;
    }
}