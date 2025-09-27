using System;

namespace Hometask3.TaskLab4.Classes
{
    class Month
    {
        private string name;
        private int days;

        public Month(string name, int days)
        {
            this.name = name;
            this.days = days;
        }

        public int GetDays() // геттер для получения кол-ва дней в месяце
        {
            return days;
        }

        public string GetName() // геттер для получения названия месяца
        {
            return name;
        }
    }
}
