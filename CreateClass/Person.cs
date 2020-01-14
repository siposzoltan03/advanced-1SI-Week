using System;

namespace CreateClass
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private Enum gender;

        public Person(string name, DateTime birthDate, Enum gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {this.name}\nBirthdate: {this.birthDate}\nGender: {this.gender}\n";
        }

        public static void Main(string[] args)
        {
            Person male = new Person("Mike", new DateTime(1990, 12, 14), Gender.Male);
            Person female = new Person("Katy", new DateTime(1984, 04, 21), Gender.Female);

            Console.WriteLine(male.ToString());
            Console.WriteLine(female.ToString());
        }
    }
}
