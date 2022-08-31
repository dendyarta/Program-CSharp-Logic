using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal abstract class Person
    {
        private int socialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDay;
        private decimal totalRevenue;


        // Constructor
        protected Person( 
            string firstName, 
            string lastName, 
            string email, 
            DateTime birthDay
            )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
        }

        public int SocialNumber { get => socialNumber; set => socialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"Social Number  : {this.socialNumber}\n" +
                   $"Full Name      : {this.firstName} {this.lastName}\n" +
                   $"Email          : {this.email}\n" +
                   $"BirthDay       : {this.birthDay} \n"+
                   $"TotalRevenue   : {this.totalRevenue.ToString("C", new CultureInfo("id-ID"))} \n";
        }

        public abstract decimal TotalIncome(Dictionary<string, decimal> data);
    }
}
