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
    public class listHuman //публічний клас listHuman
    {
        //створення приватних змінних класу
        private List<Human> listHumans;

        //конструктори
        public listHuman()
        {
            listHumans = new List<Human>();
        }


        public List<Human> List
        {
            get { return listHumans; }
            set { this.listHumans = value; }
        }

        //методи класу
        public void AddHuman(Human a) //метод додавання обьекта класу Human
        {
            listHumans.Add(a);
        }

        public void printHumans()//метод виводу на екран
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                listHumans[i].printInfo();
                Console.WriteLine("________________________________");
            }
        }
        public void printObjByName(string name) //метод друкування об'єктів по імені
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Name == name)
                {
                    listHumans[i].printInfo();
                }

            }
        }
        public void changeObjByName(string name) //метод зміни об'єкта по імені
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Name == name)
                {
                    listHumans[i].changeInfo();
                }

            }
        }

        public string showListStr() //метод відображення списка в текстовому форматі
        {
            string listData = "";
            for (int i = 0; i < listHumans.Count(); i++)
                listData += listHumans[i].dataToStr();
            return listData;
        }

        public void sortByAgeLowToHigh() //метод сортування по віку по зростанню
        {
            List<Human> list = listHumans;
            Human temp;
            for (int i = 1; i < list.Count(); i++)
            {
                for (int j = 1; j < list.Count(); j++)
                {
                    if (list[j] < list[j - 1])
                    {
                        temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
        public void sortByAgeHightToLow() //метод сортування по віку по спаданню
        {
            List<Human> list = listHumans;
            Human temp;
            for (int i = 1; i < list.Count(); i++)
            {
                for (int j = 1; j < list.Count(); j++)
                {
                    if (list[j] > list[j - 1])
                    {
                        temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
        }
    }
}
