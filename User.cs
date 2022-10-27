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
        public string Login { get; set; } // логин
        public string Password { get; set; } // пароль
        public DateTime birthday { get; set; }
        bool is_admin = false; // по умолчанию юзер - не администратор
        int score=0; //очки от пройденных викторин
        public User () {}

        public User(string login, string password, DateTime birthday, bool is_admin)
        {
            this.Login = login;
            this.Password = password;
            this.birthday = birthday;
            this.is_admin = is_admin;
        }

        public bool Is_admin { get { return is_admin; } } // показать права администратора
        public int Score { get { return score; } } // показать очки (ретинг)
        public void Inc_score (int s) { score += s; } // доабвить очкт после прохождения теста
    }
}
