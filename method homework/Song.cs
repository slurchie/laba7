using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_homework
{
    class Song
    {
        string name; //название песни
        string author; //автор песни
        Song prev; //связь с предыдущей песней в списке
        public Song(string Name, string Author)
        {
            name = Name;
            author = Author;
        }
        public Song(string Name, string Author, Song Prev) : this(Name, Author)
        {
            prev = Prev;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public void SetAutor(string Author)
        {
            author = Author;
        }
        public void SetPrev(Song Prev)
        {
            prev = Prev;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public override bool Equals(object d)
        {
            bool b = (d as Song).name.Equals(name)&&(d as Song).author.Equals(author);    

            return b;
            //if (d is Song)    `
            //{
            //    if (name != ((Song)d).name)
            //        return false;
            //    if (author != ((Song)d).author)
            //        return false;
            //    return true;
            //}
            //return false;
        }
    }
}
