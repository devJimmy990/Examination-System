namespace examinationSystem2
{
    partial class Coursesfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coursesfrm));
            label2 = new Label();
            comboCourses = new ComboBox();
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 240);
            label2.Name = "label2";
            label2.Size = new Size(87, 31);
            label2.TabIndex = 1;
            label2.Text = "Course";
            // 
            // comboCourses
            // 
            comboCourses.Anchor = AnchorStyles.None;
            comboCourses.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(210, 240);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(191, 39);
            comboCourses.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.BackColor = Color.Salmon;
            btnStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(128, 410);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(227, 55);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Exam";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(574, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 571);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Coursesfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 711);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnStart);
            Controls.Add(comboCourses);
            Controls.Add(label2);
            MinimumSize = new Size(1049, 758);
            Name = "Coursesfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coursesfrm";
            Load += Coursesfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox comboCourses;
        private Button btnStart;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}