using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2_voroshilov
{
    internal struct Song
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
    
        public Song()
        {

        }

        public Song(string name, string author, string filename)
        {
            Title = name;
            Author = author;
            Filename = filename;
        }
    }
}
