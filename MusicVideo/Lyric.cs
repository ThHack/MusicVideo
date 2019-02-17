using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicVideo
{
    class LyricFiles
    {
        public List<Lyric> listLyric = new List<Lyric>();

        public void LoadLyricFromFile(string fileName)
        {
            Encoding encoder = Encoding.GetEncoding("GB2312");
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs, encoder);
            string strLyric;
            while((strLyric = sr.ReadLine())!=null)
            {
                if (strLyric == "")
                    continue;
                Lyric lyric = new Lyric();
                lyric.minute = int.Parse(strLyric.Substring(1, 2));
                lyric.second = float.Parse(strLyric.Substring(4, 5));
                lyric.strLyric = strLyric.Substring(10);
                lyric.totSecond = lyric.minute * 60 + lyric.second;
                listLyric.Add(lyric);
            }
            sr.Close();
            fs.Close();
        }
    }

    //一行歌词
    class Lyric
    {
        public int minute;
        public float second;
        public float totSecond;
        public string strLyric;
    }

}
