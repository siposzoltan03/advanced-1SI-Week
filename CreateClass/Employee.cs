using System;
using System.Dynamic;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {

        private readonly string Profession;
        private int Salary { get; set; }
        public Room Room = new Room();

        public Employee(string name, DateTime birthDate, Enum gender, int salary, string profession) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public override string ToString()
        {
            return $"Name: {base.Name}\n" +
                   $"Birthdate: {base.BirthDate}\n" +
                   $"Gender: {base.Gender}\n" +
                   $"Profession: {this.Profession}\n" +
                   $"Salary:{this.Salary} HUF\n" +
                   $"Room:{this.Room.Number}\n";

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}