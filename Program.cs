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
    class Program
    {
        static void Main(string[] args)
        {
            VIctorina_runner R = new VIctorina_runner();
            Vict t = R.Load_from_json("test.json");
            User u = new User("123", "321");
            R.Start(u, t);
        }
    }
}
