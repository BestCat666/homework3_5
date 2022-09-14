//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
void FillArray(int[] collection)
{ 
 int length = collection.Length;
 int index = 0;
 while (index < length)
{
    collection[index] = new Random().Next(100, 1000);
    index++;
}
Console.WriteLine();
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
{
    Console.Write($"{(position == 0 ? col[position] : "," + col[position])}");
    position++;
}
Console.WriteLine("]");
Console.WriteLine();
}

int [] array = new int [elementsCount]; // new int[число]; создать массив с определённым кол-ом чисел.изначально будет заполнен нулями
FillArray(array);
PrintArray(array);
int EvenNumbers = 0;
foreach (int el in array)
{
  if (el % 2 == 0)
{
 EvenNumbers = EvenNumbers + 1;
 }
}
Console.WriteLine($"количество чётных чисел в массиве = {EvenNumbers}");

