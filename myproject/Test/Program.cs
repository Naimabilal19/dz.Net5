using myproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание 1
            WebSite web = new WebSite("", "", "", "");
            web.Input();
            Console.WriteLine();

            web.Print();
            Console.WriteLine();

            web.Name = "MyStat";
            web.Way = "https://mystat.itstep.org/en/main/homework/page/index";
            web.Descr = "уникальный сервис для учащихся, разработанный и использующийся в Компьютерной Академии ШАГ";
            web.Address = "104.26.4.89";
            

            string w = web.ToString();
            Console.WriteLine(w);
            #endregion

            Console.WriteLine("------------------------------------------\n");

            #region задание 2
            Magazine m = new Magazine("", 0, "", 0, "");
            m.Input();
            Console.WriteLine();

            m.Print();
            Console.WriteLine();

            m.Name1 = "Rolling Stone";
            m.Year = 1967;
            m.Descr1 = "Aмериканский журнал, посвящённый музыке и поп-культуре.";
            m.Number = 0934568709;
            m.Email = "letters@rollingstone.com";

            string mm = m.ToString();
            Console.WriteLine(mm);
            #endregion

            Console.WriteLine("------------------------------------------\n");
            #region задание 3
            Shop r = new Shop("", "", "", 0, "");
            r.Input();
            Console.WriteLine();

            r.Print();
            Console.WriteLine();

            r.Name2 = "Эпицентр";
            r.Address1 = "Овидиопольская дорога, 1";
            r.Descr2 = "Эпицентр предлагает своим покупателям самый большой ассортимент товаров для дома.";
            r.Number1 = 0487793344;
            r.Email1 = "od.proposition@epicentrk.com";

            string rr = r.ToString();
            Console.WriteLine(rr);
            #endregion
        }
    }
}
