using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assign03oop
{
    internal class Employees
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public SecurityPrivileges Securitylevel { get; set; }
        public double Salary { get; set; }
        private Char Gender;
        public char gender
        {
            get { return Gender; }
            set
            {
                if (value == 'M' || value == 'F') Gender = value;
                else return;
            }
        }
        private int Day;
        public int day
        {
            get { return Day; }
            set 
            {
                if (value > 0 && value <= 30) Day = value;
                else return;
            }
        }
        private int Month;
        public int month
        { get {  return Month; }
          set
          {
                if (value > 0 && value <= 12) Month = value;
                else return;
          }
        }
        public int Year { get; set; }

        public Employees(int iD, string name, SecurityPrivileges securitylevel, double salary, int day , int month , int year, Char gender)
        {
            ID = iD;
            Name = name;
            Securitylevel = securitylevel;
            Salary = salary;
            Day = day;
            Month = month;
            Year = year ;
            Gender = gender;
        }
        
        public override string ToString()
        {
            return  $"(ID: {ID}, Name: {Name}, Gender: {Gender}, Security Level: {Securitylevel}, {Salary:C}, Hire Date: {Day:00}/{Month:00}/{Year})";
        }
    }
}
