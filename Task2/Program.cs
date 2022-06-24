Console.WriteLine("Проверка. Является ли первое число квадратом второго.");
Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == Math.Pow(numberB, 2))
{
    Console.WriteLine("Да, является. ");
}
else
{
    Console.WriteLine("Нет, не является. ");
}