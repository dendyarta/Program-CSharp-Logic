using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Employee
    {
        // instance variable
        private int empId;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string city;
        private string role;
        private decimal jumlahSalary;
        //int totalEmployee;
        //decimal totalSalary;

        //static variable (global variable)
        public static int totalEmployee = 0;
        public static Decimal totalSalary = 0;

        //empty / default constructor
        public Employee()
        {
            totalEmployee++;
            totalSalary += this.BasicSalary;
            this.jumlahSalary = this.BasicSalary;
        }
        // constructor parameter -city , -role
        public Employee(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalSalary += this.BasicSalary;
            this.jumlahSalary = this.BasicSalary;
        }

        //Overloading constructor +city
        public Employee(
            int empId,
            string firstName,
            string lastName,
            DateTime joinDate,
            decimal basicSalary,
            string city
            ) :
            this(
                    empId,
                    firstName,
                    lastName,
                    joinDate,
                    basicSalary
                )
        {
            this.city = city;
        }

        //Overloading constructor +role
        public Employee(
            int empId, 
            string firstName, 
            string lastName, 
            DateTime joinDate, 
            decimal basicSalary, 
            string city, 
            string role
            ) : this(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.role = role;
        }


        

        

        

        //=====================================================================================================================

        //get and set
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary;
            set
            {
                basicSalary = value;
                jumlahSalary = basicSalary;
            }
        }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal JumlahSalary { get => jumlahSalary; set => jumlahSalary = value; }



        //=======================================================================================================

        public override string? ToString()
        {
            return $"Employee : {this.empId} | {this.firstName}  {lastName} | " +
                $"{this.basicSalary} | {this.role} ";
        }

        private decimal GetTotalSalary()
        {
            return this.basicSalary;
        }
    }
}
