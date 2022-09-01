using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class QuizLogicDay02
    {
        public static void DisplayArrayInt(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        public static int[] RandomAry(int[] arr)
        {
            int[] nilai = arr;
            return nilai;
        }

        //1.
        public static void Nomer1()
        {
            int[] arrINT = new int[6];
            arrINT[0] = 15;
            arrINT[1] = 2;
            arrINT[2] = 30;
            arrINT[3] = 12;
            arrINT[4] = 10;
            arrINT[5] = 5;

            QuizLogicDay02.DisplayArrayInt(arrINT);
            Console.WriteLine();
            int panjang = arrINT.Length;


            for (int index = 0; index < panjang; index++)
            {
                int NilaiSementara = arrINT[index];
                int RandomIndex = new Random().Next(0, panjang);
                arrINT[index] = arrINT[RandomIndex];
                arrINT[RandomIndex] = NilaiSementara;
            }

            QuizLogicDay02.DisplayArrayInt(arrINT);
        }

        //2. 
        public static void nomer2()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            int[] tampung = new int[angka.Length];
            int temp = 0;

            for (int i = 0; i <= angka.Length; i++)
            {
                temp = angka[0];
                for (int j = 0; j < angka.Length-1; j++)
                {
                    angka[j] = angka[j+1];
                }
                angka[angka.Length-1] = temp;
            }
            
            QuizLogicDay02.DisplayArrayInt(angka);

        }
        public static void nomer3()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            Console.Write("Masukan jumlah rotasi  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = angka[0];
                for (int j = 0; j < angka.Length - 1; j++)
                {
                    angka[j] = angka[j + 1];
                }
                angka[angka.Length - 1] = temp;

                Console.WriteLine($"Rotate Ke - {i + 1}");
                QuizLogicDay02.DisplayArrayInt(angka);
                Console.WriteLine();
                Console.WriteLine();
            }

            

        }
        //4.
        public static void nomer4()
        {
            int[] angka = new int[6];
            angka[0] = 15;
            angka[1] = 2;
            angka[2] = 30;
            angka[3] = 12;
            angka[4] = 10;
            angka[5] = 5;
            QuizLogicDay02.DisplayArrayInt(angka);
            Console.WriteLine();
            Console.Write("Masukan jumlah rotasi  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int tampung = 0;
            int banyak = angka.Length - 1;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp = angka[5];
                for (int j = 0; j < banyak; j++)
                {
                    tampung = j + 1;
                    angka[banyak - j] = angka[banyak - tampung];

                }
                angka[0] = temp;

                Console.WriteLine($"Rotate Ke - {i + 1}");
                QuizLogicDay02.DisplayArrayInt(angka);
                Console.WriteLine();
                Console.WriteLine();
            }

        }

        //5.
        public static int[] Nomer5(int[] counts)
        {
            int[] angka = counts;
            Array.Sort(angka);
            int ngitung;

            for (int i = 0; i < angka.Length; i++)
            {
                ngitung = 0;
                for (int j = 0; j < angka.Length; j++)
                {
                    if (angka[i] == angka[j])
                    {
                        ngitung++;
                    }
                }
                if (i < angka.Length -1 && angka[i] != angka[i+1])
                {
                    Console.WriteLine($"{angka[i]} muncul sebanyak {ngitung}");
                }
                else if (i == angka.Length -1)
                {
                    Console.WriteLine($"{angka[i]} muncul sebanyak {ngitung}");
                }
            }
            return angka;
        }
        //6.
        public static void Nomer6(int[] counts)
        {
            int[] arr = counts;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (i < arr.Length - 1 && temp == arr[i + 1])
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }
                    }

                }

            }
            DisplayArrayInt(arr);
        }
            //7.
            public static int nomer7(int[] counts)
        {
            int[] angka = counts;
            Array.Sort (angka);
            int panjang = angka.Length - 1;
            int n = 0;

            for (int i = 0; i < panjang; i++)
            {
                if (counts[i] != counts[i+1])
                {
                    angka[n++] = counts[i];
                }
            }
            angka[n++] = counts[panjang];

            for (int i = 0; i < n; i++)
            {
                counts[i] = angka[i];
            }
            return n;
        }
        // 8.
        public static void nomer8(int counts)
        {
            char[] nilai = new char[counts];
            var value = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            int count = 0;
            for (int i = 0; i < nilai.Length; i++)
            {
                nilai[i] = value[r.Next(0, 26)];
            }
            foreach (var item in nilai)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("----------RESULT----------");

            Array.Sort(nilai);
            for (int i = 0; i < nilai.Length; i++)
            {
                count = 0;
                for (int j = 0; j <= nilai.Length - 1; j++)
                {
                    if (nilai[i] == nilai[j])
                    {
                        count++;
                    }
                }
                if (i < nilai.Length - 1 && nilai[i] != nilai[i + 1])
                {
                    Console.Write($"{count} {nilai[i]} ");
                }
                else if (i == nilai.Length - 1)
                {
                    Console.Write($"{count} {nilai[i]} ");
                }

            }
        }


        //9.Buat program untuk menampilkan matrix seperti di gambar :

        public static int[,] Nomer9(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = matrix.GetLength(0);

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }

        //10.Buat program untuk menghitung total angka diagonal dari matrix, isi value matrix secara
        //random:
        public static int[,] Nomer10(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int counter = 0;
            int[] ngitung = new int[matrix.GetLength(0)];
            int jumlahngitung = 0;

            // fill matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // isi diagonal
                    if (i == j)
                    {
                        matrix[i, j] = counter++;
                        ngitung[i] = matrix[i, j];
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else if (i > j)
                    {
                        matrix[i, j] = 20;
                    }
                }
                jumlahngitung += ngitung[i];
            }
            Console.WriteLine($"Total jumlah matix diagonal  :  {jumlahngitung}");
            Console.WriteLine();
            return matrix;
            
        }

        // 11.Buat program untuk menampilkan matrix seperti di gambar :
        public static int[,] Nomer11(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];

            // fill matrix
            for (int i = 0; i <= matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1)-1; j++)
                {
                    // isi diagonal
                    if (i == 0 && j ==0)
                    {
                        matrix[i, j] = i;
                    }
                    else if (i == 0 && j!=0 && j!= matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = j;
                    }
                    else if (i == 0 && j != 0 && j == matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = j;
                    }
                    else if (j == 0 && i!=0 && i!= matrix.GetLength(0)-1)
                    {
                        matrix[i, j] = i;
                    }
                    else if (j == 0 && i != 0 && i == matrix.GetLength(0)-1)
                    {
                        matrix[i, j] = i;
                    }
                    
                    else if (j == matrix.GetLength(0)-1 && i != 0 && i!= matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = i+j;
                    }
                    else if (i == matrix.GetLength(0)-1 && j != 0 && j != matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = i + j;
                    }
                    else if (j == matrix.GetLength(0)-1 &&  i == matrix.GetLength(1)-1)
                    {
                        matrix[i, j] = i + j;
                    }
                }
            }
            return matrix;
        }

        //12.Buat program untuk menampilkan matrix seperti di gambar :
        public static int[,] Nomer12(int baris, int kolom)
        {
            int[,] matrix = new int[baris+1, kolom+1];
            int count1;
            int count2;
            count2 = 0;
            // fill matrix
            for (int i = 0; i < baris; i++)
            {
                count1 = 0;
                for (int j = 0; j < kolom; j++)
                {
                    matrix[i, j] = i + j;
                    count1 += matrix[i, j];
                    matrix[i, baris] = count1;
                    matrix[baris, i] = count1;
                    if (i==j)
                    {
                        count2 += matrix[i, j];
                        matrix[baris, baris] = count2;
                    }
                }
                
            }
            return matrix;
        }

        //13.Buat program untuk menampilkan matrix seperti di gambar :
        public static int[,] Nomer13(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int kel3 = 3;
            int urutanI = baris-1;
            int urutanJ = kolom-1;
            int nilaiawal = 2;
            int kalitiga = 3;

            for (int i = urutanI; i >= 0; i--)
            {
                for (int j = 0; j < kolom; j++)
                {                  
                    if(i == urutanI && j == 0 && j == urutanI)
                    {
                        matrix[i, j] = 9;
                    }
              
                    else if (i + j == urutanI)
                    {
                        if (i == j)
                        {
                                matrix[j, j] = kalitiga ;
                                kalitiga = kalitiga * 3;
                        }
                        else
                        {
                                matrix[i, j] = nilaiawal;
                                nilaiawal += 3;
                        }
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }

                }
            }

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    if (i + j > urutanI)
                    {
                        if (j == urutanI ) 
                        {
                            
                            if(i == 1)
                            {
                                kel3 *= 3;
                                matrix[i, j] = kel3;
                            }
                            else if( i == 5)
                            {
                                kel3 *= 3;
                                matrix[i, j] = kel3;
                            }
                            else
                            {
                                matrix[i, j] = nilaiawal;
                                nilaiawal += 3;
                            }
                                                      
                        }
                        else if (i== urutanI && j== urutanJ)
                        {
                            matrix[i, j] = nilaiawal;
                            nilaiawal += 3;
                        }
                        else if (i == urutanI && j != 0 && j != urutanJ)
                        {
                            if (j==3)
                            {
                                kel3 *= 3;
                                matrix[i, j] = kel3;
                            }

                            else
                            {
                                matrix[i, (i - j)] = nilaiawal;
                                nilaiawal += 3;
                            }
                        }
                    }
                }

            }
/*
            // fill matrix
            for (int i = 0; i < baris; i++)
            {

                for (int j = 0; j < kolom; j++)
                {
                    if (i == 0 && j != 0 && j == baris - 1)
                    {
                        matrix[i, j] = 20 - (3*i);
                    }
                    else if (i==j && i == kel3)
                    {
                        matrix[i, j] = 3;
                    }
                    else if (j == baris - 1 - i && i!= 0 && j!=0)
                    {
                        matrix[i, j] = 20 - (3 * i);
                    }
                    else if (i == baris-1 && j == 0 && j != matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 20 - (3 * i);
                    }
                    else if (j == baris - 1 && i != 0 && i != baris - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (i == baris - 1 && j != 0 && j != baris - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == baris - 1 && i == baris - 1)
                    {
                        matrix[i, j] = 1;
                    }
                }

            }*/


            return matrix;
        }

        //14
        public static int[,] Nomer14(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];

            // fill matrix
            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    // isi diagonal
                    if (i == 0 && j == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (i == 0 && j != 0 && j != matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (i == 0 && j != 0 && j == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == 0 && i != 0 && i != matrix.GetLength(0) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == 0 && i != 0 && i == matrix.GetLength(0) - 1)
                    {
                        matrix[i, j] = 1;
                    }

                    else if (j == matrix.GetLength(0) - 1 && i != 0 && i != matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (i == matrix.GetLength(0) - 1 && j != 0 && j != matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (j == matrix.GetLength(0) - 1 && i == matrix.GetLength(1) - 1)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;
        }

        //15.
        public static void nomer15(char[,] scors, char[] key)
        {
            char[,] nilai = scors;
            char[] kunci = key;
            int count = 0;
            for (int i = 0; i < nilai.GetLength(0); i++)
            {
                count = 0;
                Console.Write($"Student-{i} : ");
                for (int j = 0; j < nilai.GetLength(1); j++)
                {
                    Console.Write($"{nilai[i, j]} ");
                    if (nilai[i, j] == kunci[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine($"\nJawaban student {i} yang benar : {count}");
            }
        }

    }
}
