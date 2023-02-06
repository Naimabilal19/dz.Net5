using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public class Shop
    {
        private string name;
        private string address;
        private string description;
        private int numberphone;
        private string email;

        public Shop() { }
        public Shop(string n, string a, string d, int np, string e)
        {
            name = n;address = a; description = d; numberphone = np; email = e;
        }

        public string Name2 { get { return name; } set { name = value; } }
        public string Address1 { get { return address; } set { address = value; } }
        public string Descr2 { get { return description; } set { description = value; } }
        public int Number1 { get { return numberphone; } set { numberphone = value; } }
        public string Email1 { get { return email; } set { email = value; } }

        public void Input()
        {
            Console.WriteLine("Введите название магазина: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите его адресс: ");
            address = Console.ReadLine();
            Console.WriteLine("Введите описание профиля магазина: ");
            description = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон: ");
            numberphone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите контактный email: ");
            email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Название магазина: { name}\n Адрес магазина: {address}\n Описание профиля: {description}\n Контактный телефон: {numberphone}\n Контактный email: {email}");
        }

        public override string ToString()
        {
            return $"Название магазина: { name}\n Адрес магазина: {address}\n Описание профиля: {description}\n Контактный телефон: {numberphone}\n Контактный email: {email}";
        }
    }
}
