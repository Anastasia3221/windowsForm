//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//створюємо простір імен University
namespace University
{
    public class listTeacher : listHuman //публічний клас listTeacher який є дочірним від класа listHuman
    {
        //створення приватних змінних класу
        private List<Teacher> _listTeachers;

        //конструктори
        public listTeacher()
        {
            _listTeachers = new List<Teacher>();
        }

        //методи доступу до змінних класу
        public List<Teacher> List
        {
            get { return _listTeachers; }
            set { this._listTeachers = value; }
        }

        public void addNewTeacher(Teacher teacher) //метод створення нового обьекта класу Teacher
        {
            _listTeachers.Add(teacher);
        }
        public void AddTeacher(Teacher a) //метод додавання обьекта класу Teacher
        {
            _listTeachers.Add(a);
        }
        public void printTeachers() //метод виводу на екран
        {
            for (int i = 0; i < _listTeachers.Count(); i++)
            {
                _listTeachers[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name) //метод друкування об'єктів по імені
        {
            for (int i = 0; i < _listTeachers.Count(); i++)
            {
                if (_listTeachers[i].Name == name)
                {
                    _listTeachers[i].printInfo();
                }
            }
        }

        public string showListStr() //метод відображення списка в текстовому форматі
        {
            string listData = "";
            for (int i = 0; i < _listTeachers.Count(); i++)
                listData += _listTeachers[i].dataToStr();
            return listData;
        }
    }
}
