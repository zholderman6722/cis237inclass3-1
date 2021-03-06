﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Variables
        private decimal _weeklySalary;

        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //Methods
        public string NameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        //Override the ToString method that is in the parent class Employee
        public override string ToString()
        {
            //Take the string the parent's ToString will return, and concat the weeklySalary to it.
            //Must use the keywork base if trying to access the parents version of the method.
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary;
        }

        //Override the abstract method in the Employee class. Because the Employee class declares the
        //method as abstract, this class MUST implement it.
        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
        }

        //Constructor
        public SalaryEmployee(string FirstName, string LastName,
            DateTime StartDate, decimal WeeklySalary)
            //This next part calls the parent classes constructor so that we dont't have
            //to repeat the work that the parent constructor is doing.
            : base(FirstName, LastName, StartDate)
        {
            _weeklySalary = WeeklySalary;
        }

        public SalaryEmployee() : base() { }
    }
}
