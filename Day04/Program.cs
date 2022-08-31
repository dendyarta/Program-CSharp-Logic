using Day04.PartTwo;

Console.WriteLine();
Console.WriteLine("============================ Implementation Interface ==========================");
Console.WriteLine();

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);
Console.WriteLine();


var emp = empInf.FindEmployeeById(listOfEmps, 123);
Console.WriteLine($"Found : {emp}");

var total = empInf.GetTotalSalary(ref listOfEmps);
Console.WriteLine($"Total Salary : {emp}");

Console.WriteLine("============= Salary Range =============");

var empSalRange = empInf.FindSalaryRange(listOfEmps, 2_000_000, 4_500_000);
empInf.ShowList(ref empSalRange);

var countCarType = empInf.GetTotalEmpByRole(listOfEmps);
empInf.ShowDict(ref countCarType);
Console.WriteLine();

Console.ReadLine();



















// call class employee
//using Day04.PartOne;

/*//gunakan encapsulation untuk memanipulasi attribute object
emp1.empId = 123;
emp1.firstName = "Jhony";
emp1.lastName = "Andrean";
*/
/*
//setiap create object instant, gunakan operator
Employee emp1 = new Employee();
emp1.EmpId = 8701;
emp1.FirstName = "Jhony";
emp1.LastName = "Andrean";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 8_000_000;
emp1.City = "Lampung";
emp1.Role = "Programmer";


//create object with parameter constructor
Employee emp2 = new Employee(8702, "Jhonny", "Deep", new DateTime(), 6_000_000);
emp2.Role = "Sales";
Employee emp3 = new Employee(8703, "Jhony", "Angur", new DateTime(), 45_000_000, "Bogor" );
emp3.Role = "QA";
Employee emp4 = new Employee(8704, "Jhony", "Walker", new DateTime(), 6_000_000, "Jakarta", "Sales");

Console.WriteLine(emp1.ToString());
Console.WriteLine(emp2.ToString());
Console.WriteLine(emp3.ToString());
Console.WriteLine(emp4.ToString());
Console.WriteLine($"Total Employee : {Employee.totalEmployee}");
Console.WriteLine($"Total Employee Basic Salary : {Employee.totalSalary}");

Console.WriteLine();
Console.WriteLine($"====================List Employee=====================");
Console.WriteLine();

//create object programmer
Programmer prog1 = new Programmer(8704, "Jhonny", "jack", new DateTime(2021, 7, 12), 5_500_000,
                                    "bogor", 500_000);

//store to List
List<Employee> Listemps = new List<Employee>() { emp1, emp2, emp3, emp4, prog1 };

foreach (var item in Listemps)
{
    Console.WriteLine($"{item} ");
}

*/

// ============================== tugas Harian =====================================
/*
Console.WriteLine();
Console.WriteLine($"====================List Programmer=====================");
Console.WriteLine();
Programmer prog1 = new Programmer(120, "Anton", "Pratama", new DateTime(2015, 03, 03), 6_000_000,
                                    "Kalimantan", 500_000);
Programmer prog2 = new Programmer(121, "Budi", "Junaedi", new DateTime(2016, 08, 15), 6_000_000,
                                    "Palembang", 500_000);
Programmer prog3 = new Programmer(122, "Charlie", "Van Dijk", new DateTime(2017, 09, 05), 6_000_000,
                                    "Yogja", 500_000);
//store to List
List<Employee> ListProg = new List<Employee>() { prog1, prog2, prog3 };

foreach (var item in ListProg)
{
    Console.WriteLine($"{item} ");
}

Console.WriteLine();
Console.WriteLine($"====================List Sales=====================");
Console.WriteLine();

Sales Sales1 = new Sales(123, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000,
                                    "Kalimantan", 500_000, 200_000);
Sales Sales2 = new Sales(125, "Fatur", "Rohman", new DateTime(2019, 01, 15), 3_000_000,
                                    "Palembang", 350_000, 250_000);

List<Employee> ListSales = new List<Employee>() { Sales1, Sales2 };

foreach (var item in ListSales)
{
    Console.WriteLine($"{item} ");
}

Console.WriteLine();
Console.WriteLine($"====================List QA=====================");
Console.WriteLine();

QA QA1 = new QA(124, "Ellise", "Toon", new DateTime(2019, 01, 15), 4_500_000,
                                    "Semarang", 10_000);
QA QA2 = new QA(126, "Gita", "Gutawa", new DateTime(2019, 03, 01), 4_500_000,
                                    "Sukabumi", 10_000);

List<Employee> ListQA = new List<Employee>() { QA1, QA2 };

foreach (var item in ListQA)
{
    Console.WriteLine($"{item} ");
}
*/
