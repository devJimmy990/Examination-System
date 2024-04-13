namespace examinationSystem2
{
    partial class Choosefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choosefrm));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btn = new Button();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(49, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 463);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(173, 601);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 2;
            button1.Text = "New Exam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.None;
            btn.BackColor = Color.Salmon;
            btn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.White;
            btn.Location = new Point(662, 601);
            btn.Name = "btn";
            btn.Size = new Size(202, 51);
            btn.TabIndex = 3;
            btn.Text = "Your Grade";
            btn.UseVisualStyleBackColor = false;
            btn.Click += button2_Click;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(49, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(176, 46);
            lblName.TabIndex = 4;
            lblName.Text = "Welcome ";
            // 
            // Choosefrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 711);
            Controls.Add(lblName);
            Controls.Add(btn);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(1049, 758);
            Name = "Choosefrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choosefrm";
            Load += Choosefrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button btn;
        private Label lblName;
    }
}