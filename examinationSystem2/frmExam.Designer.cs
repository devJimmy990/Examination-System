namespace ITIExamination
{
    partial class frmExam
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
            components = new System.ComponentModel.Container();
            lblQues = new Label();
            RbtnA = new RadioButton();
            RbtnB = new RadioButton();
            RbtnD = new RadioButton();
            RbtnC = new RadioButton();
            BtnNext = new Button();
            BtnPrev = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            SuspendLayout();
            // 
            // lblQues
            // 
            lblQues.AllowDrop = true;
            lblQues.Anchor = AnchorStyles.None;
            lblQues.AutoSize = true;
            lblQues.BackColor = Color.White;
            lblQues.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQues.Location = new Point(18, 61);
            lblQues.Margin = new Padding(2, 0, 2, 0);
            lblQues.MaximumSize = new Size(1000, 0);
            lblQues.Name = "lblQues";
            lblQues.Padding = new Padding(4, 16, 4, 16);
            lblQues.Size = new Size(40, 70);
            lblQues.TabIndex = 0;
            lblQues.Text = "1";
            // 
            // RbtnA
            // 
            RbtnA.AccessibleName = "a";
            RbtnA.Anchor = AnchorStyles.None;
            RbtnA.AutoSize = true;
            RbtnA.BackColor = Color.White;
            RbtnA.Font = new Font("Segoe UI", 13.8F);
            RbtnA.Location = new Point(58, 205);
            RbtnA.Margin = new Padding(2);
            RbtnA.Name = "RbtnA";
            RbtnA.Size = new Size(140, 35);
            RbtnA.TabIndex = 1;
            RbtnA.TabStop = true;
            RbtnA.Text = "Choice - A";
            RbtnA.UseVisualStyleBackColor = false;
            // 
            // RbtnB
            // 
            RbtnB.Anchor = AnchorStyles.None;
            RbtnB.AutoSize = true;
            RbtnB.BackColor = Color.White;
            RbtnB.Font = new Font("Segoe UI", 13.8F);
            RbtnB.Location = new Point(58, 241);
            RbtnB.Margin = new Padding(2);
            RbtnB.Name = "RbtnB";
            RbtnB.Size = new Size(138, 35);
            RbtnB.TabIndex = 2;
            RbtnB.TabStop = true;
            RbtnB.Text = "Choice - B";
            RbtnB.UseVisualStyleBackColor = false;
            // 
            // RbtnD
            // 
            RbtnD.Anchor = AnchorStyles.None;
            RbtnD.AutoSize = true;
            RbtnD.BackColor = Color.White;
            RbtnD.Font = new Font("Segoe UI", 13.8F);
            RbtnD.Location = new Point(56, 319);
            RbtnD.Margin = new Padding(2);
            RbtnD.Name = "RbtnD";
            RbtnD.Size = new Size(141, 35);
            RbtnD.TabIndex = 4;
            RbtnD.TabStop = true;
            RbtnD.Text = "Choice - D";
            RbtnD.UseVisualStyleBackColor = false;
            // 
            // RbtnC
            // 
            RbtnC.Anchor = AnchorStyles.None;
            RbtnC.AutoSize = true;
            RbtnC.BackColor = Color.White;
            RbtnC.Font = new Font("Segoe UI", 13.8F);
            RbtnC.Location = new Point(57, 280);
            RbtnC.Margin = new Padding(2);
            RbtnC.Name = "RbtnC";
            RbtnC.Size = new Size(139, 35);
            RbtnC.TabIndex = 3;
            RbtnC.TabStop = true;
            RbtnC.Text = "Choice - C";
            RbtnC.UseVisualStyleBackColor = false;
            // 
            // BtnNext
            // 
            BtnNext.Anchor = AnchorStyles.None;
            BtnNext.BackColor = Color.Salmon;
            BtnNext.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNext.ForeColor = Color.White;
            BtnNext.Location = new Point(680, 389);
            BtnNext.Margin = new Padding(2);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(179, 62);
            BtnNext.TabIndex = 5;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrev
            // 
            BtnPrev.Anchor = AnchorStyles.None;
            BtnPrev.BackColor = Color.Salmon;
            BtnPrev.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPrev.ForeColor = Color.White;
            BtnPrev.Location = new Point(96, 388);
            BtnPrev.Margin = new Padding(2);
            BtnPrev.Name = "BtnPrev";
            BtnPrev.Size = new Size(179, 63);
            BtnPrev.TabIndex = 6;
            BtnPrev.Text = "Previous";
            BtnPrev.UseVisualStyleBackColor = false;
            BtnPrev.Click += BtnPrev_Click;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.None;
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.White;
            lblTimer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(820, 35);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(96, 38);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "label1";
            // 
            // frmExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1031, 711);
            Controls.Add(lblTimer);
            Controls.Add(BtnPrev);
            Controls.Add(BtnNext);
            Controls.Add(RbtnD);
            Controls.Add(RbtnC);
            Controls.Add(RbtnB);
            Controls.Add(RbtnA);
            Controls.Add(lblQues);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MinimumSize = new Size(1049, 758);
            Name = "frmExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choice - A";
            TopMost = true;
            Load += frmExam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQues;
        private RadioButton RbtnA;
        private RadioButton RbtnB;
        private RadioButton RbtnD;
        private RadioButton RbtnC;
        private Button BtnNext;
        private Button BtnPrev;
        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
    }
}