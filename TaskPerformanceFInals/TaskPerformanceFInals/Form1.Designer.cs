
namespace TaskPerformanceFInals
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
            label1 = new Label();
            button1 = new Button();
            StudentIdBox = new TextBox();
            FirstNameBox = new TextBox();
            LastNameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AgeBox = new TextBox();
            label5 = new Label();
            AddressName = new TextBox();
            label6 = new Label();
            StudentDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 33);
            label1.TabIndex = 0;
            label1.Text = "StudentDetails";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(138, 50);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StudentIdBox
            // 
            StudentIdBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentIdBox.Location = new Point(136, 93);
            StudentIdBox.Name = "StudentIdBox";
            StudentIdBox.Size = new Size(211, 34);
            StudentIdBox.TabIndex = 2;
            StudentIdBox.TextChanged += StudentIdBox_TextChanged;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameBox.Location = new Point(136, 133);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(211, 34);
            FirstNameBox.TabIndex = 3;
            FirstNameBox.TextChanged += FirstNameBox_TextChanged;
            // 
            // LastNameBox
            // 
            LastNameBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameBox.Location = new Point(556, 133);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(211, 34);
            LastNameBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(118, 26);
            label2.TabIndex = 5;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(116, 26);
            label3.TabIndex = 6;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(439, 136);
            label4.Name = "label4";
            label4.Size = new Size(111, 26);
            label4.TabIndex = 7;
            label4.Text = "Last Name:";
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeBox.Location = new Point(556, 93);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(103, 34);
            AgeBox.TabIndex = 8;
            AgeBox.TextChanged += AgeBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(439, 97);
            label5.Name = "label5";
            label5.Size = new Size(51, 26);
            label5.TabIndex = 9;
            label5.Text = "Age:";
            // 
            // AddressName
            // 
            AddressName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressName.Location = new Point(108, 220);
            AddressName.Name = "AddressName";
            AddressName.Size = new Size(659, 34);
            AddressName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(90, 26);
            label6.TabIndex = 11;
            label6.Text = "Address:";
            // 
            // StudentDataGridView
            // 
            StudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGridView.Location = new Point(171, 285);
            StudentDataGridView.Name = "StudentDataGridView";
            StudentDataGridView.Size = new Size(596, 216);
            StudentDataGridView.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(StudentDataGridView);
            Controls.Add(label6);
            Controls.Add(AddressName);
            Controls.Add(label5);
            Controls.Add(AgeBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LastNameBox);
            Controls.Add(FirstNameBox);
            Controls.Add(StudentIdBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void StudentIdBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox StudentIdBox;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AgeBox;
        private Label label5;
        private TextBox AddressName;
        private Label label6;
        private DataGridView StudentDataGridView;
    }
}
