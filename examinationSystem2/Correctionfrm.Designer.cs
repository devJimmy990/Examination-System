namespace examinationSystem2
{
    partial class Correctionfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correctionfrm));
            label1 = new Label();
            lblGrade = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 221);
            label1.Name = "label1";
            label1.Size = new Size(310, 72);
            label1.TabIndex = 0;
            label1.Text = "Your Grade";
            // 
            // lblGrade
            // 
            lblGrade.Anchor = AnchorStyles.None;
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(236, 352);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(45, 54);
            lblGrade.TabIndex = 1;
            lblGrade.Text = "0";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(743, 601);
            button1.Name = "button1";
            button1.Size = new Size(212, 62);
            button1.TabIndex = 2;
            button1.Text = "Go to Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(536, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 479);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Correctionfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 711);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lblGrade);
            Controls.Add(label1);
            MinimumSize = new Size(1049, 758);
            Name = "Correctionfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Correctionfrm";
            Load += Correctionfrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblGrade;
        private Button button1;
        private PictureBox pictureBox1;
    }
}