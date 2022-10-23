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
        string login;
        string password;
        public DateTime birthday;
        bool is_admin = false;
        int score;
        public User (string log, string pass)
        {
            login = log;
            password = pass;
        }
        public string Login { get { return login; } }
        public bool Is_admin { get { return is_admin; } }
        public int Score { get { return score; } }
    }
}
