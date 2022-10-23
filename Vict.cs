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
        Dictionary<string, int> answers; //варианты и ответов и баллы. индексы совпадают с вопросами
        string theme; // тема или раздел викторины
    }
}
