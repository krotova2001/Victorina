﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//сделать аутентификацию, шифрование файлов
//организовать просмотр-выбор викторин
//хранение польхователей в файле

namespace Victorina_exam_
{
    class Program
    {
        static void Main(string[] args)
        {
            VIctorina_runner R = new VIctorina_runner();
            Vict t = VIctorina_runner.Load_from_json("test.json");
            User u = new User("123", "321");
            R.Start(u, t);
        }
    }
}
