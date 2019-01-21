using Shell32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Song
    {
        public string SongName { get; set; }//歌名
        public string Singer { get; set; }//歌手
        public string Album { get; set; }//专辑
        public Dictionary<string, string> Comment;//评论
        public string Time { get; set; }//播放时长
        public string URL { get; set; }//音乐文件地址
        public string Size { get; set; }//文件大小

        public Song()
        {
            Comment = new Dictionary<string, string>();
        }

        public Song(string url)
        {           
            URL = url;
            Comment = new Dictionary<string, string>();
            GetSongInfo();//获取音乐文件信息
        }

        /// <summary>
        /// 获取mp3文件信息
        /// </summary>
        public void GetSongInfo()
        {
            ShellClass sh = new ShellClass();
            Folder dir = sh.NameSpace(System.IO.Path.GetDirectoryName(URL));
            FolderItem item = dir.ParseName(System.IO.Path.GetFileName(URL));
            Singer = dir.GetDetailsOf(item, 13);//歌手
            SongName = dir.GetDetailsOf(item, 21);//歌名
            Album = dir.GetDetailsOf(item, 14);//专辑
            Time = dir.GetDetailsOf(item, 27);
            Time = Time.Substring(Time.IndexOf(":") + 1);//时长
            Size = dir.GetDetailsOf(item, 1);//文件大小
        }
    }
}
