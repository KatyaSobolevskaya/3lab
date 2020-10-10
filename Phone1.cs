using System;
using System.Collections.Generic;
using System.Text;

namespace _3lab
{
    public partial class Phone
    {
        private string name;
        private string adress = "Мистик Фоллс";       //поле- константа
        private int number;
        private int deb;
        private int cred;
        private int timeIn;
        private int timeOut;
        readonly public object timeNow = DateTime.Now;        //поле - только для чтения
        public static int count = 0;
    }
}
