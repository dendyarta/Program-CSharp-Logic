// See https://aka.ms/new-console-template for more information

using Day03;

MyCollections.InitList();
MyCollections.InitStack();
MyCollections.InitDictionary();
MyCollections.InitHashSet();
MyCollections.InitQueue();

/*
 * Declare Method List
 */

// Declare LIST <T>

var list = new List<string>() { "Asep", "Budi", "Charlie"};
var student = MyCollections.GetStudent(ref list);

foreach (var item in student)
{
    Console.WriteLine($"{item}");
}

var numbers = new List<int> { 2,3,4,5,6 };
var myNumber = MyCollections.GetStudent(ref numbers);

foreach (var item in numbers)
{
    Console.WriteLine($"{item}");
}