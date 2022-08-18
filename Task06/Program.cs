// Задача 6. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] mas = new int[123];
Random rnd = new Random();
for(int i =0; i < mas.Length; i++)
{
mas[i]=rnd.Next();
}
int counter = 0;
for(int i=0; i < mas.Length; i++)
{
if(mas[i]>=10 && mas[i] <= 99)
{
counter++;
}
}
Console.WriteLine("Количество чисел из промежутка [10,99] = " + counter);