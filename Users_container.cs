using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; // небходимый пакет
using System.Text.Json.Serialization;
using System.IO;

namespace Victorina_exam_
{
    //контейнер пользователей, хранит всех юзеров
    class Users_container
    {
        static List<User> users; //список объектов-пользователей
        static void Init() // при первом запуске если нет ни одного юзера вообще, нужно создать пустой 
        {
            
        }
        static Users_container () // конструктор
        {
            users = new List<User> ();// список необходимо инициализировать
            
            using (FileStream sr = new FileStream("users.json", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                users = JsonSerializer.Deserialize<List<User>>(sr); // загружаем из файла список юзеров
            }
        }

        public static User Create_new_User() // функция создания нового юзера
        {
            string log, pass;
            do // пока логин не будет уникальным - не регистрируем
            {
                Console.Write("Введите login:");
                log = Console.ReadLine();
            }
            while (!Login_chek(log));

            Console.Write("Введите pass:");
            pass = Console.ReadLine();
            Console.WriteLine("День рождения");
            DateTime D = DateTime.Parse(Console.ReadLine().Trim()); // формируем дату ДР;
            User user = new User(log, pass, D, false); // создаем нового юзера с указаными данными
            users.Add(user); // добавляем в список
            return user;
        }
        
        ~Users_container() // деструктор. Созраняет в файл всех юзеров
        {
            File.Delete("users.json");
            using (FileStream sr = new FileStream("users.json", FileMode.Create, FileAccess.ReadWrite))
            {
                JsonSerializer.Serialize<List<User>>(sr, users); // сохраняем в файл список юзеров
            }
        }

        static bool Login_chek(string log) // проверка на уникальность логина
        {
            foreach (User l in users)
            {
                if (l.Login == log)
                {
                    Console.WriteLine("Такой login уже занят");
                    return false;
                }
            }
            return true;
        }
    }
}
