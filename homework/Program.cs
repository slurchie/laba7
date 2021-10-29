using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program //пишем метод здесь чтобы потом в мейне задачу создать
    {
        static void CreateTask(Worker chiefOfChiefs, string dolzhnost, string nameTask)
        {
            if (!chiefOfChiefs.TakeTask(dolzhnost, nameTask, chiefOfChiefs))
                Console.WriteLine("Задачу \"" + nameTask + "\" никто не взял");
        }
        static void Main(string[] args)
        {
            Worker Boris = new Worker("Борис", "Директор");
            Worker Rashid = new Worker("Рашид", "Финансовый директор");
            Boris.AddSubordinate(Rashid);
            Worker Lucas = new Worker("Лукас", "Начальник бугхалтерии");
            Rashid.AddSubordinate(Lucas);
            Worker Ilham = new Worker("Ильхам", "Директор по автоматизации");
            Boris.AddSubordinate(Ilham);
            Worker Orkadi = new Worker("Оркадий", "Начальник ИТ");
            Ilham.AddSubordinate(Orkadi);
            Worker Volody = new Worker("Володя", "Зам ИТ");
            Orkadi.AddSubordinate(Volody);
            Worker Sergey = new Worker("Сергей", "Начальник разработчиков");
            Orkadi.AddSubordinate(Sergey);
            Volody.AddSubordinate(Sergey);
            Worker Ilshat = new Worker("Ильшат", "Начальник системщиков");
            Orkadi.AddSubordinate(Ilshat);
            Volody.AddSubordinate(Ilshat);
            Worker Lyisan = new Worker("Ляйсан", "Зам разработчиков");
            Sergey.AddSubordinate(Lyisan);
            Worker Ivanich = new Worker("Иваныч", "Зам системщиков");
            Ilshat.AddSubordinate(Ivanich);
            Worker Ilya = new Worker("Илья", "Системщик");
            Worker Vitya = new Worker("Витя", "Системщик");
            Worker Jenya = new Worker("Женя", "Системщик");
            Ilshat.AddSubordinate(Ilya);
            Ivanich.AddSubordinate(Ilya);
            Ilshat.AddSubordinate(Vitya);
            Ivanich.AddSubordinate(Vitya);
            Ilshat.AddSubordinate(Jenya);
            Ivanich.AddSubordinate(Jenya);
            Worker Marat = new Worker("Марат", "Разработчик");
            Worker Dina = new Worker("Дина", "Разработчик");
            Worker Ildar = new Worker("Ильдар", "Разработчик");
            Worker Anton = new Worker("Антон", "Разработчик");
            Sergey.AddSubordinate(Marat);
            Lyisan.AddSubordinate(Marat);
            Sergey.AddSubordinate(Dina);
            Lyisan.AddSubordinate(Dina);
            Sergey.AddSubordinate(Ildar);
            Lyisan.AddSubordinate(Ildar);
            Sergey.AddSubordinate(Anton);
            Lyisan.AddSubordinate(Anton);

            CreateTask(Boris, "Системщик", "Сделай что-то");
            CreateTask(Boris, "Зам системщиков", "Отправь всех работать");
            CreateTask(Boris, "Директор по автоматизации", "Починить сервера");
            CreateTask(Boris, "Зам ИТ", "Устранить баги");
        }
    }
}

