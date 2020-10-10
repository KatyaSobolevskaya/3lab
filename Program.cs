using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            Phone user0 = new Phone("Елена Гилберт", 182, 56, 130, 0);
            Phone user1 = new Phone("Никлаус Майклсон", 539843, 345, 96, 130, 50);
            Phone user2 = new Phone("Тайлер Локвуд", 980567, 678, 85, 234, 8);
            var user3 = new { name = "Тайлер Локвуд", deb = 28900, cred = 346, timeIn = 89, timeOut = 0 };
            Phone.Counter();
            Phone[] Users = new Phone[3];
            Users[0] = user0;
            Users[1] = user1;
            Users[2] = user2;
            
            Console.Write("Введите лимит внутригородских разговоров: ");
            int lim= int.Parse(Console.ReadLine());
            Console.WriteLine("\nАбоненты, у которых время внутригородских разговоров превышает заданное: ");
            for (int i = 0; i < Users.Length; i++) 
            {
                if(Users[i].TimeIn > lim)
                {
                    Output(Users[i]);
                }
            }
            Console.WriteLine("\nАбоненты, которые пользовались междугородной связью: ");
            for (int i = 0; i < Users.Length; i++)
            {
                if (Users[i].TimeOut != 0)
                {
                    Output(Users[i]);
                }
            }
            void Output(Phone Users)
            {
                int z;
                Users.Balance(Users.Cred, Users.Deb, out z);
                Console.WriteLine($"\nИмя: {Users.Name} \nАдрес: {Users.Adress} \nНомер кредитной карточки: {Users.Number} \nДебет: {Users.Deb} " +
                    $"\nКредит: {Users.Cred} \nВремя городских разговоров: {Users.ToString()} \nВремя междугородных разговоров: {Users.TimeOut} часов" +
                    $"\nБаланс на момент {Users.timeNow} составляет: {z} ");
            }

        }
    }
}
