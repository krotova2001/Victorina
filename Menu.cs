using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_exam_
{
    public class Menu // класс отображению меню
    {
        public void Show()
        {
            Console.WriteLine("Новый пользователь----1");
            Console.WriteLine("Войти---------------- 2");
            Console.WriteLine("Выход---------------- 0");
        }
        public void Show_1()
        {
            Console.Clear();
            Console.WriteLine("Пройти викторину----------1");
            Console.WriteLine("Создать викторину ------- 2");
            Console.WriteLine("Назад-------------------- 0");
        }

    }
}
