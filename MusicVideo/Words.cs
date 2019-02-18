using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicVideo
{
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        //歌曲文件
        List<String> songName = new List<string>();
        //歌词文件类
        LyricFiles lyricFiles = new LyricFiles();
        //歌词集合
        List<string> lyrics = new List<string>();
        int currentSong = 0;

        private void Words_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //加载歌曲到songName
            songName.Add("熊毅恒-珞珈的孩子");
            //加载歌曲到lyrics
            DirectoryInfo strLyricFile = new DirectoryInfo("lyric");
            for(int i = 0; i < songName.Count; i++)
            {
                string name = songName[i];
                foreach(FileInfo lyric in strLyricFile.GetFiles("*.lrc"))
                {
                    if(name == lyric.Name.Substring(0,lyric.Name.Length - 4))
                    {
                        lyrics.Add("lyric\\" + lyric.Name);
                        Console.WriteLine(lyric.Name);
                        break;
                    }
                }
                loadSong();
                label2.Text = songName[currentSong];
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        //暂停
        bool isPlay;

        //加载歌曲歌词
        public void loadSong()
        {
            axWindowsMediaPlayer1.URL = @"song\" + songName[currentSong] + ".mp3";
            isPlay = true;

            lyricFiles.listLyric.Clear();
            lyricFiles.LoadLyricFromFile(lyrics[currentSong]);
        }

        //绘制歌词
        Graphics g;
        int curLyricLine = 0;
        private void Words_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            int yStep = 30;
            int x = (int)(this.Width * 0.6);
            int y = 50;
            for(int i = 0;i<11; i++)
            {
                Point p = new Point(x, y);
                int line = i - 6 + curLyricLine;
                if(line >= 0 && line < lyricFiles.listLyric.Count)
                {
                    if (i == 5)
                        g.DrawString(lyricFiles.listLyric[line].strLyric, new Font("微软雅黑", 16), new LinearGradientBrush(new Rectangle(x, y, 300, 30), Color.Gray, Color.Gray, LinearGradientMode.Horizontal), p);
                    else if (i == 3 || i == 4 || i == 6 || i == 7)
                        g.DrawString(lyricFiles.listLyric[line].strLyric, new Font("微软雅黑", 13), new SolidBrush(Color.White), p);
                    else if (i == 2 || i == 8)
                        g.DrawString(lyricFiles.listLyric[line].strLyric, new Font("微软雅黑", 13), new SolidBrush(Color.FromArgb(200, 255, 255, 255)), p);
                    else if (i == 1 || i == 9)
                        g.DrawString(lyricFiles.listLyric[line].strLyric, new Font("微软雅黑", 13), new SolidBrush(Color.FromArgb(80, 255, 255, 255)), p);
                    else if (i == 0 || i == 10)
                        g.DrawString(lyricFiles.listLyric[line].strLyric, new Font("微软雅黑", 13), new SolidBrush(Color.FromArgb(20, 255, 255, 255)), p);
                }
                y += yStep;
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if(isPlay)
            {
                timer1.Enabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                Play.Image = Properties.Resources.pause;
                isPlay = false;
            }
            else
            {
                timer1.Enabled = false;
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                Play.Image = Properties.Resources.play;
                isPlay = true;
            }
        }

        double setRectX = 0;  //播放记录百分比

        private void timer1_Tick(object sender,EventArgs e)
        {
            displayTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString + "/" + axWindowsMediaPlayer1.currentMedia.durationString;
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition != 0)
                setRectX = axWindowsMediaPlayer1.Ctlcontrols.currentPosition / axWindowsMediaPlayer1.currentMedia.duration;
            panel1.Invalidate();
            //当前所唱歌词颜色大小变化
            double pos = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;//当前位置
            for (int i = 0; i < lyricFiles.listLyric.Count; i++)
            {
                if (pos <= lyricFiles.listLyric[i].totSecond)
                {
                    curLyricLine = i;
                    break;
                }
                else if (curLyricLine == lyricFiles.listLyric.Count - 2 && pos > lyricFiles.listLyric.Last().totSecond)
                {
                    curLyricLine = lyricFiles.listLyric.Count - 1;
                }
            }
            this.Refresh();
        }

        //绘制进度条
        Rectangle backRect;//进度条背景
        Rectangle foreRect;//进度
        Rectangle setRect;//滑块
        //ListBox CommentListBox;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //绘制进度条背景
            backRect = new Rectangle(150, 30, 400, 5);
            e.Graphics.FillRectangle(Brushes.LightGray, backRect);
            e.Graphics.DrawRectangle(Pens.LightGray, backRect);
            //进度
            foreRect = new Rectangle(150, 30, (int)(setRectX * 400), 5);
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, foreRect);
            e.Graphics.DrawRectangle(Pens.DeepSkyBlue, foreRect);
            //滑块
            setRect = new Rectangle((int)(setRectX * 400) + 150, 28, 8, 8);
            e.Graphics.FillRectangle(Brushes.White, setRect);
            e.Graphics.DrawRectangle(Pens.LightGray, setRect);
        }

        //解决Label闪屏
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        

        private void CommentButton_Click(object sender, EventArgs e)
        {
            string name = "风逝west";
            string time = DateTime.Now.ToString();
            string comment = this.CommentTextBox.Text.Trim().ToString();
            ListBox listBox = this.listBox1;
            listBox.Items.Add(name + " : " + comment);
            listBox.Items.Add(time);
        }
    }
}
