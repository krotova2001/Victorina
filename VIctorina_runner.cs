using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine($"Тема виторины - {victorina.theme}");
            for (int i = 0; i<victorina.Questions.Length; i++) // начинаем опрос
            {
                //пока напишем с одним варинатом ответа, позде дорабатаем
                Console.WriteLine("У вас есть вопрос и несколько вариантов ответов. Правильных варинатов может быть несколько.");
                Console.WriteLine("Просто укажите номер правильного ответа. Если ответов несколько - перечислите их через запятую");
                Console.WriteLine($"Вопрос {i+1}: {victorina.Questions[i]}"); // показываем вопрос
                Console.WriteLine("-----------------------------");
                foreach (var variant in victorina.Answers[i].Keys)
                {
                    int number = 1;
                    Console.WriteLine($"{number} - {variant}");
                }
                Console.WriteLine($"\nВаше ответ: ");
                string ans_str = Console.ReadLine();
                int ans;
                Int32.TryParse(ans_str, out ans); // записываем число с ответом
                if (ans >= victorina.Answers[i].Count && ans>0) // если юзер ввел вариант среди вариантов ответов (не случайное число), то суммируем баллы
                {
                    score += victorina.Answers[i].ElementAt(ans+1).Value; // получаем по индексу ключа значение
                }
            }
        }
    }
}
