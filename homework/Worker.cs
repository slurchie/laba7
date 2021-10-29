using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Worker
    {
        string name;
        string post;
        List<Worker> subordinates = new List<Worker>();
        public Worker(string Name, string Post)
        {
            name = Name;
            post = Post;
        }
        public Worker(string Name, string Post, List<Worker> workers) : this(Name, Post) //конструктор, принимающий имя должность и список подчинённых
        {
            subordinates = workers;
        }
        public bool TakeTask(string Post, string nameTask, Worker chief)
        //свойство получает должность,        
        //название задачи и ссылку на начальника
        //проверяет если должность работника, который должен выполнить эту задачу
        //соответствует его должности, то он её берёт сам если не соответствует,         
        //смотрит кто из подчинённых может взять эту задачу            
        //если не соответствует, смотрит кто из подчинённых может взять эту задачу
        // если никто не взял задачу, то возвращает ложь
        //если кто-то взял, то правду
        // если задачу взял один подчинённый, то метод завершает работу, потому что дальше искать сотрудника необходимости нет
        {
            if (post == Post)
            {
                Write(chief.name, name, nameTask);
                return true;
            }
            foreach (Worker S in subordinates)
            {
                if (S.TakeTask(Post, nameTask, this))
                    return true;
            }
            return false;
        }
        public static void Write(string nameDirector, string nameWorker, string nameTask)//метод пишет кто кому дал какую задачу
        {
            Console.WriteLine("От человека " + nameDirector + " даётся задача \"" + nameTask + "\" человеку " + nameWorker);
        }
        public void AddSubordinate(Worker worker) //добавляет подчинённых в список
        {
            subordinates.Add(worker);
        }
    }
}
