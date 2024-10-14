namespace EmployeeApplication
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
            this.Fbox = new System.Windows.Forms.TextBox();
            this.Lbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Jbox = new System.Windows.Forms.TextBox();
            this.DEPTbox = new System.Windows.Forms.TextBox();
            this.RPHbox = new System.Windows.Forms.TextBox();
            this.THWbox = new System.Windows.Forms.TextBox();
            this.ComputeSalaryLabel = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fbox
            // 
            this.Fbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fbox.Location = new System.Drawing.Point(12, 42);
            this.Fbox.Name = "Fbox";
            this.Fbox.Size = new System.Drawing.Size(297, 29);
            this.Fbox.TabIndex = 0;
            // 
            // Lbox
            // 
            this.Lbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbox.Location = new System.Drawing.Point(315, 42);
            this.Lbox.Name = "Lbox";
            this.Lbox.Size = new System.Drawing.Size(282, 29);
            this.Lbox.TabIndex = 1;
            this.Lbox.TextChanged += new System.EventHandler(this.Lbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Job Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rate Per Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Hours Worked";
            // 
            // Jbox
            // 
            this.Jbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jbox.Location = new System.Drawing.Point(315, 123);
            this.Jbox.Name = "Jbox";
            this.Jbox.Size = new System.Drawing.Size(282, 29);
            this.Jbox.TabIndex = 8;
            this.Jbox.TextChanged += new System.EventHandler(this.Jbox_TextChanged);
            // 
            // DEPTbox
            // 
            this.DEPTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEPTbox.Location = new System.Drawing.Point(12, 123);
            this.DEPTbox.Name = "DEPTbox";
            this.DEPTbox.Size = new System.Drawing.Size(297, 29);
            this.DEPTbox.TabIndex = 9;
            this.DEPTbox.TextChanged += new System.EventHandler(this.DEPTbox_TextChanged);
            // 
            // RPHbox
            // 
            this.RPHbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPHbox.Location = new System.Drawing.Point(12, 219);
            this.RPHbox.Name = "RPHbox";
            this.RPHbox.Size = new System.Drawing.Size(297, 29);
            this.RPHbox.TabIndex = 10;
            this.RPHbox.TextChanged += new System.EventHandler(this.RPHbox_TextChanged);
            // 
            // THWbox
            // 
            this.THWbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THWbox.Location = new System.Drawing.Point(315, 219);
            this.THWbox.Name = "THWbox";
            this.THWbox.Size = new System.Drawing.Size(282, 29);
            this.THWbox.TabIndex = 11;
            this.THWbox.TextChanged += new System.EventHandler(this.THWbox_TextChanged);
            // 
            // ComputeSalaryLabel
            // 
            this.ComputeSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeSalaryLabel.Location = new System.Drawing.Point(218, 270);
            this.ComputeSalaryLabel.Name = "ComputeSalaryLabel";
            this.ComputeSalaryLabel.Size = new System.Drawing.Size(192, 38);
            this.ComputeSalaryLabel.TabIndex = 12;
            this.ComputeSalaryLabel.Text = "Compute Salary";
            this.ComputeSalaryLabel.UseVisualStyleBackColor = true;
            this.ComputeSalaryLabel.Click += new System.EventHandler(this.ComputeSalaryLabel_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 332);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(213, 24);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "First Name: <first name>";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 386);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(211, 24);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last Name: <last name>";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLabel.Location = new System.Drawing.Point(12, 433);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(178, 24);
            this.SalaryLabel.TabIndex = 15;
            this.SalaryLabel.Text = "Basic Salary: <0.00>";
            this.SalaryLabel.Click += new System.EventHandler(this.SalaryLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 466);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.ComputeSalaryLabel);
            this.Controls.Add(this.THWbox);
            this.Controls.Add(this.RPHbox);
            this.Controls.Add(this.DEPTbox);
            this.Controls.Add(this.Jbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbox);
            this.Controls.Add(this.Fbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fbox;
        private System.Windows.Forms.TextBox Lbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Jbox;
        private System.Windows.Forms.TextBox DEPTbox;
        private System.Windows.Forms.TextBox RPHbox;
        private System.Windows.Forms.TextBox THWbox;
        private System.Windows.Forms.Button ComputeSalaryLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SalaryLabel;
    }
}

