using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal class SUV : Car
    {
        private decimal sewa;
        private decimal supir;

        public SUV(string noPolisi, int tahun, decimal sewa, decimal supir) : base(noPolisi, tahun)
        {
            this.Type = "SUV";
            this.sewa = sewa;
            this.supir = supir;
            TotalRevenue = sewa + supir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} \n" +
                $"|| Uang sewa = {this.sewa.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Uang supir = {this.supir.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total Revenue = {TotalRevenue.ToString("C", new CultureInfo("id-ID"))}\n"; ;
        }
    }
}
