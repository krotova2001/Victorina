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
        //Элемент списка совпадает с элементом массива вопроса. В словаре варинаты ответов и баллы.
        public string theme; // тема или раздел викторины
        public string [] Questions 
        { 
            get { return questions; }
        }
        public Dictionary<string, int>[] Answers { get { return answers; } }
    }
}
