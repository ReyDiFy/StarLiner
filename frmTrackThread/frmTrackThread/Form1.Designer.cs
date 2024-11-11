namespace frmTrackThread
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
            threadStateLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // threadStateLabel
            // 
            threadStateLabel.AutoSize = true;
            threadStateLabel.Font = new Font("Comic Sans MS", 20F);
            threadStateLabel.Location = new Point(188, 102);
            threadStateLabel.Name = "threadStateLabel";
            threadStateLabel.Size = new Size(270, 38);
            threadStateLabel.TabIndex = 0;
            threadStateLabel.Text = "-Thread Unstarted-";
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(252, 243);
            button1.Name = "button1";
            button1.Size = new Size(133, 41);
            button1.TabIndex = 1;
            button1.Text = "RUN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(button1);
            Controls.Add(threadStateLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label threadStateLabel;
        private Button button1;
    }
}
