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
        Dictionary<string, int>[] answers; //варианты и ответов и баллы. Индексы совпадают с вопросами. Список словарей.
        //Элемент списка совпадает с элементом массива вопроса. В словаре варианты ответов и баллы на каждый вопрос.
        public string theme; // тема или раздел викторины
        public string [] Questions 
        { 
            get { return questions; }
            set { questions = value; }
        }
        public Dictionary<string, int>[] Answers 
        { 
            get { return answers; } 
            set { answers = value; }
        } // вернуть вопросы
        public Vict()
        {
            questions = new string[0];
            answers = new Dictionary<string, int>[0];
        }

    }
}
