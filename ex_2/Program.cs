// Задача 36Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
void FillArray(int[] collection) // создание и заполнение массива
{ 
 int length = collection.Length;
 int index = 0;
 while (index < length)
{
    collection[index] = new Random().Next(1, 10);
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

void SelectionPos(int[] array) // вывод чисел, которые стоят на нечётной позиции ( для себя)
{
for (int i = 0; i < array.Length; i++)
{
if(i % 2 > 0) 
{
int OddPosition = i;
int Num_Odd_Position = array[i];
Console.WriteLine($"Число, стоящее на нечётной позиции = {Num_Odd_Position}");
}
}
}
SelectionPos(array);
Console.WriteLine();

int Sum(int[] collection)  // сумма чисел стоящих на нечётной позиции
{
int count = collection.Length;
int index = 0;
int SumNum_Odd_Position = 0;
while(index < count) 
{
if(index % 2 > 0)
{
SumNum_Odd_Position = SumNum_Odd_Position + array[index];
Console.WriteLine($"Сумма чисел, стоящих на нечётной позиции в массиве = {SumNum_Odd_Position}");
}
{
index++;
}
}
return SumNum_Odd_Position;
}
Sum(array);


