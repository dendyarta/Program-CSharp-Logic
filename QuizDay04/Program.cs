using QuizDay04;
using QuizDay04.Kendaraan;

Console.WriteLine();
Console.WriteLine("============================ Implementation Interface ==========================");
Console.WriteLine();

ICar carInf = new CarImpl();

var listOfEmps = carInf.InitDataEmployee();

/* ===================== List Car ===========================
carInf.ShowList(ref listOfEmps);
Console.WriteLine();
*/

//====================== count car / type ==========================
var countCarType = carInf.GetTotalCarType(listOfEmps);
carInf.ShowDict1(ref countCarType);
Console.WriteLine();

//====================== Total Revenue ==========================
var countRevType = carInf.GetTotalRev(listOfEmps);
carInf.ShowDict2(ref countRevType);
Console.WriteLine();

//====================== Revenue Range ==========================
var revRangee = carInf.FindRevenueRange(listOfEmps, 500_000, 600_000);
carInf.ShowList(ref revRangee);
Console.WriteLine();
