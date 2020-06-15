using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class AgeOverSizeException : ArgumentException
    {
        public int Value
        {
            get;
        }
        public AgeOverSizeException(string message, int val) : base(message)
        {
            Value = val;
        }
        public void ToString()
        {
            Console.WriteLine(Message + $"Введённый возраст - {Value} ");
        }
    }
    class Person
    {
        string name;
        public string Name { get; set; }
        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                {
                    new AgeOverSizeException("Некорректный возраст. ", value).ToString();
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.age = Age;
        }
        public Person()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество экземпляров");
            int a = int.Parse(Console.ReadLine());
            Person[] p = new Person[a];
            for (int i = 0; i < a; i++)
            {
                p[i] = new Person();
                Console.WriteLine("Введите Имя");
                string name = Console.ReadLine();
                p[i].Name = name;
                Console.WriteLine("Введите Возраст");
                int age = int.Parse(Console.ReadLine());
                p[i].Age = age;
            }
            Console.ReadKey();
        }
    }
}
