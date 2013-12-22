namespace BeeHive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_ShiftNumberBox = new System.Windows.Forms.NumericUpDown();
            this.m_AssignJobButton = new System.Windows.Forms.Button();
            this.m_JobComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_ReportTextBox = new System.Windows.Forms.TextBox();
            this.m_ShiftStartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ShiftNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_ShiftNumberBox);
            this.groupBox1.Controls.Add(this.m_AssignJobButton);
            this.groupBox1.Controls.Add(this.m_JobComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shifts";
            // 
            // m_ShiftNumberBox
            // 
            this.m_ShiftNumberBox.Location = new System.Drawing.Point(134, 33);
            this.m_ShiftNumberBox.Name = "m_ShiftNumberBox";
            this.m_ShiftNumberBox.Size = new System.Drawing.Size(60, 20);
            this.m_ShiftNumberBox.TabIndex = 3;
            this.m_ShiftNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m_ShiftNumberBox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // m_AssignJobButton
            // 
            this.m_AssignJobButton.Location = new System.Drawing.Point(7, 61);
            this.m_AssignJobButton.Name = "m_AssignJobButton";
            this.m_AssignJobButton.Size = new System.Drawing.Size(187, 33);
            this.m_AssignJobButton.TabIndex = 2;
            this.m_AssignJobButton.Text = "Assign to a Bee";
            this.m_AssignJobButton.UseVisualStyleBackColor = true;
            this.m_AssignJobButton.Click += new System.EventHandler(this.m_AssignJobButton_Click);
            // 
            // m_JobComboBox
            // 
            this.m_JobComboBox.FormattingEnabled = true;
            this.m_JobComboBox.Items.AddRange(new object[] {
            "Stinger patrol",
            "Nectar collector",
            "Hive maintenance",
            "Baby bee tutoring",
            "Honey manufacturing"});
            this.m_JobComboBox.Location = new System.Drawing.Point(7, 33);
            this.m_JobComboBox.Name = "m_JobComboBox";
            this.m_JobComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_JobComboBox.Size = new System.Drawing.Size(121, 21);
            this.m_JobComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Job";
            // 
            // m_ReportTextBox
            // 
            this.m_ReportTextBox.Location = new System.Drawing.Point(13, 120);
            this.m_ReportTextBox.Multiline = true;
            this.m_ReportTextBox.Name = "m_ReportTextBox";
            this.m_ReportTextBox.Size = new System.Drawing.Size(259, 130);
            this.m_ReportTextBox.TabIndex = 1;
            // 
            // m_ShiftStartButton
            // 
            this.m_ShiftStartButton.Location = new System.Drawing.Point(219, 19);
            this.m_ShiftStartButton.Name = "m_ShiftStartButton";
            this.m_ShiftStartButton.Size = new System.Drawing.Size(53, 94);
            this.m_ShiftStartButton.TabIndex = 2;
            this.m_ShiftStartButton.Text = "Start Shift";
            this.m_ShiftStartButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.m_ShiftStartButton);
            this.Controls.Add(this.m_ReportTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ShiftNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m_ShiftNumberBox;
        private System.Windows.Forms.Button m_AssignJobButton;
        private System.Windows.Forms.ComboBox m_JobComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_ReportTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_ShiftStartButton;
    }
}

