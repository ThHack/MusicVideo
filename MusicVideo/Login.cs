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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(textBox1.Text);
            string password = MySQLConn.QueryPassword(user);
            string name = MySQLConn.QueryName(user);
            if(password==textBox2.Text)
            {
                MainWindow mainWindow = new MainWindow(name);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码不正确！");
            }
        }
        /// <summary>
        /// 根据user创建数据库，把昵称传给mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(textBox1.Text);
            MySQLConn.CreateDB(textBox3.Text);//根据昵称创建数据库          
            MySQLConn.InsertUser(user, textBox2.Text, textBox3.Text);//保存用户名和密码到数据库
            MySQLConn.CreateTable(textBox3.Text, "love");
            MySQLConn.CreateTable(textBox3.Text, "history");
            MySQLConn.CreateTable(textBox3.Text, "songlist");
        }
    }
}
