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
    public partial class NameDialog : Form
    {
        public string Result { get; set; }

        public NameDialog()
        {
            InitializeComponent();           
        }

        public NameDialog(string OriginName)
        {
            InitializeComponent();
            NewName.Text = OriginName;//展示原歌单名字
            
        }

        /// <summary>
        /// 点击确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            Result = NewName.Text;//获得新名字
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 点击取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
