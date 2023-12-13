using System;

namespace Common
{
    public class Person
    {
        private string name;
        private DateTime birthday;

        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public int Age()
        {
            int age = Age(DateTime.Today);

            return age;
        }

        public int Age(DateTime today)
        {
            int todayYear = today.Year;
            int myYear = this.birthday.Year;

            int age = todayYear - myYear + 1;

            return age;
        }
        public int myBirthdayYear()
        {
            return this.birthday.Year;
        }
    }
}
