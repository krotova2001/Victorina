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
    //статичный класс создания и редактирования викторин
    static public class Vict_editor
    {
        public static void Create()
        {
           
            Console.WriteLine("Сколько будет вопросов?");
            int num;
            Int32.TryParse(Console.ReadLine(), out num); // запишем кол-во вопросов
            Vict vict = new Vict(num); // создадим пустую викторину
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Вопрос {i}:");
                vict.Questions[i - 1] = Console.ReadLine();
                for (int j = 1; j <= 4; j++)  // сделаем по 4 варианта ответа
                {
                    Console.Write($"Вариант ответа {j}: ");
                    string ans = Console.ReadLine();
                    Console.Write($"Балл за этот ответ: ");
                    int ball;
                    Int32.TryParse(Console.ReadLine(), out ball);
                    vict.answers[i - 1].Add(ans, ball); // запишем в словарь варинат ответа и его балл
                    Console.Clear();
                }
            }
            
            Console.WriteLine("Введите имя файла викторины");
            string filename = Console.ReadLine();
           
            using (FileStream sr = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
            {
                JsonSerializer.Serialize(sr, vict); // создаем новый json с готовой викториной
            }
        }
    }
}
