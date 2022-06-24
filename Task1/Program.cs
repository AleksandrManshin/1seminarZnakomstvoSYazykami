// <тип_данных> <имя переменной> = <значение>;
// <тип_данных> <имя переменной>;
//int number = 5; //integer
Console.WriteLine("Введите число которое нужно возвести в квадрат ");
int number = Convert.ToInt32(Console.ReadLine());//32 бит, 64 бит 
//Console.WriteLine(number*number);
//Console.WriteLine(Math.Pow(number, 2));
//Console.WriteLine(number + " в квадрате равно " + Math.Pow(number, 2));
Console.WriteLine($"{number} в квадрате равно  {number*number}");
//Console.WriteLine($"{number} 