using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina_exam_
{
    //класс викторины
    class Vict
    {
        string[] questions; // вопросы
        public Dictionary<string, int>[] answers; //варианты и ответов и баллы. Индексы совпадают с вопросами. Список словарей.
        //Элемент списка совпадает с элементом массива вопроса. В словаре варианты ответов и баллы на каждый вопрос.
        public string theme; // тема или раздел викторины
        public string [] Questions // вернуть вопросы
        { 
            get { return questions; }
            set { questions = value; }
        }
        public Dictionary<string, int>[] Answers  // ответы
        { 
            get { return answers; } 
            set { answers = value; }
        } 
        public Vict(int size) // Конструктор с кол-вом вопросов, необхожим для создания новой викторины
        {
            questions = new string[size];
            answers = new Dictionary<string, int>[size];
            for (int i = 0; i < size; i++)
            {
                answers[i] = new Dictionary<string, int>();
            }
        }
        public Vict() { } // конструктор по умолчанию. Необхожим для сериализации

    }
}
