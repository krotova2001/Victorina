using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_exam_
{
    //класс пользователя
    internal class User
    {
        string login; // логин
        string password; // пароль
        public DateTime birthday;
        bool is_admin = false; // по умолчанию юзер - не администратор
        int score=0; //очки от пройденных викторин
        public User (string log, string pass) // конструктор с учетными данными
        {
            login = log;
            password = pass;
        }
        public string Login { get { return login; } } // показать логин
        public bool Is_admin { get { return is_admin; } } // показать права администратора
        public int Score { get { return score; } } // показать очки (ретинг)
    }
}
