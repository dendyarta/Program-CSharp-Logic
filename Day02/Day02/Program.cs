using static System.Console;
using Day02;


//ArraysCase.IntroArray();

// call funtion
//int[] n = { 10, 20, 30 };
//var myArray = ArraysCase.InitArrayInt(n);

//ArraysCase.DisplayArrayInt(myArray);

//ArraysCase.InitArrayRandom(20);

/*var myRandom = ArraysCase.InitArrayRandom(5);

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

ReadLine();*/

//QuizLogicDay02.Nomer1();
//QuizLogicDay02.nomer2();
//QuizLogicDay02.nomer3();
//QuizLogicDay02.nomer4();

/** Matrix */
Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);



