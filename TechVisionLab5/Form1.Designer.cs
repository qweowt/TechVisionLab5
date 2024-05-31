namespace TechVisionLab5
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
            pictureBox1 = new PictureBox();
            OpenOrEnableVideoBtn = new Button();
            EnableRb = new RadioButton();
            OpenVideoRb = new RadioButton();
            FrameTick = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            OpenImageRb = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 480);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // OpenOrEnableVideoBtn
            // 
            OpenOrEnableVideoBtn.Location = new Point(12, 12);
            OpenOrEnableVideoBtn.Name = "OpenOrEnableVideoBtn";
            OpenOrEnableVideoBtn.Size = new Size(108, 45);
            OpenOrEnableVideoBtn.TabIndex = 1;
            OpenOrEnableVideoBtn.Text = "Open/Enable video";
            OpenOrEnableVideoBtn.UseVisualStyleBackColor = true;
            OpenOrEnableVideoBtn.Click += OpenOrEnableVideoBtn_Click;
            // 
            // EnableRb
            // 
            EnableRb.AutoSize = true;
            EnableRb.Location = new Point(126, 6);
            EnableRb.Name = "EnableRb";
            EnableRb.Size = new Size(92, 19);
            EnableRb.TabIndex = 2;
            EnableRb.TabStop = true;
            EnableRb.Text = "Enable video";
            EnableRb.UseVisualStyleBackColor = true;
            EnableRb.CheckedChanged += EnableRb_CheckedChanged;
            // 
            // OpenVideoRb
            // 
            OpenVideoRb.AutoSize = true;
            OpenVideoRb.Location = new Point(126, 43);
            OpenVideoRb.Name = "OpenVideoRb";
            OpenVideoRb.Size = new Size(86, 19);
            OpenVideoRb.TabIndex = 3;
            OpenVideoRb.TabStop = true;
            OpenVideoRb.Text = "Open video";
            OpenVideoRb.UseVisualStyleBackColor = true;
            OpenVideoRb.CheckedChanged += OpenVideoRb_CheckedChanged;
            // 
            // FrameTick
            // 
            FrameTick.Interval = 33;
            FrameTick.Tick += FrameTick_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenImageRb
            // 
            OpenImageRb.AutoSize = true;
            OpenImageRb.Location = new Point(126, 25);
            OpenImageRb.Name = "OpenImageRb";
            OpenImageRb.Size = new Size(90, 19);
            OpenImageRb.TabIndex = 4;
            OpenImageRb.TabStop = true;
            OpenImageRb.Text = "Open image";
            OpenImageRb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 555);
            Controls.Add(OpenImageRb);
            Controls.Add(OpenVideoRb);
            Controls.Add(EnableRb);
            Controls.Add(OpenOrEnableVideoBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button OpenOrEnableVideoBtn;
        private RadioButton EnableRb;
        private RadioButton OpenVideoRb;
        private System.Windows.Forms.Timer FrameTick;
        private OpenFileDialog openFileDialog1;
        private RadioButton OpenImageRb;
    }
}
