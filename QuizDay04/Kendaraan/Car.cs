using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDay04.Kendaraan
{
    internal class Car
    {
        // instance variable
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue = 0M;


        // Empty Construktor
        public Car()
        {
        }
        // constructor -type
        public Car(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
        }

        // constructor parameter +type
        

        

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"Nomer Polisi : {this.noPolisi} | Tahun : {this.tahun} | Type : {this.type} \n";
        }
    }
}
