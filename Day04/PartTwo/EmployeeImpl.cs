using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee? emps = null;

            foreach (var item in list)
            {
                if (item.EmpId == id)
                {
                    emps = item;
                }
            }
            
            return emps;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if (item.JumlahSalary >= startFrom && item.JumlahSalary <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetTotalEmpByRole(List<Employee> list)
        {
            int countSUV = 0;
            int countTax = 0;
            int countAng = 0;

            var dict = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if (item.Role == "Programmer")
                {
                    countSUV++;
                }
                else if (item.Role == "Sales")
                {
                    countTax++;
                }
                else if (item.Role == "QA")
                {
                    countAng++;
                }
            }
            dict.Add("Programmer", countSUV);
            dict.Add("Sales", countTax);
            dict.Add("QA", countAng);

            return dict;
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            foreach (var item in list.OfType<Employee>())
            {
                total += item.JumlahSalary;
            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
            
            Programmer prog1 = new Programmer(120, "Anton", "Pratama", new DateTime(2015, 03, 03), 6_000_000,
                                                "Kalimantan", 500_000);
            Programmer prog2 = new Programmer(121, "Budi", "Junaedi", new DateTime(2016, 08, 15), 6_000_000,
                                                "Palembang", 500_000);
            Programmer prog3 = new Programmer(122, "Charlie", "Van Dijk", new DateTime(2017, 09, 05), 6_000_000,
                                                "Yogja", 500_000);
            Sales Sales1 = new Sales(123, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000,
                                                "Kalimantan", 500_000, 200_000);
            Sales Sales2 = new Sales(125, "Fatur", "Rohman", new DateTime(2019, 01, 15), 3_000_000,
                                                "Palembang", 350_000, 250_000);
            QA QA1 = new QA(124, "Ellise", "Toon", new DateTime(2019, 01, 15), 4_500_000,
                                                "Semarang", 10_000);
            QA QA2 = new QA(126, "Gita", "Gutawa", new DateTime(2019, 03, 01), 4_500_000,
                                                "Sukabumi", 10_000);


            // direct return without variable
            return new List<Employee> { prog1, prog2, prog3, Sales1, Sales2, QA1, QA2 };

 /*         =========================== store to List ==================================
            List<Employee> ListProg = new List<Employee>() { prog1, prog2, prog3 };

            foreach (var item in ListProg)
            {
                Console.WriteLine($"{item} ");
            }

            List<Employee> ListSales = new List<Employee>() { Sales1, Sales2 };

            foreach (var item in ListSales)
            {
                Console.WriteLine($"{item} ");
            }

            List<Employee> ListQA = new List<Employee>() { QA1, QA2 };

            foreach (var item in ListQA)
            {
                Console.WriteLine($"{item} ");
            }

*/            //throw new NotImplementedException();
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
        public void ShowDict(ref Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        //throw new NotImplementedException();
    }
}
