/****************************
** Employee.cs
** Employee Management 3
** Patrick Xie, 4/28/2011,
****************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace q428
{
    class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int salary;
        //default constructor
        public Employee()
        {
            firstName = "No";
            lastName = "Name";
            salary = 0;
        }
        //constructor to have user set values
        public Employee(string newFirstName, string newLastName, int newSalary)
        {
            firstName = newFirstName;
            lastName = newLastName;
            salary = newSalary;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public int getSalary()
        {
            return salary;
        }
        //override string for displaying job and name in listbox
        public override string ToString()
        {
            return "Employee " + firstName + " " + lastName;
        }
    }
    class Manager : Employee
    {
        protected string store;
        //default constructor
        public Manager()
        {
            firstName = "No";
            lastName = "Name";
            salary = 0;
            store = "N/A";
        }
        //constructor to have user set values
        public Manager(string newFirstName, string newLastName, int newSalary, string newStore)
        {
            firstName = newFirstName;
            lastName = newLastName;
            salary = newSalary;
            store = newStore;
        }
        public string getStore()
        {
            return store;
        }
        //override string for displaying job and name in listbox
        public override string ToString()
        {
            return "Manager " + firstName + " " + lastName;
        }
    }
    class Peon : Employee
    {
        protected int hours;
        //default constructor
        public Peon()
        {
            firstName = "No";
            lastName = "Name";
            salary = 0;
            hours = 0;
        }
        //constructor to have user set values
        public Peon(string newFirstName, string newLastName, int newSalary, int newHours)
        {
            firstName = newFirstName;
            lastName = newLastName;
            salary = newSalary;
            hours = newHours;
        }
        public int getHours()
        {
            return hours;
        }
        //override string for displaying job and name in listbox
        public override string ToString()
        {
            return "Peon " + firstName + " " + lastName;
        }
    }
    class Trainer : Employee
    {
        protected string subject;
        //default constructor
        public Trainer()
        {
            firstName = "No";
            lastName = "Name";
            salary = 0;
            subject = "N/A";
        }
        //constructor to have user set values
        public Trainer(string newFirstName, string newLastName, int newSalary, string newSubject)
        {
            firstName = newFirstName;
            lastName = newLastName;
            salary = newSalary;
            subject = newSubject;
        }
        public string getSubject()
        {
            return subject;
        }
        //override string for displaying job and name in listbox
        public override string ToString()
        {
            return "Trainer " + firstName + " " + lastName;
        }
    }
}
