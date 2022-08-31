using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal class Taxi : Car
    {
        private decimal order;
        private decimal orderPerKM;
        private decimal totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, decimal order, decimal orderPerKM, decimal totalKM, decimal bonus) : base(noPolisi, tahun)
        {
            this.Type = "Taxi";
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public decimal Order { get => order; set => order = value; }
        public decimal OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public decimal TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} \n" +
                $"|| Order     = {this.order}\n" +
                $"|| Order /KM = {this.orderPerKM.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total KM  = {this.totalKM}\n" +
                $"|| Bonus     = {this.bonus.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total Revenue = {TotalRevenue.ToString("C", new CultureInfo("id-ID"))}\n" ;
        }
    }
}
