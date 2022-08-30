using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Programmer : Employee
    {
        private decimal transportasi;

        public Programmer(
            int empId,
            string firstName,
            string lastName,
            DateTime joinDate,
            decimal basicSalary,
            string city,
            decimal transportasi
            )
            : base(empId, firstName, lastName, joinDate, basicSalary, city)
        {
            this.transportasi = transportasi;
            this.Role = "Programmer";
            JumlahSalary= basicSalary+transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }



        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                $"|| Tunjangan Transportasi = {this.transportasi.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total Salary = {JumlahSalary.ToString("C", new CultureInfo("id-ID"))}";
                
        }


    }
}
