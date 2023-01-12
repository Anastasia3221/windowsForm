//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

//створюємо простір імен University
namespace University
{
    public class Student : Human //публічний клас Student який є дочірним від класа Human
    {
        //створення приватних змінних класу
        private int _admissionYear;
        private List<Subject> _subjectSet;
        private List<List<string>> _grades;

        //конструктори
        public Student() : base() //конструктор за замовчуванням
        {
            this._admissionYear = 2021;
        }
        public Student(string name, string surname, int age, Adress adress,int admissionYear) : base(name, surname, age, adress) //констуктор з параметром
        {
            this._admissionYear = admissionYear;
        }


        //методи доступу до змінних класу
        public int AdmissionYear
        {
            get { return this._admissionYear; }
            set { this._admissionYear = value; }
        }

        public List<List<string>> Grades
        {
            get { return this._grades; }
            set { this._grades = value; }
        }

        //методи класу
        public string dataToStr() //метод переводу всіх данних в строчні змінні для виводу на екран
        {

            string str;
            str = base.dataToStr() + "\n" + "Subject: " + _admissionYear.ToString() + "\n" + "Person Data:";
            return str;
        }
    }
}
