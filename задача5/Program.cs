Console.Clear();
Console.Write("Введите натуральное число: ");
int num=int.Parse(Console.ReadLine());
int i = -num;
while (i!=num+1)
{
Console.Write($" {i}");
i++;}

