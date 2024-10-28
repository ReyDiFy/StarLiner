namespace CalculatorApplication
{
    partial class FrmCalculator
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
            label1 = new Label();
            txtBoxInput1 = new TextBox();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            cbOperator1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            AnswerBox = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            label1.Click += label1_Click;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Calibri", 12F);
            txtBoxInput1.Location = new Point(170, 18);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(286, 27);
            txtBoxInput1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 2;
            label2.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Calibri", 12F);
            txtBoxInput2.Location = new Point(170, 129);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(286, 27);
            txtBoxInput2.TabIndex = 3;
            txtBoxInput2.TextChanged += textBox1_TextChanged;
            // 
            // cbOperator1
            // 
            cbOperator1.FormattingEnabled = true;
            cbOperator1.Location = new Point(253, 75);
            cbOperator1.Name = "cbOperator1";
            cbOperator1.Size = new Size(116, 23);
            cbOperator1.TabIndex = 4;
            cbOperator1.SelectedIndexChanged += cbOperator1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 5;
            label3.Text = "Answer:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 220);
            label4.Name = "label4";
            label4.Size = new Size(342, 15);
            label4.TabIndex = 6;
            label4.Text = "___________________________________________________________________";
            // 
            // AnswerBox
            // 
            AnswerBox.AutoSize = true;
            AnswerBox.Font = new Font("Calibri", 12F);
            AnswerBox.Location = new Point(79, 207);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(73, 19);
            AnswerBox.TabIndex = 7;
            AnswerBox.Text = "<Answer>";
            AnswerBox.Click += label5_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 12F);
            btnEqual.Location = new Point(170, 238);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(154, 23);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 272);
            Controls.Add(btnEqual);
            Controls.Add(AnswerBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbOperator1);
            Controls.Add(txtBoxInput2);
            Controls.Add(label2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxInput1;
        private Label label2;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator1;
        private Label label3;
        private Label label4;
        private Label AnswerBox;
        private Button btnEqual;
        private Button button1;
    }
}
