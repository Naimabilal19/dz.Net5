using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
   public class WebSite
    {
        private string name;
        private string way;
        private string description;
        private string address;

        public WebSite() { }
        public WebSite(string n, string w, string d, string a)
        {
            name = n; way = w;description = d;address = a;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Way { get { return way; } set { way = value; } }
        public string Descr { get { return description; } set { description = value; } }
        public string Address { get { return address; } set { address = value; } }

        public void Input()
        {
            Console.WriteLine("Введите название сайта: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите путь к сайту: ");
            way = Console.ReadLine();
            Console.WriteLine("Введите описание сайта: ");
            description = Console.ReadLine();
            Console.WriteLine("Введите ip-address: ");
            address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Название: { name}\n Путь к сайту: {way}\n Описание сайта: {description}\n Адрес сайта: {address}");
        }

        public override string ToString()
        {
            return $"Название: { name}\n Путь к сайту: {way}\n Описание сайта: {description}\n Адрес сайта: {address}";
        }
    }
}
