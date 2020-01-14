using System;

namespace CreateClass
{
    public class Person
    {
        protected string Name;
        protected DateTime BirthDate;
        protected Enum Gender;

        public Person(string name, DateTime birthDate, Enum gender)
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

            Console.WriteLine(male.ToString());
            Console.WriteLine(female.ToString());
        }
    }
}
