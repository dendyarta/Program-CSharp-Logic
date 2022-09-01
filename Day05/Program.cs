using static System.Console;
using Day05;

Person yuli = new Customer ( "Yuli", "Ayu", "yuli@gmail.com", new DateTime(1998, 04, 24), "131-001" );
Customer widi = new Customer ( "Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 09, 30), "131-002" );
Customer rini = new Customer ( "Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 08, 04), "131-003" );

var listOfCustomer = new List<Person> { yuli, widi, rini };

var incomeYuli = new Dictionary<string, decimal>
{
    {"Kontrakan", 10_000_000 },
    {"Toko", 100_000_000 },
};

yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
    {"Kosan", 20_000_000 },
    {"Jual Online", 600_000 },
};

widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal>
{
    {"Supermarket", 50_000_000 },
    {"Rental Mobil", 40_000_000 },
};

rini.TotalRevenue = rini.TotalIncome(incomeRini);



foreach (var item in listOfCustomer)
{
    WriteLine(item.ToString());
}

WriteLine("==============Revenue Highest=================\n");

var listRange = listOfCustomer.Where(c => c.TotalRevenue <= 50_000_000).ToList();
foreach (var item in listRange)
{
    WriteLine(item.ToString());
}

var listMin = listOfCustomer.Min(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMin}");

var listMax = listOfCustomer.Max(x => x.TotalRevenue);
WriteLine($"Cust Min Revenue : {listMax}");

var listLessThanMax = listOfCustomer.Where(x => x.TotalRevenue < listMax);
WriteLine("\n==============Revenue less then Highest=================\n");

foreach (var item in listLessThanMax)
{
    WriteLine(item.ToString());
}

WriteLine("================== Select =================\n");
var query = listOfCustomer.Select(cust =>
    new 
    {
        Fullname = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRevenue = cust.TotalRevenue
    }

);
foreach (var item in query)
{
    WriteLine(item);
}

/*
WriteLine("==================intro LinQ====================");

LinQ.IntroLinq();*/