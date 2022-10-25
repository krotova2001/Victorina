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
    //контейнер пользователей
    class Users_container
    {
        static List<User> users; // хранение пользователей
        public static void Create_new_User()
        {
            //проверка на уникальность логина
            string log, pass;
            do
            {
                Console.Write("Введите login:");
                log = Console.ReadLine();
            }
            while (!Login_chek(log));
            Console.Write("Введите pass:");
            pass = Console.ReadLine();
            Console.WriteLine("День рождения");
            DateTime D = DateTime.Parse(Console.ReadLine().Trim()); // формируем дату ДР;

        }
        static bool Login_chek(string log) // проверка на уникальность логина
        {
            foreach (var l in users)
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
