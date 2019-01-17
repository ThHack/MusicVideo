using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Song
    {
        public string SongName { get; set; }//歌名
        public string Author { get; set; }//词作者
        public string Composer { get; set; }//曲作者
        public string Singer { get; set; }//歌手
        public string Album { get; set; }//专辑
        public Dictionary<string, string> Comment;//评论
        public string Time { get; set; }//播放时长
        public string URL { get; set; }//音乐文件地址

        public Song()
        {
            Comment = new Dictionary<string, string>();
        }

        public Song(string url)
        {
            URL = url;
            Comment = new Dictionary<string, string>();
        }
    }
}
