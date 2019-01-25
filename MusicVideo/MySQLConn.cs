using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
