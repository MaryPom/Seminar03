// Задача 5. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("Введите длину массива");
int length = int.Parse(Console.ReadLine());
int[] mas = new int[length];
Random rnd = new Random();
for(int i=0; i < mas.Length; i++)
{
mas[i]=rnd.Next(100,1000);
}
Console.WriteLine("Получившийся массив: " );
for(int i = 0; i < mas.Length; i++)
{
Console.WriteLine(mas[i] + " ");
}
int chetniye = 0;
int nechetniye = 0;
for(int i =0; i<mas.Length; i++)
{
if(mas[i]%2==0)
{
chetniye++;
}
else
{
nechetniye++;
}
}
Console.WriteLine("Четных: "+chetniye);
Console.WriteLine("Нечетных: "+nechetniye);