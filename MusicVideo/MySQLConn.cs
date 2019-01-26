using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Music;


namespace MusicVideo
{
    /// <summary>
    /// 此类用于数据库的连接和相关操作
    /// </summary>
    class MySQLConn
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>连接</returns>
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(
                "server=localhost;user=root;password=root;database=music_login;charset=utf8");
            connection.Open();
            return connection;
        }

        /// <summary>
        /// 根据用户名查询密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns>密码</returns>
        public static string QueryPassword(int user)
        {
            string password=null;
            using (MySqlConnection con = GetConnection())
            {
                string cmdWord = "SELECT password FROM music_login.user_password where user="+ user;//查询用户名对应的密码
                using (MySqlCommand cmd = new MySqlCommand(cmdWord, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader[0].ToString();
                        }
                    }
                }                
            }
            return password;
        }

        /// <summary>
        /// 根据用户名查询昵称
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string QueryName(int user)
        {
            string name = null;
            using (MySqlConnection con = GetConnection())
            {
                string cmdWord = "SELECT name FROM music_login.user_password where user=" + user;//查询用户名对应的昵称
                using (MySqlCommand cmd = new MySqlCommand(cmdWord, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader[0].ToString();
                        }
                    }
                }
            }
            return name;
        }

        /// <summary>
        /// 创建名字为name的数据库
        /// </summary>
        /// <param name="name"></param>
        public static void CreateDB(string name)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand("create database "+name+";", conn))//根据用户名创建数据库
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 在登录表中插入一行数据
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        public static void InsertUser(int user,string password,string name)
        {
            using(MySqlConnection conn = GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(
                "Insert into music_login.user_password values(@user,@password,@name)", conn))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@user",user);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }




        /// <summary>
        /// 创建名为name的表（歌单）
        /// </summary>
        /// <param name="name"></param>
        public static void CreateTable(string DB,string name)
        {
            string s0 = "use " + DB;
            string s = "CREATE TABLE " + name + " " +
                "( url varchar(100) not null primary key)";
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(s0, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand(s, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 在歌单表中插入数据
        /// </summary>
        public static void InsertSong(string DB,string Table,string _url)
        {
            string s = string.Format("Insert into {0}.{1} values(@url)", DB, Table);
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(s, conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@url", _url);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 根据表的内容初始化歌单
        /// </summary>
        /// <returns></returns>
        public static SongList Getsonglist(string db, string table)
        {
            SongList ans = new SongList(table);//歌单的名字就是表的名字
            string s = string.Format("select * from {0}.{1}", db, table);
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(s, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Song song = new Song(reader["url"].ToString());
                            ans.AddSong(song);
                        }
                    }
                }
            }
            return ans;
        }

        /// <summary>
        /// 删除指定表
        /// </summary>
        /// <param name="DB"></param>
        /// <param name="Table"></param>
        public static void DeleteTable(string DB, string Table)
        {
            string s = string.Format("drop {0}.{1};",DB,Table);
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(s, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 返回指定数据库中所有的表的名字
        /// </summary>
        /// <param name="DB"></param>
        /// <returns></returns>
        public static List<string> GetTableName(string DB)
        {
            List<string> list = new List<string>();
            string s = string.Format("select table_name from information_schema.tables where table_schema='{0}';", DB);
            using(MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(s, conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader[0].ToString());
                        }
                    }
                }
            }
            return list;
        }
    }
}
