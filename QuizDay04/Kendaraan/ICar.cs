using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal interface ICar
    {
        public List<Car> InitDataEmployee();

        public void ShowList<T>(ref List<T> list);
        public Dictionary<string, decimal> GetTotalRev(List<Car> list);

        public Dictionary<string, int> GetTotalCarType(List<Car> list);
        public void ShowDict1(ref Dictionary<string,int> dict);
        public void ShowDict2(ref Dictionary<string, decimal> dict);

        public List<Car> FindRevenueRange(List<Car> list, decimal startFrom, decimal endTo);
    }
}
