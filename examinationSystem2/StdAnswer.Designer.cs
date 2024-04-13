namespace examinationSystem2
{
    partial class StdAnswer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            qus = new Label();
            stdans = new Label();
            modelans = new Label();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblD = new Label();
            SuspendLayout();
            // 
            // qus
            // 
            qus.AutoSize = true;
            qus.Font = new Font("Segoe UI", 12F);
            qus.Location = new Point(31, 36);
            qus.MaximumSize = new Size(980, 0);
            qus.Name = "qus";
            qus.Size = new Size(65, 28);
            qus.TabIndex = 0;
            qus.Text = "label1";
            // 
            // stdans
            // 
            stdans.AutoSize = true;
            stdans.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            stdans.Location = new Point(43, 262);
            stdans.Name = "stdans";
            stdans.Size = new Size(142, 28);
            stdans.TabIndex = 1;
            stdans.Text = "Your Answer: ";
            // 
            // modelans
            // 
            modelans.AutoSize = true;
            modelans.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            modelans.Location = new Point(478, 262);
            modelans.Name = "modelans";
            modelans.Size = new Size(160, 28);
            modelans.TabIndex = 2;
            modelans.Text = "Model Answer: ";
            modelans.Click += modelans_Click;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 12F);
            lblA.Location = new Point(43, 117);
            lblA.Name = "lblA";
            lblA.Size = new Size(65, 28);
            lblA.TabIndex = 3;
            lblA.Text = "label1";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Segoe UI", 12F);
            lblB.Location = new Point(43, 147);
            lblB.Name = "lblB";
            lblB.Size = new Size(65, 28);
            lblB.TabIndex = 4;
            lblB.Text = "label2";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Segoe UI", 12F);
            lblC.Location = new Point(43, 181);
            lblC.Name = "lblC";
            lblC.Size = new Size(65, 28);
            lblC.TabIndex = 5;
            lblC.Text = "label3";
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Segoe UI", 12F);
            lblD.Location = new Point(43, 216);
            lblD.Name = "lblD";
            lblD.Size = new Size(65, 28);
            lblD.TabIndex = 6;
            lblD.Text = "label4";
            // 
            // StdAnswer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(lblD);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(modelans);
            Controls.Add(stdans);
            Controls.Add(qus);
            Name = "StdAnswer";
            Size = new Size(1005, 304);
            Load += StdAnswer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label qus;
        private Label stdans;
        private Label modelans;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblD;
    }
}
