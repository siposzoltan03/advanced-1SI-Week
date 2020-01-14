using System;
using System.Dynamic;

namespace CreateClass
{
    public class Employee : Person
    {
        private readonly string Profession;
        private int Salary { get; set; }
        private Room room;
        public Employee(string name, DateTime birthDate, Enum gender, int salary, string profession, Room room) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
            this.room = room;
        }

        public override string ToString()
        {
            return $"Name: {base.Name}\n" +
                   $"Birthdate: {base.BirthDate}\n" +
                   $"Gender: {base.Gender}\n" +
                   $"Profession: {this.Profession}\n" +
                   $"Salary:{this.Salary} HUF\n" +
                   $"Room: {this.room.Number}";

        }
    }
}