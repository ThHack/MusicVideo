namespace MusicVideo
{
    partial class Words
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Words));
            this.panel1 = new System.Windows.Forms.Panel();
            this.volumnBar = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.allTime = new System.Windows.Forms.Label();
            this.nowTime = new System.Windows.Forms.Label();
            this.singerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.volumn = new System.Windows.Forms.PictureBox();
            this.FrontSong = new System.Windows.Forms.PictureBox();
            this.NextSong = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.volumnBar);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.volumn);
            this.panel1.Controls.Add(this.allTime);
            this.panel1.Controls.Add(this.nowTime);
            this.panel1.Controls.Add(this.FrontSong);
            this.panel1.Controls.Add(this.NextSong);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.singerLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 673);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 95);
            this.panel1.TabIndex = 1;
            // 
            // volumnBar
            // 
            this.volumnBar.Location = new System.Drawing.Point(925, 41);
            this.volumnBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volumnBar.Maximum = 100;
            this.volumnBar.Name = "volumnBar";
            this.volumnBar.Size = new System.Drawing.Size(117, 69);
            this.volumnBar.TabIndex = 9;
            this.volumnBar.Value = 5;
            this.volumnBar.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1152, 46);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 23);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // allTime
            // 
            this.allTime.AutoSize = true;
            this.allTime.Location = new System.Drawing.Point(791, 46);
            this.allTime.Name = "allTime";
            this.allTime.Size = new System.Drawing.Size(62, 18);
            this.allTime.TabIndex = 7;
            this.allTime.Text = "/00:00";
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.Location = new System.Drawing.Point(732, 46);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(53, 18);
            this.nowTime.TabIndex = 6;
            this.nowTime.Text = "00:00";
            // 
            // singerLabel
            // 
            this.singerLabel.AutoSize = true;
            this.singerLabel.Location = new System.Drawing.Point(135, 46);
            this.singerLabel.Name = "singerLabel";
            this.singerLabel.Size = new System.Drawing.Size(0, 18);
            this.singerLabel.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(135, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 18);
            this.nameLabel.TabIndex = 1;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::MusicVideo.Properties.Resources.随机播放;
            this.pictureBox9.Location = new System.Drawing.Point(1048, 31);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 48);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // volumn
            // 
            this.volumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumn.Image = global::MusicVideo.Properties.Resources.voice;
            this.volumn.Location = new System.Drawing.Point(868, 28);
            this.volumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volumn.Name = "volumn";
            this.volumn.Size = new System.Drawing.Size(51, 54);
            this.volumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volumn.TabIndex = 8;
            this.volumn.TabStop = false;
            // 
            // FrontSong
            // 
            this.FrontSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrontSong.Image = global::MusicVideo.Properties.Resources.front;
            this.FrontSong.Location = new System.Drawing.Point(12, 25);
            this.FrontSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FrontSong.Name = "FrontSong";
            this.FrontSong.Size = new System.Drawing.Size(51, 54);
            this.FrontSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrontSong.TabIndex = 5;
            this.FrontSong.TabStop = false;
            // 
            // NextSong
            // 
            this.NextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextSong.Image = global::MusicVideo.Properties.Resources.next;
            this.NextSong.Location = new System.Drawing.Point(150, 29);
            this.NextSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(51, 54);
            this.NextSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextSong.TabIndex = 4;
            this.NextSong.TabStop = false;
            // 
            // Play
            // 
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::MusicVideo.Properties.Resources.play;
            this.Play.Location = new System.Drawing.Point(69, 9);
            this.Play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 82);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 451);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(224, 41);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(502, 69);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.Location = new System.Drawing.Point(43, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "听友评论";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox1.Location = new System.Drawing.Point(50, 590);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(624, 50);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "发表评论...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label2.Location = new System.Drawing.Point(829, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "珞珈的孩子";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1217, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Words";
            this.Text = "音乐播放器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TrackBar volumnBar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox volumn;
        private System.Windows.Forms.Label allTime;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.PictureBox FrontSong;
        private System.Windows.Forms.PictureBox NextSong;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.Label singerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}