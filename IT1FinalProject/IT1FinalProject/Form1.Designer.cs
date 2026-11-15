namespace MouseDoubleClickChecker
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
            lblTitle = new Label();
            lblCount = new Label();
            lblTime = new Label();
            lblResult = new Label();
            pnlClickArea = new Panel();
            btnReset = new Button();
            lblClickCount = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(235, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mouse Double Click Tester";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 15F);
            lblCount.Location = new Point(300, 94);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(189, 28);
            lblCount.TabIndex = 1;
            lblCount.Text = "Double Click Count: ";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.Location = new Point(317, 135);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(121, 19);
            lblTime.TabIndex = 2;
            lblTime.Text = "Double Click Time:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15F);
            lblResult.Location = new Point(280, 290);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 3;
            lblResult.TextAlign = ContentAlignment.TopCenter;
            lblResult.Click += lblResult_Click;
            // 
            // pnlClickArea
            // 
            pnlClickArea.BackColor = SystemColors.ActiveCaption;
            pnlClickArea.Location = new Point(330, 187);
            pnlClickArea.Name = "pnlClickArea";
            pnlClickArea.Size = new Size(119, 51);
            pnlClickArea.TabIndex = 4;
            pnlClickArea.MouseDoubleClick += pnlClickArea_MouseDoubleClick;
            pnlClickArea.MouseDown += pnlClickArea_MouseDown;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 401);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 37);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset Counter";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblClickCount
            // 
            lblClickCount.AutoSize = true;
            lblClickCount.Font = new Font("Segoe UI", 12F);
            lblClickCount.Location = new Point(330, 241);
            lblClickCount.Name = "lblClickCount";
            lblClickCount.Size = new Size(106, 21);
            lblClickCount.TabIndex = 7;
            lblClickCount.Text = "Click Counter:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblClickCount);
            Controls.Add(btnReset);
            Controls.Add(pnlClickArea);
            Controls.Add(lblResult);
            Controls.Add(lblTime);
            Controls.Add(lblCount);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCount;
        private Label lblTime;
        private Label lblResult;
        private Panel pnlClickArea;
        private Button btnReset;
        private Label lblClickCount;
    }
}
