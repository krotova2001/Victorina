using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_exam_
{
    //класс пользователя
    class User
    {
        string login; // логин
        string password; // пароль
        public DateTime birthday { get; set; }
        bool is_admin = false; // по умолчанию юзер - не администратор
        int score=0; //очки от пройденных викторин
        public User () {}

        public User(string login, string password, DateTime birthday, bool is_admin)
        {
            this.login = login;
            this.password = password;
            this.birthday = birthday;
            this.is_admin = is_admin;
        }

        public string Login { get { return login; } } // показать логин
        public string Password { get { return password; } } // показать пароль
        public bool Is_admin { get { return is_admin; } } // показать права администратора
        public int Score { get { return score; } } // показать очки (ретинг)
        public void Inc_score (int s) { score += s; } // доабвить очкт после прохождения теста
    }
}
