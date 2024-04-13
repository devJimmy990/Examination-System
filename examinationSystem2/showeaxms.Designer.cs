namespace examinationSystem2
{
    partial class showeaxms
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
            lblcrs = new Label();
            lblGrade = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // lblcrs
            // 
            lblcrs.AutoSize = true;
            lblcrs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcrs.ForeColor = Color.Black;
            lblcrs.Location = new Point(94, 33);
            lblcrs.Name = "lblcrs";
            lblcrs.Size = new Size(87, 28);
            lblcrs.TabIndex = 0;
            lblcrs.Text = "Course: ";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.Black;
            lblGrade.Location = new Point(94, 82);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(79, 28);
            lblGrade.TabIndex = 1;
            lblGrade.Text = "Grade: ";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.WhiteSmoke;
            btnShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(748, 56);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(136, 40);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show Exam";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // showeaxms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MistyRose;
            Controls.Add(btnShow);
            Controls.Add(lblGrade);
            Controls.Add(lblcrs);
            Name = "showeaxms";
            Size = new Size(1031, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcrs;
        private Label lblGrade;
        private Button btnShow;
    }
}
