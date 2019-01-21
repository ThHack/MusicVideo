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


namespace MusicVideo
{
    public partial class MainWindow : Form
    {
        public List<Item> MenuList;

        public MainWindow()
        {
            InitializeComponent();
            MenuList = new List<Item>();
            MenuList.Add(new Item(Resources.love, "我喜欢"));
            MenuList.Add(new Item(Resources.history, "历史记录"));
            MenuList.Add(new Item(Resources.list, "默认歌单"));
            SongsList.Items.Add("我喜欢");
            SongsList.Items.Add("历史记录");
            SongsList.Items.Add("默认歌单");
           
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

        #region 音量调节
        /// <summary>
        /// 弹出trackbar调节音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = (trackBar1.Visible == true) ? false : true;
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
        #endregion


    }
}
