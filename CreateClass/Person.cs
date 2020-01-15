using System;
using System.Runtime.InteropServices;

namespace CreateClass
{
    public class Person
    {
        protected string Name;
        protected DateTime BirthDate;
        protected Enum Gender;

        protected Person(string name, DateTime birthDate, Enum gender)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nBirthdate: {this.BirthDate}\nGender: {this.Gender}\n";
        }

        public static void Main(string[] args)
        {
            Person male = new Person("Mike", new DateTime(1990, 12, 14), CreateClass.Gender.Male);
            Person female = new Person("Katy", new DateTime(1984, 04, 21), CreateClass.Gender.Female);
            Employee employee = new Employee("Lölö", new DateTime(1900, 01, 01), CreateClass.Gender.Male, Int32.MaxValue, "Gas-fitter");
            employee.Room.Number = 110;


            Console.WriteLine(male.ToString());
            Console.WriteLine(female.ToString());
            Console.WriteLine(employee.ToString());
        }
    }
}
