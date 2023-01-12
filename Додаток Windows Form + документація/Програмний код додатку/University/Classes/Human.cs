//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//створюємо простір імен University
namespace University
{
    public class Human //публічний клас Human
    {
        //створення приватних змінних класу
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Adress _adress;

        //конструктори
        public Human() //конструктор за замовчуванням
        {
            this._name = "Name";
            this._surname = "Surname";
            this._age = 18;
            this._adress = new Adress();
        }
        public Human(string name, string surname, int age, Adress adress)//констуктор з параметром
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._adress = adress;
        }

        //методи доступу до змінних класу
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //методи класу
        public void changeInfo() //метод зміни даних
        {
            Console.WriteLine("Введите новое имя: ");
            this._name = Console.ReadLine();
            Console.WriteLine("Введите новую фамилию: ");
            this._surname = Console.ReadLine();
            Console.WriteLine("Введите новий возраст: ");
            this._age = Int32.Parse(Console.ReadLine());
        }
        public void WriteToJson(string fileLink) //метод запису даних до json-файлу
        {
            Human human = this;
            string JsonData = JsonConvert.SerializeObject(human);
            File.WriteAllText(fileLink, JsonData);

        }
        
        public static bool operator >(Human one, Human two) //перегрузка оператора більше (порівняння двох зміних та повернення відповіді)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two) //перегрузка оператора меньше(порівняння двох зміних та повернення відповіді)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void printInfo() //друкування данних
        {
            Console.WriteLine(dataToStr()); //dataToStr - метод переводу всіх данних в строчні змінні для виводу на екран
        }
        public string dataToStr() //метод переводу всіх данних в строчні змінні для виводу на екран
        {
            string str;
            str = "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" + _adress.adressToString();
            return str;
        }
        
    }
}

