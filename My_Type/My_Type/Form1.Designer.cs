namespace My_Type
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
            textFirstNum = new TextBox();
            textFirstDenum = new TextBox();
            comboBox1 = new ComboBox();
            textSecondDenum = new TextBox();
            textSecondNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textResultDenum = new TextBox();
            textResultNum = new TextBox();
            textFinResDenum = new TextBox();
            textFinResNum = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textFirstNum
            // 
            textFirstNum.Location = new Point(12, 12);
            textFirstNum.Name = "textFirstNum";
            textFirstNum.Size = new Size(50, 23);
            textFirstNum.TabIndex = 0;
            textFirstNum.TextChanged += textFirstNum_TextChanged;
            // 
            // textFirstDenum
            // 
            textFirstDenum.Location = new Point(12, 41);
            textFirstDenum.Name = "textFirstDenum";
            textFirstDenum.Size = new Size(50, 23);
            textFirstDenum.TabIndex = 1;
            textFirstDenum.TextChanged += textFirstDenum_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/", ">", "<", "=", "==" });
            comboBox1.Location = new Point(68, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(50, 23);
            comboBox1.TabIndex = 2;
            // 
            // textSecondDenum
            // 
            textSecondDenum.Location = new Point(124, 41);
            textSecondDenum.Name = "textSecondDenum";
            textSecondDenum.Size = new Size(50, 23);
            textSecondDenum.TabIndex = 4;
            textSecondDenum.TextChanged += textSecondDenum_TextChanged;
            // 
            // textSecondNum
            // 
            textSecondNum.Location = new Point(124, 12);
            textSecondNum.Name = "textSecondNum";
            textSecondNum.Size = new Size(50, 23);
            textSecondNum.TabIndex = 3;
            textSecondNum.TextChanged += textSecondNum_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 5;
            label1.Text = "Ответ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(182, 19);
            label2.Name = "label2";
            label2.Size = new Size(28, 30);
            label2.TabIndex = 6;
            label2.Text = "=";
            // 
            // textResultDenum
            // 
            textResultDenum.Location = new Point(214, 41);
            textResultDenum.Name = "textResultDenum";
            textResultDenum.Size = new Size(50, 23);
            textResultDenum.TabIndex = 8;
            // 
            // textResultNum
            // 
            textResultNum.Location = new Point(214, 12);
            textResultNum.Name = "textResultNum";
            textResultNum.Size = new Size(50, 23);
            textResultNum.TabIndex = 7;
            // 
            // textFinResDenum
            // 
            textFinResDenum.Location = new Point(12, 120);
            textFinResDenum.Name = "textFinResDenum";
            textFinResDenum.Size = new Size(50, 23);
            textFinResDenum.TabIndex = 10;
            // 
            // textFinResNum
            // 
            textFinResNum.Location = new Point(12, 91);
            textFinResNum.Name = "textFinResNum";
            textFinResNum.Size = new Size(50, 23);
            textFinResNum.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 12);
            label3.Name = "label3";
            label3.Size = new Size(135, 120);
            label3.TabIndex = 11;
            label3.Text = "\"+\" - сложение\r\n\"-\" - вычитание\r\n\"*\" - умножение\r\n\"/\" - деление\r\n\">\" - больше\r\n\"<\" - меньше\r\n\"=\" - равно\r\n\"==\" - сократить дробь";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 154);
            Controls.Add(label3);
            Controls.Add(textFinResDenum);
            Controls.Add(textFinResNum);
            Controls.Add(textResultDenum);
            Controls.Add(textResultNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSecondDenum);
            Controls.Add(textSecondNum);
            Controls.Add(comboBox1);
            Controls.Add(textFirstDenum);
            Controls.Add(textFirstNum);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFirstNum;
        private TextBox textFirstDenum;
        private ComboBox comboBox1;
        private TextBox textSecondDenum;
        private TextBox textSecondNum;
        private Label label1;
        private Label label2;
        private TextBox textResultDenum;
        private TextBox textResultNum;
        private TextBox textFinResDenum;
        private TextBox textFinResNum;
        private Label label3;
    }
}
