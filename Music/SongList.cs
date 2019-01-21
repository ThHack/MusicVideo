using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    /// <summary>
    /// 歌单
    /// </summary>
    class SongList
    {
        public string listName { get; set; }
        public List<Song> songList;

        //构造器
        public SongList(string name)
        {
            listName = name;
            songList = new List<Song>();
        }

        /// <summary>
        /// 添加歌曲到歌单，如果有重复的则退出
        /// </summary>
        /// <param name="song"></param>
        private void AddSong(Song song)
        {
            foreach (Song s in songList)
                if (s.SongName.Equals(song.SongName) && s.Singer.Equals(song.Singer))
                    return;

            songList.Add(song);
        }

        /// <summary>
        /// 删除歌单中某首歌曲
        /// </summary>
        /// <param name="song"></param>
        private void DeleteSong(Song song)
        {
            songList.Remove(song);
        }

        /// <summary>
        /// Linq语句挑选出歌名或歌手中含有指定名字的歌曲
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private List<Song> QuerySong(string name)
        {
            return songList.Where(song => song.SongName.Contains(name)
            || song.Singer.Contains(name)).ToList();
        }

        /// <summary>
        /// 歌单中全部歌曲
        /// </summary>
        /// <returns></returns>
        private List<Song> QueryAll()
        {
            return songList;
        }
    }
}
