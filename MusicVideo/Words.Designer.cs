namespace MusicVideo
{
    partial class Words
    {

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Words));
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayTime = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.volumnBar = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.volumn = new System.Windows.Forms.PictureBox();
            this.FrontSong = new System.Windows.Forms.PictureBox();
            this.NextSong = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.singerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.displayTime);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.volumnBar);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.volumn);
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // displayTime
            // 
            this.displayTime.AutoSize = true;
            this.displayTime.Font = new System.Drawing.Font("宋体", 12F);
            this.displayTime.Location = new System.Drawing.Point(732, 46);
            this.displayTime.Name = "displayTime";
            this.displayTime.Size = new System.Drawing.Size(70, 24);
            this.displayTime.TabIndex = 12;
            this.displayTime.Text = "00:00";
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
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1150, 29);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 44);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
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
            this.Play.Click += new System.EventHandler(this.Play_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 405);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.Location = new System.Drawing.Point(43, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "听友评论";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox1.Location = new System.Drawing.Point(50, 540);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 50);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "发表评论...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label2.Location = new System.Drawing.Point(727, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 52);
            this.label2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Load += new System.EventHandler(this.Words_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Words_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TrackBar volumnBar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox volumn;
        private System.Windows.Forms.PictureBox FrontSong;
        private System.Windows.Forms.PictureBox NextSong;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.Label singerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label displayTime;
        private System.Windows.Forms.Timer timer1;
    }
}