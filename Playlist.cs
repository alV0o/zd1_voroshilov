using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zd2_voroshilov
{
    internal class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        //Выбор текущей песни
        public Song CurrentSong()
        {
            if (list.Count > 0)
            {
                return list[currentIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
            }
        }

        //Добавление песни без автора
        public void AddSong(string name, string filename)
        {
            list.Add(new Song(name, "Неизвестен", filename));
        }

        //добавление песни с одним автором
        public void AddSong(string name, string author, string filename)
        {
            list.Add(new Song(name, author, filename));
        }

        //добавление песни с двумя авторами
        public void AddSong(string name, string author, string secAuthor, string filename)
        {
            author = $"{author}, {secAuthor}";

            list.Add(new Song(name, author, filename));
        }

        //Вывод песен в таблицу
        public void WriteSongs(DataGridView dgv)
        {
            dgv.Rows.Clear();
            int i = 1;
            foreach(Song song in list)
            {
                dgv.Rows.Add(i, song.Title, song.Author);
                i++;
            }
        }

        //переключение песни вперед
        public bool NextSong()
        {
            if (currentIndex+1 < list.Count)
            {
                currentIndex++;
                return true;
            }
            else
            {
                return false;
            }
        }

        //переключение песни вперед
        public bool BackSong()
        {
            if (currentIndex - 1 >= 0)
            {
                currentIndex--;
                return true;
            }
            else
            {
                return false;
            }
        }

        //заполнение combobox номерами треков
        public void FillComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            for(int i = 0; i < list.Count; i++)
            {
                cb.Items.Add(i+1);
            }
        }

        //установление индекса трека
        public void SetIndexTrack(int index)
        {
            currentIndex = index;
        }

        //удаление по индексу
        public void Delete(int index)
        {
            list.RemoveAt(index - 1);
        }

        //удаление по имени
        public int Delete(string name)
        {
            foreach(Song song in list)
            {
                if (song.Title == name)
                {
                    list.Remove(song);
                    return 0;
                }
            }
            return -1;
        }

        //удаление по имени и по автору
        public int Delete(string name, string author)
        {
            foreach (Song song in list)
            {
                if (song.Title == name && song.Author == author)
                {
                    list.Remove(song);
                    return 0;
                }
            }
            return -1;
        }

        //очистка плейлиста
        public void ClearPlaylist()
        {
            list.Clear();
            currentIndex = 0;
        }
    }
}
