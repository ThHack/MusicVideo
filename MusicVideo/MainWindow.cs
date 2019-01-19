using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicVideo
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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


        /// <summary>
        /// 弹出trackbar调节音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = (trackBar1.Visible == true) ? false : true;
        }

        
    }
}
