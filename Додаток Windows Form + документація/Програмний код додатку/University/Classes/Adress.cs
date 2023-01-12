//імпортуєм типи данних з одного простір імен (using) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//створюємо простір імен University
namespace University
{
    public class Adress //публічний клас Adress
    {
        //створення приватних змінних класу
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        //конструктори
        public Adress() //конструктор за замовчуванням
        {
            this._country = "Ukraine";
            this._city = "Kherson";
            this._street = "Poltawska";
            this._house = 44;
        }

        public Adress(string country, string city, string street, int house) //констуктор з параметром
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
        }

        //методи доступу до змінних класу
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }

        //методи класу
        public string adressToString() //метод переведення даних до текстового формату
        {
            return
                "Country: " + this._country + "\n" +
                "City: " + this._city + "\n" +
                "Street: " + this._street + "\n" +
                "House: " + this._house.ToString();
        }

        public Adress inputAdress() //метод вводу данних з клавіатури
        {
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine("City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Street: ");
            string street = Console.ReadLine();
            Console.WriteLine("House: ");
            int house = int.Parse(Console.ReadLine());
            Adress adress = new Adress(country, city, street, house);
            return adress;
        }
    }
}


