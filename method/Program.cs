using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace method
{ 
        class Program
    {
       
            public static string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }
        public static void task1(string input)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }
        static void Main(string[] args)
        {
            //1.2
            task1();
            Console.ReadKey(); 

            Console.WriteLine("8.3");
            Console.WriteLine("Путь к файлу:");
            string path = Console.ReadLine();
            if (File.Exists(path)) // проверяет существует ли файл
            {
                StreamReader sr1 = new StreamReader(path);
                string str = sr1.ReadToEnd(); //записывает все что есть в файле в строку
                sr1.Close();
                StreamWriter sw1 = new StreamWriter(path);
                sw1.Write(str.ToUpper());
                sw1.Close();
            }
            else
            {
                Console.WriteLine("Файла по уазанному пути не существует.");
            }

        }
    }
}
