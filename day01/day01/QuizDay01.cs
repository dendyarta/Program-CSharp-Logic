using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class QuizDay01
    {
        //No.1 Buat program untuk menghitung summary dari angka yang diinput seperti contoh dibawah

        public static void nomersatu()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;
           

            while (number > 0)
            {
                hasil = hasil + (number % 10);
                number = number / 10;
            }

            Console.WriteLine("Hasil dari angka yang di input = " + hasil);
        }

        //2.Buat program untuk menghitung jumlah digit yang diinput. Tidak dibolehkan menggunakan string.length().
        public static void nomerdua()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;
            int ngitung = 0;

            while (number > 0)
            {
                hasil = hasil + (number % 10);
                number = number / 10;
                ngitung++;
            }

            Console.WriteLine("Jumlah angka yang di input = " + ngitung);
        }

        //3. Buat program dengan inputan integer dan output seperti contoh.
        public static void nomertiga()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string panjang = Convert.ToString(number);

            int hasil = 0;
            int ngitung = 0;

            while (number > 0)
            {
                hasil = (number % 10);
                number = number / 10;
                Console.Write($"{hasil} ");
            }
        }

        //4.Buat program untuk menampilkan bilangan terbesar kedua dengan inputan dinamis.Tidak dibolehkan angka inputan dikurang 1.
        public static void nomerempat()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int kedua = 0;

            for (int i = 1; i < number; i++)
            {
                kedua++;
            }

            Console.WriteLine($"Second greates : {kedua}");
        }

        //5. Buat program GuessNumber, dimana user input angka untuk menebak random number, jika
        // benar munculkan return message, seperti display dibawah ini :

        public static void nomerlima()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter you Guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                //cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"You're right, number {guess}");
                    Console.WriteLine("tebak lagi? ");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        QuizDay01.nomerlima();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("You are quit");

                    }
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess is to hight. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is to low. Try again!");
                }

            }
        }

        //6. Buat program menampilkan angka terbesar seperti screen dibawah ini :
        public static void nomerenam()
        {

            int number ;
            int terbesar = 0;
            int n = 0;

            for (int i = 1; i < n; i++)
            {
                Console.Write(" Masukan angka : ");
                number = Convert.ToInt32(Console.ReadLine());
                if (terbesar < number)
                {
                    terbesar = number;
                }
                else if (number == 0)
                {
                    n = number;
                    Console.WriteLine(terbesar);
                     
                } 

            }
            
        }
        //7. Buat program untuk menampilkan angka pembagi dari sebuah bilangan, contoh :

        public static void nomertujuh()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //8.Buat program untuk menampilkan bilangan prima dalam range tertentu

        public static void nomerlapan()
        {
            Console.Write(" Masukan angka : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                int prima = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        prima= prima+1;
                    }
                }
                if (prima == 2)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        //9.Buat program untuk men-check apakah kata yang diinput palindrome, palindrome adalah kata
        //yang jika dibaca dari depan atau belakang memiliki karakter yang sama.

        public static void nomersembilan()
        {
            Console.Write(" Masukan string : ");
            string kata = Console.ReadLine();
            string kalimat = "";
            kata = kata.ToLower();

            for (int i = 0; i < kata.Length; i++)
            {
                
                kalimat = kalimat + kata[kata.Length-i-1].ToString();
                
            }
            if (kalimat == kata)
            {
                Console.WriteLine("Polindrome");
            }
            else
            {
                Console.WriteLine("Bukan Polindrome");
            }
        }

        //10. Buat program untuk menghitung jumlah huruf vocal dan consonant dalam sebuah kalimat
        public static void nomersepuluh()
        {
            int vowel = 0;
            int consonan = 0;

            Console.Write(" Masukan string : ");
            string kata = Console.ReadLine();
            kata = kata.ToLower();

            for (int i = 0; i < kata.Length; i++)
            {
                if (
                    kata[i] == 'a' ||
                    kata[i] == 'i' ||
                    kata[i] == 'u' ||
                    kata[i] == 'e' ||
                    kata[i] == 'o' 
                    )
                {
                    vowel = vowel + 1;
                }
                else if (kata[i] == ' ')
                {
                    //nothing
                }
                else
                {
                    consonan = consonan + 1;
                }
            }
            Console.WriteLine($"total vowel = {vowel}");
            Console.WriteLine($"total consonant = {consonan}");

        }

        //11. Buat program untuk menghitung jumlah kata dalam kalimat yang diinput
        public static void nomersebelas()
        {
            int spasi = 1;

            Console.Write(" Masukan string : ");
            string kata = Console.ReadLine();
            kata = kata.ToLower();

            for (int i = 0; i < kata.Length; i++)
            {
                if ( kata[i] == ' ' )
                {
                    spasi = spasi + 1;
                }
                else
                {
                    
                }
            }
            Console.WriteLine($"total kata = {spasi}");
        }

        //12.
        public static void CountStringInString()
        {
            Console.Write("Enter strings : ");
            string? input = Console.ReadLine();
            Console.Write("Find string: ");
            string? findStr = Console.ReadLine();



            int position = 0;
            int count = 0;
            int n = findStr.Length;
            while ((position = input.IndexOf(findStr, position)) != -1)
            {
                position = position + n;
                count++;
            }

            Console.WriteLine($"Total kata yang muncul : {count.ToString()} dari text : {input}");
        }


        //13. Buat program untuk menampilkan berapa hari lagi ke hari jumat
        public static void nomergabelas()
        {
            DateTime now = DateTime.Now;
            DayOfWeek Sabtu = DayOfWeek.Saturday;
            DayOfWeek today = now.DayOfWeek;
            int dayRemaining = Sabtu - today;
            Console.WriteLine($"Hari Sabtu : {now.Add}");
            Console.WriteLine($"{dayRemaining} hari");
        }

        //14.Buat program untuk menampilkan jumlah kata yang dicari seperti contoh berikut (gunakan method IndexOf):
        public static void FindPattern()
        {
            Console.WriteLine("Masukan Text : ");
            string input = Console.ReadLine();
            Console.WriteLine("Temukan Pola : ");
            string pola = Console.ReadLine();

            int a = 0;
            int jumlah = 0;

            while ((a = input.IndexOf(pola, a)) != -1)
            {
                a += pola.Length;
                jumlah++;
            }
            Console.WriteLine($"{pola} muncul sebanyak : {jumlah}");

        }

        //15.
        public static void nomermabelas()
        {

            int number;
            int terbesar = 0;
            int kedua = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write(" Masukan angka : ");
                number = Convert.ToInt32(Console.ReadLine());
                if (terbesar < number)
                {
                    kedua = terbesar;
                    terbesar = number;
                }

            }
            Console.WriteLine(terbesar);
        }
    }
}
