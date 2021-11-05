using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace method_homework
{
    class Program
    {
        public static void SearchMail(ref string s) //находит # и обрезает строку до неё + пробел после
                                                    //Если вылетает ошибка, то возвращает пустую строку
        {
            int index = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    index = i;
                    break;
                }
            }
            try
            {
                s = s.Remove(0, index + 2) + '\n';
            }
            catch
            {
                s = "";
            }
        }
        static void Main(string[] args)
        {
            //1.1
            StreamReader reader = new StreamReader(".txt");
            string[] input = reader.ReadToEnd().Split('\n');
            StreamWriter writer = new StreamWriter("output.txt");
            for (int i = 0; i < input.Length; i++)
            {
                SearchMail(ref input[i]);
                writer.Write(input[i]);
            }
            writer.Close();
            reader.Close();

            //1.2
            Console.WriteLine("1.2");
            List<Song> songs = new List<Song>(4);
            songs.Add(new Song("электрофорез", "зло")); //отправляем ссылку в конструктор, ссылаемся на пред песню
            songs.Add(new Song("максим", "ветром стать", songs[0]));
            songs.Add(new Song("лсп", "фокус", songs[1]));
            songs.Add(new Song("the nbrh", "daddy issues", songs[2]));
            foreach (Song s in songs)
            {
                Console.WriteLine(s.Title());
            }
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("=");
            }
        }
    }
}
