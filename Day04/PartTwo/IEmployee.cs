using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        public void ShowList<T>(ref List<T> list);
        public void ShowDict(ref Dictionary<string, int> dict);

        public Employee FindEmployeeById (List<Employee> list, int id);

        public decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee>FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo);

        // Aggregate summary total employe
        public Dictionary<string, int> GetTotalEmpByRole(List<Employee> list);

    }
}
