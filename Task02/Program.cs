// Задача 2. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Random Array = new Random();
int[] array = new int[12];
int sum = 0;
Console.WriteLine("Заданный массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Array.Next(0, 9);
    Console.Write(" " + array[i]);
    if(array[i] > 0)
    sum += array[i];
}
Console.WriteLine("Сумма положительных: " + sum);

