using MusicVideo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music;
using System.Drawing.Drawing2D;
using System.IO;

namespace MusicVideo
{
    public partial class MainWindow : Form
    {
        
        public List<Item> MenuList;//歌单控件链表
        public List<SongList> SongLists;//歌单链表
        int second;//当前播放秒数
        int allsecond;//一首歌的总时长
        int currentIndex;//当前播放的音乐在列表中的下标
        private string PlayMode = "随机播放";//播放状态
        private Random random = new Random();//设置随机数
        string[,] lrc = new string[2, 500];//保存歌词和当前进度

        public MainWindow()
        {
            InitializeComponent();
            
            MenuList = new List<Item>();
            SongLists = new List<SongList>();
            MenuList.Add(new Item(Resources.love, "我喜欢"));
            MenuList.Add(new Item(Resources.history, "历史记录"));
            MenuList.Add(new Item(Resources.list, "默认歌单"));
            SongsList.Items.Add("我喜欢");
            SongsList.Items.Add("历史记录");
            SongsList.Items.Add("默认歌单");
            SongLists.Add(new SongList("我喜欢"));
            SongLists.Add(new SongList("历史记录"));
            SongLists.Add(new SongList("默认歌单"));
            timer1.Start();
            timer2.Start();
        }


        #region 搜索框及其对应功能
        /// <summary>
        /// 鼠标点击搜索框，准备输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "请输入要搜索的关键字")
                SearchBox.Text = "";
        }

        /// <summary>
        /// 鼠标离开搜索框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
                SearchBox.Text = "请输入要搜索的关键字";
        }

        #endregion

        #region 歌单中的歌曲列表

        /// <summary>
        /// 绘制歌曲列表
        /// </summary>
        private void DrawSongs()
        {
            int index = SongsList.SelectedIndex;//获取被选中的歌单
            SongList songlist = SongLists[index];
            string[] info = new string[3];
            Songs.Items.Clear();
            Songs.BeginUpdate();            
            foreach (Song newsong in songlist.songList)
            {
                info[0] = newsong.SongName;//歌名
                info[1] = newsong.Singer;//歌手
                info[2] = newsong.Album;//专辑
                ListViewItem listViewItem = new ListViewItem(info);
                listViewItem.ForeColor = System.Drawing.Color.White;//字体设为白色
                Songs.Items.Add(listViewItem);
            }
            Songs.EndUpdate();
        }
        #endregion

        #region 歌单列表

        /// <summary>
        /// 绘制歌单列表各个歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">e即为要绘制的item</param>
        private void SongsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Bitmap bitmap = new Bitmap(e.Bounds.Width, e.Bounds.Height);

            int index = e.Index;                                //获取当前要进行绘制的行的序号，从0开始。
            Graphics g = e.Graphics;                            //获取Graphics对象。

            Graphics tempG = Graphics.FromImage(bitmap);

            tempG.SmoothingMode = SmoothingMode.AntiAlias;          //使绘图质量最高，即消除锯齿
            tempG.InterpolationMode = InterpolationMode.HighQualityBicubic;
            tempG.CompositingQuality = CompositingQuality.HighQuality;

            Rectangle bound = e.Bounds;                         //获取当前要绘制的行的一个矩形范围。
            string text = this.MenuList[index].Text.ToString();     //获取当前要绘制的行的显示文本。

            Color backgroundColor = Color.FromArgb(60, 160, 245);             //背景色
            Color guideTagColor = Color.FromArgb(183, 218, 114);            //高亮指示色
            Color selectedBackgroundColor = Color.FromArgb(35, 235, 185);     //选中背景色
            Color fontColor = Color.White;                                   //字体颜色
            Color selectedFontColor = Color.White;                          //选中字体颜色
            Font textFont = new Font("微软雅黑", 9, FontStyle.Bold);        //文字
            //图标
            Image itmeImage = this.MenuList[index].Img;
            //矩形大小
            Rectangle backgroundRect = new Rectangle(0, 0, bound.Width, bound.Height);
            Rectangle guideRect = new Rectangle(0, 4, 5, bound.Height - 8);
            Rectangle textRect = new Rectangle(55, 0, bound.Width, bound.Height);
            Rectangle imgRect = new Rectangle(20, 4, 25, bound.Height - 8);
            //当前选中行
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = selectedBackgroundColor;
                fontColor = selectedFontColor;
            }
            else
            {
                guideTagColor = backgroundColor;
            }
            //绘制背景色
            tempG.FillRectangle(new SolidBrush(backgroundColor), backgroundRect);
            //绘制左前高亮指示
            tempG.FillRectangle(new SolidBrush(guideTagColor), guideRect);
            //绘制显示文本
            TextRenderer.DrawText(tempG, text, textFont, textRect, fontColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            //绘制图标
            tempG.DrawImage(itmeImage, imgRect);
            g.DrawImage(bitmap, bound.X, bound.Y, bitmap.Width, bitmap.Height);
            tempG.Dispose();

        }

        /// <summary>
        /// 添加歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddList_Click(object sender, EventArgs e)
        {
            //添加新歌单控件
            MenuList.Add(new Item(Resources.list, "新建歌单"));
            SongsList.Items.Add("新建歌单");
            //添加新歌单
            SongList songList = new SongList("新建歌单");
            SongLists.Add(songList);
        }

        /// <summary>
        /// 重命名歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameItem_Click(object sender, EventArgs e)
        {
            int index = SongsList.SelectedIndex;//获取被选择的歌单的index
            if (index > 2)
            {
                string newName;
                RenameDialog Dialog = new RenameDialog(SongsList.SelectedItem.ToString());
                if (Dialog.ShowDialog() == DialogResult.OK)//弹出重命名对话框
                {
                    newName = Dialog.Result;//获得新名字
                    MenuList.RemoveAt(index);
                    SongsList.Items.RemoveAt(index);

                    MenuList.Insert(index,new Item(Resources.list, newName));
                    SongsList.Items.Insert(index,newName);
                    SongLists[index].listName = newName;
                }
            }
        }

        /// <summary>
        /// 删除歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSongListItem_Click(object sender, EventArgs e)
        {
            int index = SongsList.SelectedIndex;//获取被选择的歌单的index
            if (index > 2)
            {
                MenuList.RemoveAt(index);
                SongsList.Items.RemoveAt(index);
                SongLists.RemoveAt(index);
            }
            else
            {
                MessageBox.Show(@"“我喜欢”，“播放历史”，“默认歌单” 不能删除");
            }
        }

        /// <summary>
        /// 添加本地歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSongItem_Click(object sender, EventArgs e)
        {
            int index = SongsList.SelectedIndex;//被选中的歌单
            string ResultFile;
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ResultFile = openFileDialog1.FileName;//目标音乐文件地址                
                Song song = new Song(ResultFile);
                if (SongLists[index].songList.Contains(song))
                {
                    MessageBox.Show("不能重复添加相同歌曲！");
                    return;
                }
                SongLists[index].AddSong(song);//将音乐加入音乐列表
            }
            DrawSongs();
        }

        /// <summary>
        /// 选中的歌单发生改变，重新绘制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SongsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawSongs();
        }

        #endregion        

        #region 播放顺序
        /// <summary>
        /// 设置随机播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomPlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.随机播放;
            PlayMode = "随机播放";
        }

        /// <summary>
        /// 设置单曲循环
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SinglePlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.单曲循环;
            PlayMode = "单曲循环";
        }

        /// <summary>
        /// 列表循环
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoopPlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.列表循环;
            PlayMode = "列表循环";
        }
        #endregion

        #region 播放、暂停、上一首、下一首、进度条、音量、显示歌词
        /// <summary>
        /// 点击音量图标，弹出调节音量的控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumn_Click(object sender, EventArgs e)
        {
            volumnBar.Visible = (volumnBar.Visible == false) ? true : false;
        }

        /// <summary>
        /// 调节音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumnBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volumnBar.Value;
        }

        /// <summary>
        /// 播放和暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState.ToString() == "wmppsPlaying")//正在播放->暂停
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                Play.Image = Resources.play;
            }

            else if(axWindowsMediaPlayer1.playState.ToString() == "wmppsPaused")//暂停->继续播放
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                Play.Image = Resources.pause;
            }

            else if (axWindowsMediaPlayer1.playState.ToString() == "wmppsUndefined")//开始播放
            {
                if (Songs.SelectedItems.Count == 0) return;//没有选中歌曲
                second = 0;
                string name = Songs.SelectedItems[0].SubItems[0].Text;//歌名
                string singer = Songs.SelectedItems[0].SubItems[1].Text;//歌手

                currentIndex = Songs.SelectedItems[0].Index;//被选中歌曲的下标
                int index = SongsList.SelectedIndex;//获取被选中歌单的下标
                nameLabel.Text = name;//展示歌名
                singerLabel.Text = singer;//展示歌手
                ProgressBar.Maximum = exchangeTime(SongLists[index].songList[currentIndex].Time);
                allTime.Text = @"\" + SongLists[index].songList[currentIndex].Time;//展示时间
                allsecond = exchangeTime(SongLists[index].songList[currentIndex].Time);
                axWindowsMediaPlayer1.URL = SongLists[index].songList[currentIndex].URL;
                axWindowsMediaPlayer1.Ctlcontrols.play();//播放该歌曲
                Play.Image = Resources.pause;
            }
        }

        /// <summary>
        /// 获取播放路径
        /// </summary>
        /// <returns></returns>
        private string GetPath()
        {
            switch (PlayMode)
            {
                case "随机播放":
                    currentIndex = random.Next(1, Songs.Items.Count);//生成1到Count-1的随机数
                    break;
                case "单曲循环":
                    break;
                case "列表循环":
                    if (currentIndex == Songs.Items.Count - 1)
                        currentIndex = 0;
                    else
                        currentIndex++;
                    break;
            }
            int index = SongsList.SelectedIndex;
            Song nextSong = (SongLists[index].songList)[currentIndex];//下一首歌
            refreshLabel(nextSong);
            return nextSong.URL;
        }

        /// <summary>
        /// 更新歌名、歌手、时间、进度条
        /// </summary>
        private void refreshLabel(Song song)
        {
            nameLabel.Text = song.SongName;
            singerLabel.Text = song.Singer;
            allTime.Text = @"\"+song.Time;
            nowTime.Text = "00:00";
            ProgressBar.Value = 0;
            ProgressBar.Maximum = exchangeTime(song.Time);
        }

        /// <summary>
        /// 播放状态改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0://未知状态
                    break;
                case 1://停止
                    timer1.Stop();
                    break;
                case 2://暂停
                    timer1.Stop();//停止计时
                    break;
                case 3://正在播放
                    timer1.Start();//重新计时
                    break;
                case 8://播放结束                    
                    string path = GetPath();//获取音乐播放文件路径，并添加到播放控件
                    WMPLib.IWMPMedia media = axWindowsMediaPlayer1.newMedia(path);
                    axWindowsMediaPlayer1.currentPlaylist.appendItem(media);
                    break;
            }
        }

        /// <summary>
        /// 调节进度条进度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressBar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = ProgressBar.Value;
        }
        
        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextSong_Click(object sender, EventArgs e)
        {
            if (currentIndex < Songs.Items.Count-1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currentIndex += 1;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currentIndex = 0;
            }
            Play.Image = Resources.pause;
            Songs.Items[currentIndex].Focused = true;
            Songs.Items[currentIndex].EnsureVisible();
            Songs.Items[currentIndex].Selected = true;

            Song song = SongLists[SongsList.SelectedIndex].songList[currentIndex];
            string url = song.URL;
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            refreshLabel(song);
        }

        /// <summary>
        /// 上一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrontSong_Click(object sender, EventArgs e)
        {  
            if (currentIndex > 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currentIndex -= 1;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                currentIndex = Songs.Items.Count - 1;
            }
            Play.Image = Resources.pause;
            Songs.Items[currentIndex].Focused = true;
            Songs.Items[currentIndex].EnsureVisible();
            Songs.Items[currentIndex].Selected = true;
            Song song = SongLists[SongsList.SelectedIndex].songList[currentIndex];
            string url = song.URL;
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            refreshLabel(song);
        }



        #endregion

        /// <summary>
        /// 每0.1秒进行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState.ToString()== "wmppsPlaying")
            {
                timer1.Interval = 1000;
                second = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                if (second < 10)
                {
                    nowTime.Text = "00:0" + second;
                }
                else if(second<60)
                {
                    nowTime.Text = "00:" + second;
                }
                else if(second<6000)
                {
                    string s;
                    if (second % 60 < 10)
                        s = "0" + second % 60;
                    else
                    {
                        s = (second % 60).ToString();
                    }
                    nowTime.Text = "0" + second / 60 + ":" + s;
                }
                ProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            
        }

       


       /// <summary>
       /// 将时间字符串转化为秒数
       /// </summary>
       /// <param name="s"></param>
       /// <returns></returns>
        private int exchangeTime(string s)
        {
            string min = s.Substring(0, 2); int m;
            string se = s.Substring(3, 2); int sc;
            if (min[0] == 0)
                m = Convert.ToInt32(min[1]);
            else
                m = Convert.ToInt32(min);
            if (se[0] == 0)
                sc = Convert.ToInt32(se[1]);
            else
                sc = Convert.ToInt32(se);
            return m * 60 + sc;

        }

        /// <summary>
        /// 添加喜欢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addLove_Click(object sender, EventArgs e)
        {
            
        }
    }
}
