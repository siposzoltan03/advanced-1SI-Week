using System;
using System.Dynamic;

namespace CreateClass
{
    public class Employee : Person
    {
        private string Profession;
        private int Salary { get; set; }
        public Employee(string name, DateTime birthDate, Enum gender, int salary, string profession) : base(name, birthDate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public override string ToString()
        {
            return $"Name: {base.Name}\nBirthdate: {base.BirthDate}\nGender: {base.Gender}\nProfession: {this.Profession}\nSalary:{this.Salary}";

        }
    }
}