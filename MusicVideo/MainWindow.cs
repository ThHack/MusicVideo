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
using Shell32;

namespace MusicVideo
{
    public partial class MainWindow : Form
    {
        
        public List<Item> MenuList;//歌单控件链表
        public List<SongList> SongLists;//歌单链表

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
            Song newsong = songlist.songList.Last();
            Songs.BeginUpdate();

            string[] info = new string[3];
            info[0] = newsong.SongName;//歌名
            info[1] = newsong.Singer;//歌手
            info[2] = newsong.Album;//专辑
            ListViewItem listViewItem = new ListViewItem(info);
            listViewItem.ForeColor = System.Drawing.Color.White;//字体设为白色
            Songs.Items.Add(listViewItem);

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
            openFileDialog1.ShowDialog();
            string ResultFile;
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
        }

        /// <summary>
        /// 设置顺序播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderPlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.顺序播放;
        }

        /// <summary>
        /// 设置顺序播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SinglePlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.单曲循环;
        }

        /// <summary>
        /// 列表循环
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoopPlay_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.列表循环;
        }
        #endregion

        #region 播放、暂停、上一首、下一首、进度条、音量
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
        /// 播放和暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Click(object sender, EventArgs e)
        {
            if(Play.Image==Resources.play)
            {
                
            }
        }

        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextSong_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 上一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrontSong_Click(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}
