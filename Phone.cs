using System;
using System.Collections.Generic;
using System.Text;
/*Создать класс Phone: id, Фамилия, Имя, Отчество,
Адрес, Номер кредитной карточки, Дебет, Кредит,
Время городских и междугородных разговоров. Свойства
и конструкторы должны обеспечивать проверку
корректности. Добавить метод расчет баланса на
текущий момент.
Создать массив объектов. Вывести:
a) сведения об абонентах, у которых время внутригородских
разговоров превышает заданное;
b) сведения об абонентах, которые пользовались
междугородной связью;*/
namespace _3lab
{
    partial class Phone
    {
   public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
           private set
            {
                adress = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if ( Math.Abs(value).ToString().Length==6)
                { number = value; }
                else
                { Console.WriteLine("Введено неверное значение"); }
            }
        }
        public int Deb
        {
            get
            {
                return deb;
            }
            set
            {
                deb = value;
            }
        }
        public int Cred
        {
            get
            {
                return cred;
            }
            set
            {
                cred = value;
            }
        }
        public int TimeIn
        {
            get
            {
                return timeIn;
            }
            set
            {
                timeIn = value;
            }
        }
        public int TimeOut
        {
            get
            {
                return timeOut;
            }
            set
            {
                timeOut = value;
            }
        }
        public void Balance( int income,  int spending, out int s)
        {
            s= spending - income;
        }
        public Phone()
        {
            count++;
        }
        static int GetCounter()
        {
            return count;
        }
        public static void Counter()
        {
            Console.WriteLine("Количество созданных объектов: "+Phone.GetCounter());
        }
        public override bool Equals(object obj)
        {
            
            if (obj == null)
            {
                return false;
            }
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"{timeIn} часов";
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public Phone(string n,  int nu, int d, int c, int ti, int to) { name = n;  number = nu; deb = d; cred = c; timeIn = ti; timeOut = to; count++; }     //конструктор с параметрами
        public Phone(string n,  int d, int c, int ti, int to) { name = n;  deb = d; cred = c; timeIn = ti; timeOut = to; number = 489087; count++; }     //конструктор с параметрами по умолчанию
        static Phone() { }      //статический конструктор без параметров
        private Phone(string n) { }         //закрытый конструктор не допускает создания объекта


    }
}
