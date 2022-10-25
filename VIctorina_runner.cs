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
    //Класс прохождения викторины. Организует опрос пользователя по вопросам, проверку ответов и запись очков
    class VIctorina_runner
    {
        public void Start(User user, Vict victorina) // старт викторины. Принимает юзера и викторину
        {
            int score = 0; // начальный счет
            Console.Clear();
            Console.WriteLine("Викторина началась");
            //Console.WriteLine($"Тема виторины - {victorina.theme}");
            Console.WriteLine("У вас есть вопрос и несколько вариантов ответов. Правильных варинатов может быть несколько.");
            Console.WriteLine("Просто укажите номер правильного ответа. Если ответов несколько - перечислите их через запятую");
            for (int i = 0; i<victorina.Questions.Length; i++) // начинаем опрос
            {
                //пока напишем с одним варинатом ответа, позде дорабатаем
               
                Console.WriteLine($"Вопрос {i+1}: {victorina.Questions[i]}"); // показываем вопрос
                Console.WriteLine("-----------------------------");
                int number = 1; // нумерация вариантов ответов
                foreach (var variant in victorina.Answers[i].Keys)
                {
                    Console.WriteLine($"{number} - {variant}");
                    number++;
                }
                Console.WriteLine($"\nВаше ответ: ");
                string ans_str = Console.ReadLine();
                int ans;
                Int32.TryParse(ans_str, out ans); // записываем число с ответом
                if (ans <= 4 && ans>0) // если юзер ввел вариант среди вариантов ответов (не случайное число), то суммируем баллы
                {
                    score += victorina.Answers[i].ElementAt(ans-1).Value; // получаем по индексу ключа значение
                }
            }
            Console.WriteLine($"Вы прошли викторину и набрали {score} баллов");
            user.Inc_score(score);
        }
        public Vict Load_from_json(string filename) // метода загрузки викторины с файла
        {
            string buff = File.ReadAllText(filename); // считываем файл
            Vict vict = JsonSerializer.Deserialize<Vict>(buff); // создаем объект из json
            return vict;
        }



    }
}
