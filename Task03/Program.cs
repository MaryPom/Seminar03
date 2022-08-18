// Задача 3. Написать программу замену элементов массива на противоположные
Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine());
int[] mas = new int[length];
for(int i = 0; i < length; i++)
{
Console.WriteLine("Введите " + i +" элемент: ");
mas[i]=int.Parse(Console.ReadLine());
}
for(int i = 0; i < mas.Length; i++)
{
mas[i]= mas[i]*(-1);
}
Console.WriteLine("Ответ: ");
for(int i=0; i<mas.Length; i++)
{
Console.Write(mas[i] + " ");
}