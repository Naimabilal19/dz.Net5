using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public class Magazine
    {
        private string name;
        private int year;
        private string description;
        private int numberphone;
        private string email;

        public Magazine() { }
        public Magazine(string n, int y, string d, int np, string e)
        {
            name = n; year = y; description = d; numberphone = np; email=e;
        }

        public string Name1 { get { return name; } set { name = value; } }
        public int Year { get { return year; } set { year = value; } }
        public string Descr1 { get { return description; } set { description = value; } }
        public int Number { get { return numberphone; } set { numberphone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Input()
        {
            Console.WriteLine("Введите название журнала: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите год основания: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите описание журнала: ");
            description = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон: ");
            numberphone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите контактный email: ");
            email = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Название журнала: { name}\n Год основания: {year}\n Описание журнала: {description}\n Контактный телефон: {numberphone}\n Контактный email: {email}");
        }

        public override string ToString()
        {
            return $"Название журнала: { name}\n Год основания: {year}\n Описание журнала: {description}\n Контактный телефон: {numberphone}\n Контактный email: {email}";
        }
    }
}
