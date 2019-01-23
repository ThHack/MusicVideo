namespace MusicVideo
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PlayOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RandomPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.SinglePlay = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.volumnBar = new System.Windows.Forms.TrackBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.volumn = new System.Windows.Forms.PictureBox();
            this.allTime = new System.Windows.Forms.Label();
            this.nowTime = new System.Windows.Forms.Label();
            this.FrontSong = new System.Windows.Forms.PictureBox();
            this.NextSong = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.singerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.AddList = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SongsList = new System.Windows.Forms.ListBox();
            this.ListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteSongListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSongItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LyricWords = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.lyric_btn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.默认歌单 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Songs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new System.Windows.Forms.TrackBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.PlayOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddList)).BeginInit();
            this.panel6.SuspendLayout();
            this.ListItem.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 106);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox9
            // 
            this.pictureBox9.ContextMenuStrip = this.PlayOrder;
            this.pictureBox9.Image = global::MusicVideo.Properties.Resources.随机播放;
            this.pictureBox9.Location = new System.Drawing.Point(426, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // PlayOrder
            // 
            this.PlayOrder.BackColor = System.Drawing.Color.White;
            this.PlayOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PlayOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomPlay,
            this.SinglePlay,
            this.LoopPlay});
            this.PlayOrder.Name = "PlayOrder";
            this.PlayOrder.Size = new System.Drawing.Size(143, 82);
            // 
            // RandomPlay
            // 
            this.RandomPlay.BackColor = System.Drawing.Color.White;
            this.RandomPlay.Image = global::MusicVideo.Properties.Resources.随机播放;
            this.RandomPlay.Name = "RandomPlay";
            this.RandomPlay.Size = new System.Drawing.Size(142, 26);
            this.RandomPlay.Text = "随机播放";
            this.RandomPlay.Click += new System.EventHandler(this.RandomPlay_Click);
            // 
            // SinglePlay
            // 
            this.SinglePlay.BackColor = System.Drawing.Color.White;
            this.SinglePlay.Image = global::MusicVideo.Properties.Resources.单曲循环;
            this.SinglePlay.Name = "SinglePlay";
            this.SinglePlay.Size = new System.Drawing.Size(142, 26);
            this.SinglePlay.Text = "单曲循环";
            this.SinglePlay.Click += new System.EventHandler(this.SinglePlay_Click);
            // 
            // LoopPlay
            // 
            this.LoopPlay.BackColor = System.Drawing.Color.White;
            this.LoopPlay.Image = global::MusicVideo.Properties.Resources.列表循环;
            this.LoopPlay.Name = "LoopPlay";
            this.LoopPlay.Size = new System.Drawing.Size(142, 26);
            this.LoopPlay.Text = "列表循环";
            this.LoopPlay.Click += new System.EventHandler(this.LoopPlay_Click);
            // 
            // volumnBar
            // 
            this.volumnBar.Location = new System.Drawing.Point(725, 20);
            this.volumnBar.Maximum = 100;
            this.volumnBar.Name = "volumnBar";
            this.volumnBar.Size = new System.Drawing.Size(104, 56);
            this.volumnBar.TabIndex = 9;
            this.volumnBar.Value = 5;
            this.volumnBar.Visible = false;
            this.volumnBar.Scroll += new System.EventHandler(this.volumnBar_Scroll);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1026, 21);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(38, 23);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // volumn
            // 
            this.volumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumn.Image = global::MusicVideo.Properties.Resources.voice;
            this.volumn.Location = new System.Drawing.Point(674, 21);
            this.volumn.Name = "volumn";
            this.volumn.Size = new System.Drawing.Size(45, 45);
            this.volumn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volumn.TabIndex = 8;
            this.volumn.TabStop = false;
            this.volumn.Click += new System.EventHandler(this.volumn_Click);
            // 
            // allTime
            // 
            this.allTime.AutoSize = true;
            this.allTime.Location = new System.Drawing.Point(881, 21);
            this.allTime.Name = "allTime";
            this.allTime.Size = new System.Drawing.Size(55, 15);
            this.allTime.TabIndex = 7;
            this.allTime.Text = "/00:00";
            // 
            // nowTime
            // 
            this.nowTime.AutoSize = true;
            this.nowTime.Location = new System.Drawing.Point(839, 21);
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(47, 15);
            this.nowTime.TabIndex = 6;
            this.nowTime.Text = "00:00";
            // 
            // FrontSong
            // 
            this.FrontSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FrontSong.Image = global::MusicVideo.Properties.Resources.front;
            this.FrontSong.Location = new System.Drawing.Point(479, 21);
            this.FrontSong.Name = "FrontSong";
            this.FrontSong.Size = new System.Drawing.Size(45, 45);
            this.FrontSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FrontSong.TabIndex = 5;
            this.FrontSong.TabStop = false;
            this.FrontSong.Click += new System.EventHandler(this.FrontSong_Click);
            // 
            // NextSong
            // 
            this.NextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextSong.Image = global::MusicVideo.Properties.Resources.next;
            this.NextSong.Location = new System.Drawing.Point(613, 21);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(45, 45);
            this.NextSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextSong.TabIndex = 4;
            this.NextSong.TabStop = false;
            this.NextSong.Click += new System.EventHandler(this.NextSong_Click);
            // 
            // Play
            // 
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::MusicVideo.Properties.Resources.play;
            this.Play.Location = new System.Drawing.Point(533, 6);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(67, 68);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // singerLabel
            // 
            this.singerLabel.AutoSize = true;
            this.singerLabel.Location = new System.Drawing.Point(120, 38);
            this.singerLabel.Name = "singerLabel";
            this.singerLabel.Size = new System.Drawing.Size(107, 15);
            this.singerLabel.TabIndex = 2;
            this.singerLabel.Text = "银临/Aki 阿杰";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(120, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "牵丝戏";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MusicVideo.Properties.Resources.银临_牵丝戏_4;
            this.pictureBox3.Location = new System.Drawing.Point(29, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 498);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 437);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.AddList);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 44);
            this.panel10.TabIndex = 11;
            // 
            // AddList
            // 
            this.AddList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddList.Image = global::MusicVideo.Properties.Resources.AddListHoover;
            this.AddList.Location = new System.Drawing.Point(146, 3);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(51, 38);
            this.AddList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddList.TabIndex = 10;
            this.AddList.TabStop = false;
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "歌单列表";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.panel6.Controls.Add(this.SongsList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 47);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 390);
            this.panel6.TabIndex = 10;
            // 
            // SongsList
            // 
            this.SongsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.SongsList.ContextMenuStrip = this.ListItem;
            this.SongsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SongsList.FormattingEnabled = true;
            this.SongsList.ItemHeight = 30;
            this.SongsList.Location = new System.Drawing.Point(0, 0);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(200, 390);
            this.SongsList.TabIndex = 0;
            this.SongsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SongsList_DrawItem);
            // 
            // ListItem
            // 
            this.ListItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteSongListItem,
            this.AddSongItem,
            this.RenameItem});
            this.ListItem.Name = "SongList";
            this.ListItem.Size = new System.Drawing.Size(143, 82);
            // 
            // DeleteSongListItem
            // 
            this.DeleteSongListItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DeleteSongListItem.Image = global::MusicVideo.Properties.Resources.删除hoover;
            this.DeleteSongListItem.Name = "DeleteSongListItem";
            this.DeleteSongListItem.Size = new System.Drawing.Size(142, 26);
            this.DeleteSongListItem.Text = "删除歌单";
            this.DeleteSongListItem.Click += new System.EventHandler(this.DeleteSongListItem_Click);
            // 
            // AddSongItem
            // 
            this.AddSongItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddSongItem.Image = global::MusicVideo.Properties.Resources.AddListHoover;
            this.AddSongItem.Name = "AddSongItem";
            this.AddSongItem.Size = new System.Drawing.Size(142, 26);
            this.AddSongItem.Text = "本地歌曲";
            this.AddSongItem.Click += new System.EventHandler(this.AddSongItem_Click);
            // 
            // RenameItem
            // 
            this.RenameItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RenameItem.Name = "RenameItem";
            this.RenameItem.Size = new System.Drawing.Size(142, 26);
            this.RenameItem.Text = "重命名";
            this.RenameItem.Click += new System.EventHandler(this.RenameItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 61);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "衍射";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicVideo.Properties.Resources.衍射1;
            this.pictureBox1.Location = new System.Drawing.Point(29, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(200, 57);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 441);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(882, 57);
            this.panel4.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox8);
            this.panel11.Controls.Add(this.SearchBox);
            this.panel11.Location = new System.Drawing.Point(572, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(298, 32);
            this.panel11.TabIndex = 2;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::MusicVideo.Properties.Resources.search;
            this.pictureBox8.Location = new System.Drawing.Point(254, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBox.ForeColor = System.Drawing.Color.Gray;
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(236, 27);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.Text = "请输入要搜索的关键字";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.panel7.Controls.Add(this.LyricWords);
            this.panel7.Controls.Add(this.button11);
            this.panel7.Controls.Add(this.lyric_btn);
            this.panel7.Controls.Add(this.button9);
            this.panel7.Controls.Add(this.默认歌单);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.Songs);
            this.panel7.Location = new System.Drawing.Point(224, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(858, 441);
            this.panel7.TabIndex = 3;
            // 
            // LyricWords
            // 
            this.LyricWords.AutoSize = true;
            this.LyricWords.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LyricWords.Location = new System.Drawing.Point(306, 367);
            this.LyricWords.Name = "LyricWords";
            this.LyricWords.Size = new System.Drawing.Size(0, 40);
            this.LyricWords.TabIndex = 6;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Image = global::MusicVideo.Properties.Resources.add;
            this.button11.Location = new System.Drawing.Point(488, 94);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(151, 36);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // lyric_btn
            // 
            this.lyric_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lyric_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lyric_btn.Image = global::MusicVideo.Properties.Resources.歌词;
            this.lyric_btn.Location = new System.Drawing.Point(340, 94);
            this.lyric_btn.Name = "lyric_btn";
            this.lyric_btn.Size = new System.Drawing.Size(142, 36);
            this.lyric_btn.TabIndex = 4;
            this.lyric_btn.UseVisualStyleBackColor = false;
            this.lyric_btn.Click += new System.EventHandler(this.lyric_btn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Image = global::MusicVideo.Properties.Resources.addLove;
            this.button9.Location = new System.Drawing.Point(192, 94);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 36);
            this.button9.TabIndex = 3;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // 默认歌单
            // 
            this.默认歌单.AutoSize = true;
            this.默认歌单.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.默认歌单.Location = new System.Drawing.Point(170, 7);
            this.默认歌单.Name = "默认歌单";
            this.默认歌单.Size = new System.Drawing.Size(115, 33);
            this.默认歌单.TabIndex = 2;
            this.默认歌单.Text = "默认歌单";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::MusicVideo.Properties.Resources.log;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Songs
            // 
            this.Songs.AutoArrange = false;
            this.Songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(213)))));
            this.Songs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Songs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Songs.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Songs.ForeColor = System.Drawing.Color.Gray;
            this.Songs.Location = new System.Drawing.Point(0, 147);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(858, 294);
            this.Songs.TabIndex = 0;
            this.Songs.UseCompatibleStateImageBehavior = false;
            this.Songs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲";
            this.columnHeader1.Width = 459;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专辑";
            this.columnHeader3.Width = 130;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "D:\\Administrator\\Music";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(0, 499);
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1082, 35);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Scroll += new System.EventHandler(this.ProgressBar_Scroll);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 640);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "音乐播放器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.PlayOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumnBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ListItem.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button lyric_btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label 默认歌单;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label singerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label allTime;
        private System.Windows.Forms.Label nowTime;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ContextMenuStrip ListItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteSongListItem;
        private System.Windows.Forms.ToolStripMenuItem AddSongItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox AddList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox SongsList;
        private System.Windows.Forms.ToolStripMenuItem RenameItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox volumn;
        private System.Windows.Forms.PictureBox FrontSong;
        private System.Windows.Forms.PictureBox NextSong;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar volumnBar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ContextMenuStrip PlayOrder;
        private System.Windows.Forms.ToolStripMenuItem RandomPlay;
        private System.Windows.Forms.ToolStripMenuItem SinglePlay;
        private System.Windows.Forms.ToolStripMenuItem LoopPlay;
        private System.Windows.Forms.ListView Songs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar ProgressBar;
        private System.Windows.Forms.Label LyricWords;
        private System.Windows.Forms.Timer timer3;
    }
}