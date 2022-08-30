using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class QA : Employee
    {
        private decimal makan;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal makan ) : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.makan = makan;
            this.Role = "QA";
            JumlahSalary = basicSalary + makan;
            
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} \n" +
                $"|| Tunjangan makan = {this.makan.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total Salary = {JumlahSalary.ToString("C", new CultureInfo("id-ID"))}"; ;
        }
    }
}
