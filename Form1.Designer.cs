namespace space_shooter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            downMoveTimer = new System.Windows.Forms.Timer(components);
            leftMoveTimer = new System.Windows.Forms.Timer(components);
            rightMoveTimer = new System.Windows.Forms.Timer(components);
            upMoveTimer = new System.Windows.Forms.Timer(components);
            MoveBgTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            starsTimer = new System.Windows.Forms.Timer(components);
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelScore = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // downMoveTimer
            // 
            downMoveTimer.Interval = 20;
            downMoveTimer.Tick += downMoveTimer_Tick;
            // 
            // leftMoveTimer
            // 
            leftMoveTimer.Interval = 20;
            leftMoveTimer.Tick += leftMoveTimer_Tick;
            // 
            // rightMoveTimer
            // 
            rightMoveTimer.Interval = 20;
            rightMoveTimer.Tick += rightMoveTimer_Tick;
            // 
            // upMoveTimer
            // 
            upMoveTimer.Interval = 20;
            upMoveTimer.Tick += upMoveTimer_Tick;
            // 
            // MoveBgTimer
            // 
            MoveBgTimer.Interval = 20;
            MoveBgTimer.Tick += MoveBgTimer_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // starsTimer
            // 
            starsTimer.Interval = 20;
            starsTimer.Tick += starsTimer_Tick;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = Properties.Resources.download__1_;
            enemy1.Location = new Point(450, 318);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(71, 55);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 1;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Transparent;
            enemy2.Image = Properties.Resources.download__1_;
            enemy2.Location = new Point(266, 195);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(88, 62);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 2;
            enemy2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.download__2_1;
            pictureBox2.Location = new Point(371, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(3, 3);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Microsoft Sans Serif", 12F);
            labelScore.ForeColor = Color.Snow;
            labelScore.Location = new Point(2, 19);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(86, 25);
            labelScore.TabIndex = 4;
            labelScore.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(582, 453);
            Controls.Add(labelScore);
            Controls.Add(pictureBox2);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximumSize = new Size(600, 500);
            Name = "Form1";
            Text = "space shooter";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer downMoveTimer;
        private System.Windows.Forms.Timer leftMoveTimer;
        private System.Windows.Forms.Timer rightMoveTimer;
        private System.Windows.Forms.Timer upMoveTimer;
        private System.Windows.Forms.Timer MoveBgTimer;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer starsTimer;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox pictureBox2;
        private Label labelScore;
    }
}
