// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
void FillArray(int[] collection) // создание и заполнение массива
{ 
 int length = collection.Length;
 int index = 0;
 while (index < length)
{
    collection[index] = new Random().Next(-100, 100);
    index++;
}
Console.WriteLine();
}
void PrintArray(int[] col) // вывод массива
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

//int Min (int[] array) //нахождение мин значения
//{
//int count = array.Length;
//int i= 0;
//Min(array);

//int Max (int[] array) //нахождение макс значения
//{
//int count = array.Length;
//int i= 0;
//int max = 0;
//while(i < count)
//{
//if(array[i] >= max)
//{
//max = array[i];
//Console.WriteLine($"Максимально число в массиве = {max}");
//}
//{
//i++;
//}
//}
//return max;
//}
//Max(array);
 
int Diminution(int[] col)  // разница max и min
{
int count = col.Length;
int max = 0;
int min = 0;
int DimMaxMin = 0;
for (int i = 0; i < col.Length; i++)
{
  if(array[i] > max)
{
max = array[i];
array[i] = max;
Console.WriteLine($"Максимально число в массиве = {max}");
}
if(array[i] < min)
{
min = array[i];
array[i] = min;
Console.WriteLine($"Минимальное число в массиве = {min}");  
}
DimMaxMin = max-min;
Console.WriteLine($"Разница между max и min = {DimMaxMin}"); 
}
return DimMaxMin;
}
Diminution(array);