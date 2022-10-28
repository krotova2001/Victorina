using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//сделать аутентификацию, шифрование файлов
//организовать просмотр-выбор викторин

namespace Victorina_exam_
{
    class Program
    {
        static void Main(string[] args)
        {
           //красивое приветствие
            Print.Phrase("ВИКТОРИНА");
            Print.Clear(1.5);
            
            Users_container container = new Users_container(); // загружаем всех пользователей
            Menu menu = new Menu();
            menu.Show(); // показать основное меню
            int choise1, choise2;

            do
            {
                Console.Clear();
                menu.Show();// показываем меню

                string input = Console.ReadLine(); // считывание выбора пользователя
                choise1 = int.Parse(input);
                switch (choise1)
                {
                    case 1:
                        User u = Users_container.Create_new_User();
                        break;
                    case 2:  //прохождение викторины
                        User user = Users_container.Auth(); // запускаем аутентификацию
                        
                        
                            if (user != null) // если она прошла - запускаем тест
                            {
                                if (!user.Is_admin) // если это обычный пользователь, проходим викторину
                                {
                                    VIctorina_runner R = new VIctorina_runner();
                                    Vict vict = VIctorina_runner.Load_from_json("test.json");
                                    R.Start(user, vict);
                                }
                                //а ежели это администратор - добавляем опцию создания викторины
                                else
                                {
                                    do
                                    {
                                        menu.Show_1();
                                        string input2 = Console.ReadLine();    
                                        choise2 = int.Parse(input2);
                                        switch (choise2)
                                        {
                                            case 1: // пройти викторину
                                                VIctorina_runner R = new VIctorina_runner();
                                                Vict vict = VIctorina_runner.Load_from_json("test.json");
                                                R.Start(user, vict);
                                            break;
                                            case 2: // создать викторину
                                                Vict_editor.Create();
                                            break;
                                        }
                                    }
                                    while (choise2 != 0);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Аутентификация не прошла. Нажмите Enter");
                                Console.ReadLine();
                            }
                        
                        break;
                   
                    case 0:
                       
                       
                        break;
                }
            }
            while (choise1 != 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Print.Phrase("ПОКА!");
            Print.Phrase("♥");
            Print.Clear(1.5);
        }
    }
}
