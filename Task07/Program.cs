// Задача 7. Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine());
int[] mas = new int[length];
for(int i = 0; i < length; i++)
{
Console.WriteLine("Введите " + i +" элемент: ");
mas[i]=int.Parse(Console.ReadLine());
}
int sum = 0;
for(int i=0; i < mas.Length; i++)
{
if(i%2==1)
{
sum+= mas[i];
}
}
Console.WriteLine("Сумма нечетных элементов: " + sum);
