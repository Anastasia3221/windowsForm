//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.Collections.Generic;

//створюємо простір імен University
namespace University
{
    enum Subject { None, Math, Fisics, History, Biology, English } //створення перерахування предметів(Subject)

    public class Teacher : Human //публічний клас Teacher який є дочірним від класа Human
    {
        //створення приватних змінних класу
        private Subject _subject;
        private List<Student> _students;
        private int _salary;

        //конструктори
        public Teacher() : base() //конструктор за замовчуванням
        {
            _students = new List<Student>();
                this._subject = Subject.None;
            this._salary = 6500;
        }
        public Teacher(string name, string surname, int age, Adress adress, int salary) : base(name, surname, age, adress) //констуктор з параметром
        {
            _students = new List<Student>();
            this._salary = salary;
        }

        //методи доступу до змінних класу
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }
        public int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        //методи класу
        public string getStudentsStr() //метод що певертає данні студента в тектовому форматі
        {
            string result = "";
            for (int i = 0; i < _students.Count; i++) {
                result += _students[i].Name + " " + _students[i].Surname + "\n";
                    }
            return result;
        }

        public void printInfo() //друкування данних
        {
            Console.WriteLine(dataToStr()); //dataToStr - метод переводу всіх данних в строчні змінні для виводу на екран
        }
        public string dataToStr() //метод переводу всіх данних в строчні змінні для виводу на екран
        {
            string str;
            str = base.dataToStr() + "\n" + "Subject: " + _subject.ToString() + "\n" + "Salary" + _salary + "\n" + "Person Data:";
            return str;
        }

        public void AddStudent(Student student) // метод додавання нового студента
        {
            _students.Add(student);
        }
    }
}

