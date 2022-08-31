using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal class Angkot : Car
    {
        private decimal hargaTiket;
        private decimal totalPenumpang;

        public Angkot(string noPolisi, int tahun, decimal hargaTiket, decimal totalPenumpang ) : base(noPolisi, tahun)
        {
            this.Type = "Angkot";
            this.hargaTiket = hargaTiket;
            this.totalPenumpang = totalPenumpang;
            TotalRevenue = totalPenumpang * hargaTiket;
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public decimal TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} \n" +
                $"|| Total Penumpang  = {this.totalPenumpang}\n" +
                $"|| Harga Tiket      = {this.hargaTiket.ToString("C", new CultureInfo("id-ID"))}\n" +
                $"|| Total Revenue = {TotalRevenue.ToString("C", new CultureInfo("id-ID"))}\n" ;
        }
    }
}
