using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal class CarImpl : ICar
    {
        public List<Car> FindRevenueRange(List<Car> list, decimal startFrom, decimal endTo)
        {
            var revRange = new List<Car>();

            foreach (var item in list)
            {
                if (item.TotalRevenue >= startFrom && item.TotalRevenue <= endTo)
                {
                    revRange.Add(item);
                }
            }

            return revRange;
        }

        public Dictionary<string, int> GetTotalCarType(List<Car> list)
        {
            int countSUV = 0;
            int countTax = 0;
            int countAng = 0;

            var dict = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    countSUV++;
                }
                else if (item.Type == "Taxi")
                {
                    countTax++;
                }
                else if (item.Type == "Angkot")
                {
                    countAng++;
                }
            }
            dict.Add("SUV", countSUV);
            dict.Add("Taxi", countTax);
            dict.Add("Angkot", countAng);

            return dict;
        }

        public Dictionary<string, decimal> GetTotalRev(List<Car> list)
        {
            decimal countSUV = 0;
            decimal countTax = 0;
            decimal countAng = 0;

            var dict = new Dictionary<string, decimal>();

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    countSUV += item.TotalRevenue;
                }
                else if (item.Type == "Taxi")
                {
                    countTax += item.TotalRevenue;
                }
                else if (item.Type == "Angkot")
                {
                    countAng += item.TotalRevenue;
                }
            }
            dict.Add("SUV", countSUV);
            dict.Add("Taxi", countTax);
            dict.Add("Angkot", countAng);

            return dict;
        }

        public List<Car> InitDataEmployee()
        {
            SUV suv1 = new SUV("D 1001 UM", 2005, 500_000, 100_000);
            SUV suv2 = new SUV("D 1002 UM", 2019, 500_000, 100_000);
            Taxi taxi1 = new Taxi("D 88 UK", 2018, 5, 4_500, 40, 10_000);
            Taxi taxi2 = new Taxi("D 87 UK", 2018, 10, 4_500, 100, 10_000);
            Angkot angkot1 = new Angkot("D 55 UJ", 2016, 4_500, 35);
            Angkot angkot2 = new Angkot("D 56 UJ", 2015, 4_500, 40);


            return new List<Car> { suv1, suv2, taxi1, taxi2, angkot1, angkot2 };
        }

        public void ShowDict1(ref Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
        public void ShowDict2(ref Dictionary<string, decimal> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
