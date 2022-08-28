using static System.Console;
using Day02;
using System.Diagnostics.Metrics;


//ArraysCase.IntroArray();

// call funtion
//int[] n = { 10, 20, 30 };
//var myArray = ArraysCase.InitArrayInt(n);

//ArraysCase.DisplayArrayInt(myArray);

//ArraysCase.InitArrayRandom(20);

var myRandom = ArraysCase.InitArrayRandom(5);

ArraysCase.DisplayArrayInt(myRandom);
WriteLine();
WriteLine($"Sum : {ArraysCase.SumAllElement(myRandom)}");
WriteLine($"Max : {ArraysCase.FindLargestElement(myRandom)}");

//Copy array ( cara 1 )
int[] newArray = new int[myRandom.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}
WriteLine();
//sort array
Array.Sort(newArray);
ArraysCase.DisplayArrayInt(newArray);

//gunakan method
var randomArray = new int[myRandom.Length];
Array.Copy(randomArray, 0, randomArray, 0, myRandom.Length);
Array.Reverse(randomArray);
ArraysCase.DisplayArrayInt(randomArray);

ReadLine();


//***Matrix * **
Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);



/*
 
    QuizLogicDay02

    QuizLogicDay02.Nomer1();
    QuizLogicDay02.nomer2();
    QuizLogicDay02.nomer3();
    QuizLogicDay02.nomer4();

 */

/*
//            **** Nomer 5 ****
var counts = new int[] { 1, 5, 3, 7, 8, 5, 1 };
QuizLogicDay02.Nomer5(counts);
*/

/*
//            **** Nomer 6 ****
var counts = new int[] { 1, 5, 3, 7, 8, 5, 1 };
var randomIndex = QuizLogicDay02.RandomAry(counts);
Console.WriteLine("Number : ");
QuizLogicDay02.DisplayArrayInt(randomIndex);
Console.WriteLine();
Console.WriteLine("After Marker : ");
QuizLogicDay02.Nomer6(counts);
Console.WriteLine();
*/

/*
//            **** Nomer 7 ****
var number = new int[] { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
var nilai = QuizLogicDay02.RandomAry(number);
Console.WriteLine("Number : ");
QuizLogicDay02.DisplayArrayInt(nilai);
Console.WriteLine();
var removeDuplicate = QuizLogicDay02.nomer7(number);
Console.WriteLine("After Delete Duplicate : ");
for (int i = 0; i < removeDuplicate; i++)
{
    Console.Write($"{number[i]} ");
    Console.WriteLine();
}
*/

/*
//            **** Nomer 8 ****
QuizLogicDay02.nomer8(100);
*/

/*//            **** Nomer 9 ****
var jawaban = QuizLogicDay02.Nomer9(5, 5);
Matrix.DisplayMatrix(jawaban);*/



/*//            **** Nomer 10 ****
var Jawaban = QuizLogicDay02.Nomer10(7, 7);
Matrix.DisplayMatrix(Jawaban);
*/

/*
//            **** Nomer 11 ****
var Jawaban = QuizLogicDay02.Nomer11(10, 10);
Matrix.DisplayMatrix(Jawaban);
*/

/*
//            **** Nomer 12 ****
var Jawaban = QuizLogicDay02.Nomer12(10, 10);
Matrix.DisplayMatrix(Jawaban);
*/
/*
//            **** Nomer 13 ****
var Jawaban = QuizLogicDay02.Nomer13(7, 7);
Matrix.DisplayMatrix(Jawaban);
*/
/*
//            **** Nomer 14 ****
var Jawaban = QuizLogicDay02.Nomer14(7, 7);
Matrix.DisplayMatrix(Jawaban);
*/
/*
//            **** Nomer 15 ****
char[,] scors = new char[,] {
                              {'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D'},
                              {'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D'},
                              {'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D'},
                              {'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                              {'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                            };
char[] key = new char[] { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
QuizLogicDay02.nomer15(scors, key);
*/